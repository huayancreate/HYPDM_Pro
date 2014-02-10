namespace WcfExtension.ConfigCenter
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using System.Xml.Linq;

    /// <summary>
    /// You can rewrite this class to implement your config persistence logic.
    /// </summary>
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "WcfExtension")]
    public class WcfConfigService : IWcfConfigService
    {
        public WcfService GetWcfService(string serviceType, string serviceContractVersion, string machineIP)
        {
            try
            {
                using (WcfConfigDataContext data = new WcfConfigDataContext())
                {
                    var wcfServices = data.Services.Where(s => s.ServiceType == serviceType).ToList();

                    var wcfService = wcfServices.Where(s => (machineIP.Contains(s.ServerMachineIP))).FirstOrDefault();

                    if (wcfService == null )
                        wcfService = wcfServices.Where(s => s.ServerMachineIP == "*" ).FirstOrDefault();

                    var service = new WcfService
                    {
                        ServiceType = serviceType,
                        ServiceBehaviorXml = wcfService.ServiceBehaviorXml != null ? wcfService.ServiceBehaviorXml.ToString() : "",
                        Endpoints = (from ep in data.ServiceEndpoints
                                     where ep.ServiceType == serviceType
                                     && ep.ServiceContractVersion == serviceContractVersion
                                     && (ep.ServerMachineIP == wcfService.ServerMachineIP || ep.ServerMachineIP == "*")
                                     select new WcfServiceEndpoint
                                     {
                                         EndpointBehaviorXml = ep.ServiceEndpointBehaviorXml != null ? ep.ServiceEndpointBehaviorXml.ToString() : "",
                                         EndpointBindingName = ep.ServiceEndpointBindingName,
                                         EndpointName = ep.ServiceEndpointName,
                                         EndpointPort = ep.ServiceEndpointPort,
                                         ServiceContractType = ep.ServiceContractType,
                                         EndpointBindingType = ep.Binding.BindingType,
                                         EndpointBindingXml = ep.Binding.BindingXml != null ? ep.Binding.BindingXml.ToString() : "",
                                         EndpointProtocol = ep.Binding.BindingProtocol
                                     }).ToArray()
                    };


                    return service;
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                return null;
            }
        }

        public WcfClientEndpoint GetWcfClientEndpoint(string serviceContractType, string serviceContractVersion, string machineIP)
        {
            try
            {
                using (WcfConfigDataContext data = new WcfConfigDataContext())
                {
                    var wcfClientEndpoint = (from ep in (data.ServiceEndpoints
                                             .Where(s => s.ServiceContractType == serviceContractType).ToList())
                                             where (ep.ServiceContractVersion == "" || float.Parse(ep.ServiceContractVersion) >= float.Parse(serviceContractVersion))
                                             orderby ep.ServiceContractVersion ascending, ep.Binding.BindingPriority descending
                                             select new WcfClientEndpoint
                                             {
                                                 EndpointName = ep.ServiceEndpointName,
                                                 EndpointPort = ep.ServiceEndpointPort,
                                                 ServiceContractType = ep.ServiceContractType,
                                                 EndpointBindingType = ep.Binding.BindingType,
                                                 EndpointBindingXml = ep.Binding.BindingXml != null ? ep.Binding.BindingXml.ToString() : "",
                                                 EndpointProtocol = ep.Binding.BindingProtocol,
                                                 ServiceType = ep.ServiceType,
                                             }).FirstOrDefault();

                    if (wcfClientEndpoint == null)
                    {
                        LocalLogService.Log("wcfClientEndpoint = null");
                        return null;
                    }
                    var wcfService = data.Services.Where(s => s.ServiceType == wcfClientEndpoint.ServiceType).FirstOrDefault();
                    if (wcfService == null)
                    {
                        LocalLogService.Log("wcfService = null");
                        return null;
                    }

                    var wcfServerFarm = wcfService.ServerFarm;
                    wcfClientEndpoint.EndpointAddress = wcfServerFarm.ServerFarmAddress;
                    wcfClientEndpoint.ServerFarmName = wcfServerFarm.ServerFarmName;

                    var accessableFarmNames = data.ClientAccesses.ToList().Where(acc => acc.ClientMachineIP == "*" || machineIP.Contains(acc.ClientMachineIP)).Select(a => a.AccessServerFarmName).ToList();
                    if (!accessableFarmNames.Contains("*") && !accessableFarmNames.Contains(wcfClientEndpoint.ServerFarmName))
                    {
                        LocalLogService.Log("accessableFarmNames = null");
                        return null;
                    }

                    var query =
                        (from ce in data.ClientEndpoints
                         where ce.ServiceContractType == wcfClientEndpoint.ServiceContractType
                         select ce.ClientEndpointBehaviorXml).FirstOrDefault();

                    wcfClientEndpoint.EndpointBehaviorXml = query != null ? query.ToString() : "";

                    return wcfClientEndpoint;
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                return null;
            }
        }

        public WcfClientSetting GetClientSetting(string serviceContractType, string machineIP)
        {
            var setting = new WcfClientSetting
            {
                WcfLogSetting = new WcfLogSetting
                {
                    Enabled = true,
                    ExceptionInfoSetting = new ExceptionInfoSetting
                    {
                        Enabled = false,
                    },
                    InvokeInfoSetting = new InvokeInfoSetting
                    {
                        Enabled = false,
                    },
                    StartInfoSetting = new StartInfoSetting
                    {
                        Enabled = true,
                    },
                    MessageInfoSetting = new MessageInfoSetting
                    {
                        Enabled = false,
                    }
                },
                WcfSecuritySetting = new WcfSecuritySetting
                {
                    PasswordCheck = new PasswordCheck
                    {
                        Enable = false,
                    }
                }
            };

            try
            {
                using (WcfConfigDataContext data = new WcfConfigDataContext())
                {
                    var endpoints = data.ClientEndpoints.Where(ep => ep.ServiceContractType == serviceContractType).ToList();
                    var e = endpoints.Where(endpoint => machineIP.Contains(endpoint.ClientMachineIP)).FirstOrDefault();
                    if (e == null) e = endpoints.Where(endpoint => endpoint.ClientMachineIP == "*").FirstOrDefault();
                    var clientConfig = e.ServiceConfig;
                    if (clientConfig != null)
                    {
                        if (clientConfig.Element("WcfLogSetting") != null)
                            ParseLogSettingXml(clientConfig.Element("WcfLogSetting"), setting.WcfLogSetting);
                    }
                    var serviceEndpoint = data.ServiceEndpoints.Where(se => se.ServiceContractType == serviceContractType).FirstOrDefault();
                    if (serviceEndpoint != null)
                    {
                        var service = data.Services.Where(s => s.ServiceType == serviceEndpoint.ServiceType).FirstOrDefault();
                        if (service != null)
                        {
                            var serviceConfig = service.ServiceConfig;
                            if (serviceConfig != null)
                            {
                                if (serviceConfig.Element("WcfSecuritySetting") != null)
                                    ParseSecuritySettingXml(serviceConfig.Element("WcfSecuritySetting"), setting.WcfSecuritySetting);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }

            return setting;
        }

        public WcfServerSetting GetServerSetting(string serviceType, string machineIP)
        {
            var setting = new WcfServerSetting
            {
                WcfCoreSetting = new WcfCoreSetting
                {
                    EnableUnity = false,
                },
                WcfLogSetting = new WcfLogSetting
                {
                    Enabled = true,
                    ExceptionInfoSetting = new ExceptionInfoSetting
                    {
                        Enabled = true,
                    },
                    InvokeInfoSetting = new InvokeInfoSetting
                    {
                        Enabled = false,
                    },
                    StartInfoSetting = new StartInfoSetting
                    {
                        Enabled = true,
                    },
                    MessageInfoSetting = new MessageInfoSetting
                    {
                        Enabled = false,
                    }
                },
                WcfSecuritySetting = new WcfSecuritySetting
                {
                     PasswordCheck = new PasswordCheck
                     {
                         Enable = false,
                     }
                }
            };

            try
            {
                using (WcfConfigDataContext data = new WcfConfigDataContext())
                {
                    var services = data.Services.Where(service => service.ServiceType == serviceType).ToList();
                    var s = services.Where(service => machineIP.Contains(service.ServerMachineIP)).FirstOrDefault();
                    if (s == null) s = services.Where(service => service.ServerMachineIP == "*").FirstOrDefault();
                    var config = s.ServiceConfig;
                    if (config != null)
                    {
                        if (config.Element("WcfLogSetting") != null)
                            ParseLogSettingXml(config.Element("WcfLogSetting"), setting.WcfLogSetting);
                        if (config.Element("WcfCoreSetting") != null)
                            ParseCoreSettingXml(config.Element("WcfCoreSetting"), setting.WcfCoreSetting);
                        if (config.Element("WcfSecuritySetting") != null)
                            ParseSecuritySettingXml(config.Element("WcfSecuritySetting"), setting.WcfSecuritySetting);
                    }
                }

            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }

            return setting;
        }

        private void ParseCoreSettingXml(XElement xml, WcfCoreSetting setting)
        {
            if (xml.Attribute("EnableUnity") != null) setting.EnableUnity = bool.Parse(xml.Attribute("EnableUnity").Value);
        }

        private void ParseSecuritySettingXml(XElement xml, WcfSecuritySetting setting)
        {
            var passwordCheck = xml.Descendants("PasswordCheck").FirstOrDefault();
            if (passwordCheck != null)
            {
                if (passwordCheck.Attribute("Enable") != null)
                    setting.PasswordCheck.Enable = bool.Parse(passwordCheck.Attribute("Enable").Value);
                if (passwordCheck.Attribute("Password") != null)
                    setting.PasswordCheck.Password = passwordCheck.Attribute("Password").Value;
                if (passwordCheck.Attribute("Direction") != null)
                    setting.PasswordCheck.Direction = (OperationDirection)Enum.Parse(typeof(OperationDirection), passwordCheck.Attribute("Direction").Value, true);
            }
        }

        private void ParseLogSettingXml(XElement xml, WcfLogSetting setting)
        {
            if (xml.Attribute("Enable") != null) setting.Enabled = bool.Parse(xml.Attribute("Enable").Value);
            var exceptionInfo = xml.Descendants("ExceptionInfo").FirstOrDefault();
            if (exceptionInfo != null)
            {
                if (exceptionInfo.Attribute("Enable") != null)
                    setting.ExceptionInfoSetting.Enabled = bool.Parse(exceptionInfo.Attribute("Enable").Value);
            }

            var invokeInfo = xml.Descendants("InvokeInfo").FirstOrDefault();
            if (invokeInfo != null)
            {
                if (invokeInfo.Attribute("Enable") != null)
                    setting.InvokeInfoSetting.Enabled = bool.Parse(invokeInfo.Attribute("Enable").Value);
            }

            var startInfo = xml.Descendants("StartInfo").FirstOrDefault();
            if (startInfo != null)
            {
                if (startInfo.Attribute("Enable") != null)
                    setting.StartInfoSetting.Enabled = bool.Parse(startInfo.Attribute("Enable").Value);
            }

            var messageInfo = xml.Descendants("MessageInfo").FirstOrDefault();
            if (messageInfo != null)
            {
                if (messageInfo.Attribute("Enable") != null)
                {
                    setting.MessageInfoSetting.Enabled = bool.Parse(messageInfo.Attribute("Enable").Value);
                    if (messageInfo.Attribute("Direction") != null)
                        setting.MessageInfoSetting.MessageDirection = (MessageDirection)Enum.Parse(typeof(MessageDirection), messageInfo.Attribute("Direction").Value, true);
                }
            }
        }
    }
}