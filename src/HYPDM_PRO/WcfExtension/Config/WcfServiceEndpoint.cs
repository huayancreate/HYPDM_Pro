namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfServiceEndpoint : WcfEndpoint
    {
        [DataMember]
        public string EndpointBindingName { get; set; }
    }
}
