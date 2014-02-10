namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Configuration;
    using System.ServiceModel.Description;
    using System.Xml;

    public class WcfServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return CreateServiceHost(serviceType);
        }

        public static ServiceHost CreateServiceHost<T>()
        {
            return CreateServiceHost(typeof(T));
        }

        public static ServiceHost CreateServiceHost(Type serviceType)
        {
            string typeName = serviceType.FullName;
            var serviceHost = new ServiceHost(serviceType);
            if (!typeof(IWcfConfigService).IsAssignableFrom(serviceType) && !typeof(IWcfLogService).IsAssignableFrom(serviceType))
            {
                WcfSettingManager.Init(serviceType);

                if (serviceHost.Description.Behaviors.Find<ServiceErrorBehavior>() == null)
                    serviceHost.Description.Behaviors.Add(new ServiceErrorBehavior());
                if (serviceHost.Description.Behaviors.Find<ActionInterceptBehavior>() == null)
                    serviceHost.Description.Behaviors.Add(new ActionInterceptBehavior());

                if (WcfSettingManager.CurrentServerSetting(serviceType).WcfCoreSetting.EnableUnity)
                {
                    if (serviceHost.Description.Behaviors.Find<UnityServiceBehavior>() == null)
                        serviceHost.Description.Behaviors.Add(new UnityServiceBehavior());
                }

                serviceHost.Description.Endpoints.Clear();
                var wcfService = GetWcfServiceConfiguration(serviceType);
                if (wcfService == null)
                    throw new Exception("Can not locate any Wcf service, please check metadata config!");

                var bindingCache = new Dictionary<string, Binding>();

                foreach (var ep in wcfService.Endpoints)
                {
                    string address = ConfigHelper.CreateAddress(
                        ep.EndpointProtocol,
                        Environment.MachineName,
                        ep.EndpointPort,
                        ep.EndpointName);

                    Binding binding;
                    if (!bindingCache.TryGetValue(address, out binding))
                    {
                        binding = ConfigHelper.CreateBinding(ep.EndpointBindingType, ep.EndpointBindingXml);
                        bindingCache[address] = binding;
                    }

                    serviceHost.AddServiceEndpoint(ep.ServiceContractType, binding, address);

                    if (!string.IsNullOrEmpty(ep.EndpointBehaviorXml))
                    {
                        AddEndPointBehavior(serviceHost.Description.Endpoints.Last(), ep.EndpointBehaviorXml);
                    }
                }

                foreach (var ep in serviceHost.Description.Endpoints)
                {
                    ep.Behaviors.Add(new MessageInspectorEndpointBehavior());
                }

                if (!string.IsNullOrEmpty(wcfService.ServiceBehaviorXml))
                    AddServiceBehavior(serviceHost, wcfService.ServiceBehaviorXml);

                serviceHost.Opened += (sender, o) =>
                {
                    if (WcfSettingManager.CurrentServerSetting(serviceType).WcfLogSetting.StartInfoSetting.Enabled)
                    {
                        var log = WcfLogProvider.GetServerStartInfo(serviceType.FullName, "WcfServiceHostFactory.CreateServiceHost", wcfService);
                        WcfServiceLocator.GetLogService().LogWithoutException(log);
                    }

                };
            }

            return serviceHost;
        }

        private static void AddEndPointBehavior(ServiceEndpoint serviceEndpoint, string behavior)
        {
            var doc = new XmlDocument();
            doc.LoadXml(behavior);
            var endpointBehaviorElement = new EndpointBehaviorElement();
            ConfigHelper.Deserialize(doc.OuterXml, endpointBehaviorElement);
            foreach (var item in endpointBehaviorElement)
            {
                ConfigHelper.SetBehavior(serviceEndpoint.Behaviors, item);
            }
        }

        private static void AddServiceBehavior(ServiceHost serviceHost, string behavior)
        {
            var doc = new XmlDocument();
            doc.LoadXml(behavior);
            var serviceBehaviorElement = new ServiceBehaviorElement();
            ConfigHelper.Deserialize(doc.OuterXml, serviceBehaviorElement);
            foreach (var item in serviceBehaviorElement)
            {
                ConfigHelper.SetBehavior(serviceHost.Description.Behaviors, item);
            }
        }

        private static WcfService GetWcfServiceConfiguration(Type serviceType)
        {
            var version = serviceType.GetInterfaces().First().Assembly.GetName().Version;
            try
            {
                using (var scf = WcfServiceClientFactory.CreateServiceClient<IWcfConfigService>())
                {
                    return scf.Channel.GetWcfService(serviceType.FullName, version.Major + "." + version.Minor, WcfLogProvider.MachineIP);
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                throw new Exception("Can not get service metadata, error message is " + ex.Message);
            }
        }
    }
}
