namespace WcfExtension
{
    using System;
    using System.Diagnostics;
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Remoting.Proxies;
    using System.ServiceModel;

    internal class ServiceRealProxy<T> : RealProxy where T : class
    {
        private bool IsLogService
        {
            get
            {
                return typeof(IWcfLogService).IsAssignableFrom(typeof(T));
            }
        }

        private WcfSetting WcfSetting
        {
            get
            {
                return WcfSettingManager.CurrentClientSetting<T>();
            }
        }

        private WcfLogSetting WcfLogSetting
        {
            get
            {
                return WcfSetting.WcfLogSetting;
            }
        }

        public ServiceRealProxy()
            : base(typeof(T))
        {
            if (IsLogService)
                throw new Exception("Please use ClientMessageInspector type to get IWcfLogService RealProxy!");
        }

        public override IMessage Invoke(IMessage msg)
        {
            using (var client = WcfServiceClientFactory.CreateServiceClient<T>())
            {
                var channel = client.Channel;
                IMethodCallMessage methodCall = (IMethodCallMessage)msg;
                IMethodReturnMessage methodReturn = null;
                object[] copiedArgs = Array.CreateInstance(typeof(object), methodCall.Args.Length) as object[];
                methodCall.Args.CopyTo(copiedArgs, 0);

                bool isSuccessuful = false;
                var stopwatch = Stopwatch.StartNew();

                try
                {
#if DEBUG
                    Console.WriteLine("Begin to invoke：" + methodCall.MethodName);
#endif
                    object returnValue = methodCall.MethodBase.Invoke(channel, copiedArgs);

#if DEBUG
                    Console.WriteLine("End invoke:" + methodCall.MethodName);
#endif
                    methodReturn = new ReturnMessage(returnValue,
                                                    copiedArgs,
                                                    copiedArgs.Length,
                                                    methodCall.LogicalCallContext,
                                                    methodCall);
                    isSuccessuful = true;
                }
                catch (Exception ex)
                {
                    var exception = ex;
                    var excepionID = ClientApplicationContext.Current.ServerExceptionID ?? "";
                    if (ex.InnerException != null)
                    {
                        exception = ex.InnerException;
                        exception.HelpLink = "Please check this exception via ID : " + excepionID;
                    }

                    methodReturn = new ReturnMessage(exception, methodCall);
                    if (WcfLogSetting.Enabled && WcfLogSetting.ExceptionInfoSetting.Enabled)
                    {
                        var log = WcfLogProvider.GetClientExceptionInfo(
                            typeof(T).FullName,
                            ClientApplicationContext.Current.RequestIdentity,
                            "ServiceRealProxy.Invoke",
                            exception, excepionID);
                        WcfServiceLocator.GetLogService().LogWithoutException(log);

                    }
                }
                finally
                {
                    if (WcfLogSetting.Enabled && WcfLogSetting.InvokeInfoSetting.Enabled)
                    {
                        var log = WcfLogProvider.GetClientInvokeLog(
                           typeof(T).FullName,
                           "ServiceRealProxy.Invoke",
                           stopwatch.ElapsedMilliseconds,
                           isSuccessuful,
                           methodCall.MethodName,
                           ClientApplicationContext.Current);
                        WcfServiceLocator.GetLogService().LogWithoutException(log);
                    }
                }
                return methodReturn;
            }
        }
    }
}
