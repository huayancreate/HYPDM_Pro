namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Configuration;
    using System.Xml;

    internal class WcfServiceClientFactory
    {
        private static readonly Dictionary<string, ChannelFactory> channelFactoryCache = new Dictionary<string, ChannelFactory>();
        private static readonly string WCFCONFIGSERVICE_ADDRESS_KEY = "configservice_address";
        private static readonly string WCFLOGSERVICE_ADDRESS_KEY = "logservice_address";
        private static readonly object cacheLocker = new object();

        private static ChannelFactory<T> CreateChannelFactory<T>(WcfClientEndpoint endpoint)
        {
            if (endpoint == null)
                throw new Exception("Can not locate any client endpoint, please check metadata config!");

            var binding = ConfigHelper.CreateBinding(endpoint.EndpointBindingType, endpoint.EndpointBindingXml);
            if (binding is NetNamedPipeBinding)
                endpoint.EndpointAddress = "localhost";
            var address = ConfigHelper.CreateAddress(endpoint.EndpointProtocol, endpoint.EndpointAddress, endpoint.EndpointPort, endpoint.EndpointName);
            var factory = new ChannelFactory<T>(binding, address);
            factory.Endpoint.Behaviors.Add(new MessageInspectorEndpointBehavior());
            if (!string.IsNullOrEmpty(endpoint.EndpointBehaviorXml))
                AddEndpointBehavior(factory, endpoint.EndpointBehaviorXml);
            return factory;
        }

        private static void AddEndpointBehavior(ChannelFactory factory, string behaviorXml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(behaviorXml);
            var endpointBehaviorElement = new EndpointBehaviorElement();
            ConfigHelper.Deserialize(doc.OuterXml, endpointBehaviorElement);
            foreach (var item in endpointBehaviorElement)
            {
                ConfigHelper.SetBehavior(factory.Endpoint.Behaviors, item);
            }
        }

        private static WcfClientEndpoint GetWcfClientEndpointConfiguration(Type serviceContractType)
        {
            var version = serviceContractType.Assembly.GetName().Version;
            var versionstring = version.Major + "." + version.Minor;
            try
            {
                using (var scf = WcfServiceClientFactory.CreateServiceClient<IWcfConfigService>())
                {
                    return scf.Channel.GetWcfClientEndpoint(serviceContractType.FullName, versionstring, WcfLogProvider.MachineIP);
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                throw new Exception("Can not get client metadata, error message is " + ex.Message);
            }
        }

        internal static bool TryRemoteChannelFactoryFromCache(string key)
        {
            ChannelFactory cf;
            if (channelFactoryCache.TryGetValue(key, out cf))
            {
                lock (cacheLocker)
                {
                    channelFactoryCache.Remove(key);
                }
                return true;
            }
            return false;
        }

        internal static WcfChannelWrapper<T> CreateServiceClient<T>() where T : class
        {
            string typeName = typeof(T).FullName;
            ChannelFactory cf;

            if (!channelFactoryCache.TryGetValue(typeName, out cf))
            {
                lock (cacheLocker)
                {
                    if (!channelFactoryCache.TryGetValue(typeName, out cf))
                    {
                        if (typeof(T) == typeof(IWcfConfigService))
                        {
                            var configServiceAddress = ConfigurationManager.AppSettings[WCFCONFIGSERVICE_ADDRESS_KEY];
                            if (string.IsNullOrEmpty(configServiceAddress))
                                throw new Exception("Please set [" + WCFCONFIGSERVICE_ADDRESS_KEY + "] appSettings in your config!");
                            var binding = new NetTcpBinding();
                            binding.Security.Mode = SecurityMode.None;
                            var address = string.Format("net.tcp://{0}", configServiceAddress);
                            cf = new ChannelFactory<IWcfConfigService>(binding, address);
                        }
                        else if (typeof(T) == typeof(IWcfLogService))
                        {
                            var logServiceAddress = ConfigurationManager.AppSettings[WCFLOGSERVICE_ADDRESS_KEY];
                            if (string.IsNullOrEmpty(logServiceAddress))
                                throw new Exception("Please set [" + WCFLOGSERVICE_ADDRESS_KEY + "] appSettings in your config!");
                            var elements = new List<BindingElement>();
                            elements.Add(new BinaryMessageEncodingBindingElement());
                            elements.Add(new TcpTransportBindingElement());
                            var binding = new CustomBinding(elements);
                            var address = string.Format("net.tcp://{0}", logServiceAddress);
                            cf = new ChannelFactory<IWcfLogService>(binding, address);
                        }
                        else
                        {
                            var endpoint = GetWcfClientEndpointConfiguration(typeof(T));                         
                            cf = CreateChannelFactory<T>(endpoint);

                            WcfSettingManager.Init<T>();
                            ConfigUpdateManager.InitClient();

                            if (WcfSettingManager.CurrentClientSetting<T>().WcfLogSetting.StartInfoSetting.Enabled)
                            {
                                var log = WcfLogProvider.GetClientStartInfo(typeof(T).FullName, "WcfServiceClientFactory.CreateServiceClient", endpoint);
                                WcfServiceLocator.GetLogService().LogWithoutException(log);
                            }
                        }

                        channelFactoryCache[typeName] = cf;
                    }
                }
            }

            return new WcfChannelWrapper<T>((cf as ChannelFactory<T>).CreateChannel());
        }
    }
}
