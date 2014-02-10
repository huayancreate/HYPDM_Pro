namespace WcfExtension
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "WcfExtension")]
    public interface IWcfConfigService
    {
        [OperationContract]
        WcfService GetWcfService(string serviceType, string serviceContractVersion, string machineIP);

        [OperationContract]
        WcfClientEndpoint GetWcfClientEndpoint(string serviceContractType, string serviceContractVersion, string machineIP);

        [OperationContract]
        WcfClientSetting GetClientSetting(string serviceContractType, string machineIP);

        [OperationContract]
        WcfServerSetting GetServerSetting(string serviceType, string machineIP);
    }
}
