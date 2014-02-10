namespace WcfExtension
{
    using System;
    using System.Collections.Generic;

    public class WcfSettingManager
    {
        private static Dictionary<string, WcfSetting> wcfSettings = new Dictionary<string, WcfSetting>();
        private static object locker = new object();

        public static WcfServerSetting CurrentServerSetting<T>()
        {
            return Current(typeof(T)) as WcfServerSetting;
        }

        public static WcfClientSetting CurrentClientSetting<T>()
        {
            return Current(typeof(T)) as WcfClientSetting;
        }

        public static WcfServerSetting CurrentServerSetting(Type type)
        {
            return Current(type) as WcfServerSetting;
        }

        public static WcfClientSetting CurrentClientSetting(Type type)
        {
            return Current(type) as WcfClientSetting;
        }

        private static WcfSetting Current<T>()
        {
            return Current(typeof(T));
        }

        private static WcfSetting Current(Type type)
        {
            var key = type.FullName;
            return wcfSettings[key];
        }

        public static void Init(Type type)
        {
            var typeName = type.FullName;
            lock (locker)
            {
                if (wcfSettings.ContainsKey(typeName))
                    wcfSettings.Remove(type.FullName);

                WcfSetting setting = null;
                if (type.IsInterface)
                {
                    using (var client = WcfServiceClientFactory.CreateServiceClient<IWcfConfigService>())
                    {
                        setting = client.Channel.GetClientSetting(typeName, WcfLogProvider.MachineIP);
                    }
                }
                else
                {
                    using (var client = WcfServiceClientFactory.CreateServiceClient<IWcfConfigService>())
                    {
                        setting = client.Channel.GetServerSetting(typeName, WcfLogProvider.MachineIP);
                    }
                }
                wcfSettings.Add(typeName, setting);
            }
        }

        public static void Init<T>()
        {
            Init(typeof(T));
        }
    }
}