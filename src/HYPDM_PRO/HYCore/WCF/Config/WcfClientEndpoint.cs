namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfClientEndpoint : WcfEndpoint
    {
        [DataMember]
        public string EndpointAddress { get; set; }

        public string ServerFarmName { get; set; }

        public string ServiceType { get; set; }
    }
}
