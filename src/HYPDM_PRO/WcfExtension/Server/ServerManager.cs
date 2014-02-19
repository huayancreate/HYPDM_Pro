namespace WcfExtension
{
    using System;
    using System.ServiceModel;

    public class ServerManager
    {
        private static ServiceHost host;

        internal static bool TryRestartService(string typeName)
        {
            if (host != null && typeName == host.Description.ServiceType.FullName)
            {
                host.Close();
                StartService(host.Description.ServiceType);
                return true;
            }
            return false;
        }

        public static void StartService(Type serviceType)
        {
            try
            {
                host = WcfServiceHostFactory.CreateServiceHost(serviceType);
                host.Open();
                ConfigUpdateManager.InitServer();
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                throw;
            }
        }
    }
}
