namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.ServiceModel;
    using System.Threading;

    internal class WcfLogProvider
    {
        internal static string MachineIP { get; private set; }
        internal static string MachineName { get; private set; }

        static WcfLogProvider()
        {
            MachineIP = string.Join(" / ", Dns.GetHostAddresses(Dns.GetHostName()).Where(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Select(add => add.ToString()).ToArray());
            MachineName = Environment.MachineName;
        }

        private static string GetClientTypeName()
        {
            StackTrace strackTrace = new StackTrace();
            StackFrame[] stackFrames = strackTrace.GetFrames();
            StackFrame stackFrame = null;
            for (int i = 0; i < stackFrames.Length; i++)
            {
                if (stackFrames[i].GetMethod().DeclaringType.Assembly != typeof(WcfLogProvider).Assembly &&
                    stackFrames[i].GetMethod().DeclaringType.Assembly != typeof(Thread).Assembly &&
                    stackFrames[i].GetMethod().DeclaringType.Assembly != typeof(ChannelFactory).Assembly &&
                    !stackFrames[i].GetMethod().DeclaringType.IsInterface)
                {
                    stackFrame = stackFrames[i];
                    break;
                }
            }
            MethodBase methodBase = stackFrame.GetMethod();
            return methodBase.DeclaringType.FullName;
        }

        private static TAbstractLogInfo GetAbstractLogInfo<TAbstractLogInfo>(
            string requestIdentity,
            string extraInfo)
            where TAbstractLogInfo : AbstractLogInfo, new()
        {
            var abstractinfo = new TAbstractLogInfo()
            {
                ID = System.Guid.NewGuid().ToString(),
                MachineIP = MachineIP,
                MachineName = MachineName,
                Time = DateTime.Now,
                RequestIdentity = requestIdentity,
                ExtraInfo = extraInfo,
            };
            return abstractinfo;
        }

        private static TMessageInfo GetMessageInfo<TMessageInfo>(
            string requestIdentity,
            string extraInfo,
            MessageDirection direction,
            string message)
            where TMessageInfo : WcfMessageInfo, new()
        {
            var log = GetAbstractLogInfo<TMessageInfo>(requestIdentity, extraInfo);
            log.Message = message;
            log.MessageDirection = direction;
            return log;
        }

        private static TStartInfo GetStartInfo<TStartInfo>(
            string extraInfo)
          where TStartInfo : StartInfo, new()
        {
            var log = GetAbstractLogInfo<TStartInfo>(string.Empty, extraInfo);
            return log;
        }

        private static TInvokeInfo GetInvokeInfo<TInvokeInfo>(
            string extraInfo,
            long executionTime,
            bool isSuccessuful,
            string methodName,
            ApplicationContext context)
            where TInvokeInfo : InvokeInfo, new()
        {
            var invokeinfo = GetAbstractLogInfo<TInvokeInfo>(context == null ? string.Empty : context.RequestIdentity, extraInfo);
            invokeinfo.ExecutionTime = executionTime;
            invokeinfo.IsSuccessuful = isSuccessuful;
            invokeinfo.MethodName = methodName;
            invokeinfo.ApplicationContext = context;
            return invokeinfo;
        }

        private static TExceptionInfo GetExceptionInfo<TExceptionInfo>(
            string requestIdentity,
            string extraInfo,
            Exception exception)
            where TExceptionInfo : WcfExceptionInfo, new()
        {
            var exceptioninfo = GetAbstractLogInfo<TExceptionInfo>(requestIdentity, extraInfo);
            exceptioninfo.Type = exception.GetType().FullName;
            exceptioninfo.Message = exception.Message;
            exceptioninfo.StackTrace = exception.StackTrace;
            return exceptioninfo;
        }

        internal static ServerStartInfo GetServerStartInfo(
            string serviceName,
            string extraInfo,
            WcfService service)
        {
            var log = GetStartInfo<ServerStartInfo>(extraInfo);
            log.WcfService = service;
            log.ServiceName = serviceName;
            return log;
        }

        internal static ClientStartInfo GetClientStartInfo(
            string contractName,
            string extraInfo,
            WcfClientEndpoint endpoint)
        {
            var log = GetStartInfo<ClientStartInfo>(extraInfo);
            log.ContractName = contractName;
            log.ClientTypeName = GetClientTypeName();
            log.WcfEndpoint = endpoint;
            return log;
        }

        internal static ClientInvokeInfo GetClientInvokeLog(
            string contractName,
            string extraInfo,
            long executionTime,
            bool isSuccessuful,
            string methodName,
            ApplicationContext context)
        {
            var log = GetInvokeInfo<ClientInvokeInfo>(extraInfo, executionTime, isSuccessuful, methodName, context);
            log.ContractName = contractName;
            log.ClientTypeName = GetClientTypeName();
            return log;
        }

        internal static ServerInvokeInfo GetServerInvokeInfo(
            string extraInfo,
            long executionTime,
            bool isSuccessuful,
            string methodName,
            ApplicationContext context,
            List<string> parameters,
            List<string> results)
        {
            var log = GetInvokeInfo<ServerInvokeInfo>(extraInfo, executionTime, isSuccessuful, methodName, context);
            log.ServiceName = OperationContext.Current.GetCurrentServiceDescription().ServiceType.FullName;
            log.Parameters = parameters;
            log.Results = results;
            return log;
        }

        internal static ClientExceptionInfo GetClientExceptionInfo(
            string contractName,
            string requestIdentity,
            string extraInfo,
            Exception exception,
            string serverExceptionID)
        {
            var log = GetExceptionInfo<ClientExceptionInfo>(requestIdentity, extraInfo, exception);
            log.ContractName = contractName;
            log.ServerExceptionID = serverExceptionID;
            log.ClientTypeName = GetClientTypeName();
            return log;
        }

        internal static ServerExceptionInfo GetServerExceptionInfo(
            string extraInfo,
            Exception exception)
        {
            var log = GetExceptionInfo<ServerExceptionInfo>(ServerApplicationContext.Current.RequestIdentity, extraInfo, exception);
            log.ServiceName = OperationContext.Current.GetCurrentServiceDescription().ServiceType.FullName;
            log.InnerException = exception.InnerException == null ? string.Empty : exception.InnerException.ToString();
            return log;
        }

        internal static ClientMessageInfo GetClientMessageInfo(
            string contractName,
            string requestIdentity,
            string extraInfo,
            MessageDirection direction,
            string message)
        {
            var log = GetMessageInfo<ClientMessageInfo>(requestIdentity, extraInfo, direction, message);
            log.ContractName = contractName;
            log.ClientTypeName = GetClientTypeName();
            return log;
        }

        internal static ServerMessageInfo GetServerMessageInfo(
            string extraInfo,
            MessageDirection direction,
            string message)
        {
            var log = GetMessageInfo<ServerMessageInfo>(ServerApplicationContext.Current.RequestIdentity, extraInfo, direction, message);
            log.ServiceName = OperationContext.Current.GetCurrentServiceDescription().ServiceType.FullName;
            return log;
        }
    }
}
