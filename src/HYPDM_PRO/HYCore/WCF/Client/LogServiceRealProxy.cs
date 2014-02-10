namespace WcfExtension
{
    using System;
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Remoting.Proxies;

    internal class LogServiceRealProxy : RealProxy
    {
        public LogServiceRealProxy() : base(typeof(IWcfLogService)) { }

        public override IMessage Invoke(IMessage msg)
        {
            using (var client = WcfServiceClientFactory.CreateServiceClient<IWcfLogService>())
            {
                var channel = client.Channel;
                IMethodCallMessage methodCall = (IMethodCallMessage)msg;
                IMethodReturnMessage methodReturn = null;
                object[] copiedArgs = Array.CreateInstance(typeof(object), methodCall.Args.Length) as object[];
                methodCall.Args.CopyTo(copiedArgs, 0);
                try
                {
                    object returnValue = methodCall.MethodBase.Invoke(channel, copiedArgs);
                    methodReturn = new ReturnMessage(returnValue,
                                                    copiedArgs,
                                                    copiedArgs.Length,
                                                    methodCall.LogicalCallContext,
                                                    methodCall);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                    {
                        LocalLogService.Log(ex.InnerException.ToString());
                        methodReturn = new ReturnMessage(ex.InnerException, methodCall);
                    }
                    else
                    {
                        LocalLogService.Log(ex.ToString());
                        methodReturn = new ReturnMessage(ex, methodCall);
                    }
                }
                return methodReturn;
            }
        }
    }
}
