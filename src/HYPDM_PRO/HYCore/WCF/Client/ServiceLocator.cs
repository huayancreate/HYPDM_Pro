namespace HYCoreLib.WcfExtension
{
    using System;
    using System.Threading;

    public class WcfServiceLocator
    {
        private static bool enableRemoteLogService = true;
        private static Timer logServiceCheckTimer;

        private readonly static TimeSpan NORMAL_CHECK_SPAN = TimeSpan.FromSeconds(1);
        private readonly static TimeSpan EXCEPTION_CHECK_SPAN = TimeSpan.FromSeconds(10);

        static WcfServiceLocator()
        {
            logServiceCheckTimer = new Timer(o =>
            {
                try
                {
                    using (var remoteLog = WcfServiceClientFactory.CreateServiceClient<IWcfLogService>())
                    {
                        remoteLog.Channel.Health();
                    }
                    if (logServiceCheckTimer != null)
                        logServiceCheckTimer.Change(NORMAL_CHECK_SPAN, NORMAL_CHECK_SPAN);
                    enableRemoteLogService = true;
                }
                catch (Exception ex)
                {
                    LocalLogService.Log(ex.ToString());
                    LocalLogService.Log("Remote log service is unavailable, use local log service replaced...");
                    enableRemoteLogService = false;
                    if (logServiceCheckTimer != null)
                        logServiceCheckTimer.Change(EXCEPTION_CHECK_SPAN, EXCEPTION_CHECK_SPAN);
                }
            }, null, NORMAL_CHECK_SPAN, NORMAL_CHECK_SPAN);
        }

        public static T Create<T>() where T : class
        {
            return (T)(new ServiceRealProxy<T>().GetTransparentProxy());
        }

        public static IWcfLogService GetLogService()
        {
            if (enableRemoteLogService)
                return (IWcfLogService)(new LogServiceRealProxy().GetTransparentProxy());
            else
                return new LocalLogService();
        }
    }
}
