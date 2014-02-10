namespace WcfExtension
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract(Namespace = "WcfExtension")]
    public interface IWcfLogService
    {
        [OperationContract]
        string Health();

        [OperationContract(Name = "LogList", IsOneWay = true)]
        void Log(List<AbstractLogInfo> logInfo);

        [OperationContract(Name = "LogOne", IsOneWay = true)]
        void Log(AbstractLogInfo logInfo);
    }
}
