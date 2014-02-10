namespace HYCoreLib.WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;

    internal class ClientMessageInspector : IClientMessageInspector
    {
        private static Dictionary<string, string> contractVersionCache = new Dictionary<string, string>();
        private static object locker = new object();

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
#if DEBUG
            var message = reply.ToString();
            Console.WriteLine("Client got message：" + message);
#endif
            ClientApplicationContext.Current = reply.GetApplicationContext<ClientApplicationContext>();    

            try
            {
                var setting = WcfSettingManager.CurrentClientSetting((correlationState as Type));
                var logSetting = setting.WcfLogSetting;
                if (logSetting.Enabled && logSetting.MessageInfoSetting.Enabled)
                {
                    var direct = logSetting.MessageInfoSetting.MessageDirection;
                    if (direct == MessageDirection.Both || direct == MessageDirection.Receive)
                    {
                        var log = WcfLogProvider.GetClientMessageInfo(
                          (correlationState as Type).FullName,
                          ClientApplicationContext.Current.RequestIdentity,
                          "ClientMessageInspector.AfterReceiveReply",
                          MessageDirection.Receive,
                          reply.ToString());

                        WcfServiceLocator.GetLogService().LogWithoutException(log);
                    }
                }

                var securitySetting = setting.WcfSecuritySetting;
                if (securitySetting.PasswordCheck.Enable)
                {
                    if (securitySetting.PasswordCheck.Direction == OperationDirection.Both || securitySetting.PasswordCheck.Direction == OperationDirection.Reply)
                    {
                        if (ClientApplicationContext.Current.Password != securitySetting.PasswordCheck.Password)
                            throw new WcfSecurityException("PasswordCheck failed in reply!");
                    }
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
                if (ex is WcfSecurityException) throw;
            }
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
#if DEBUG
            var message = request.ToString();
            Console.WriteLine("Client send message：" + message);
#endif
            try
            {
                var channelType = channel.GetType();

                var serverContext = new ServerApplicationContext();
                var clientContext = new ClientApplicationContext();
                clientContext.RequestIdentity = serverContext.RequestIdentity;
                ClientApplicationContext.Current = clientContext;

                var setting = WcfSettingManager.CurrentClientSetting(channelType);
                var securitySetting = setting.WcfSecuritySetting;
                if (securitySetting.PasswordCheck.Enable)
                {
                    if (securitySetting.PasswordCheck.Direction == OperationDirection.Both || securitySetting.PasswordCheck.Direction == OperationDirection.Request)
                    {
                        serverContext.Password = securitySetting.PasswordCheck.Password;
                    }
                }

                var logSetting = setting.WcfLogSetting;
                if (logSetting.Enabled && logSetting.MessageInfoSetting.Enabled)
                {
                    var direct = logSetting.MessageInfoSetting.MessageDirection;
                    if (direct == MessageDirection.Both || direct == MessageDirection.Send)
                    {
                        var log = WcfLogProvider.GetClientMessageInfo(
                        channelType.FullName,
                        ClientApplicationContext.Current.RequestIdentity,
                        "ClientMessageInspector.BeforeSendRequest",
                        MessageDirection.Send,
                        request.ToString());
                        WcfServiceLocator.GetLogService().LogWithoutException(log);
                    }
                }

                serverContext.RequestIdentity = Guid.NewGuid().ToString();
                serverContext.ClientMachineName = WcfLogProvider.MachineName;

                if (!contractVersionCache.ContainsKey(channelType.FullName))
                {
                    lock (locker)
                    {
                        if (!contractVersionCache.ContainsKey(channelType.FullName))
                        {
                            contractVersionCache.Add(channelType.FullName, channelType.Assembly.GetName().Version.ToString());
                        }
                    }
                }
                serverContext.ClientVersion = contractVersionCache[channelType.FullName];
                request.SetApplicationContext(serverContext);

                return channelType;
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }
            return channel.GetType();
        }
    }
}
