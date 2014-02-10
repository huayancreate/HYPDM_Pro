namespace WcfExtension
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;

    internal class ErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            try
            {
#if DEBUG
                Console.WriteLine("Exception in service！ Message:{0}, id : {1}", error.Message, error.Data["id"]);
#endif
                var logSetting = WcfSettingManager.CurrentServerSetting(OperationContext.Current.GetCurrentServiceDescription().ServiceType).WcfLogSetting;
                if (logSetting.Enabled && logSetting.ExceptionInfoSetting.Enabled)
                {
                    var exceptionID = error.Data["id"].ToString();

                    var log = WcfLogProvider.GetServerExceptionInfo("ErrorHandler.HandleErrer", error);
                    log.ID = exceptionID;
                    WcfServiceLocator.GetLogService().LogWithoutException(log);
                }

            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            try
            {
                var errorid = Guid.NewGuid().ToString();
                error.Data.Add("id", errorid);
                ServerApplicationContext.Current.ServerExceptionID = errorid;
                FaultException fe = new FaultException(new FaultReason(error.Message));
                MessageFault messagefault = fe.CreateMessageFault();
                fault = Message.CreateMessage(version, messagefault, "http://www.5173.com");
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }
        }
    }
}