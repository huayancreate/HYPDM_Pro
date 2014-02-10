namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfBinding
    {
        [DataMember]
        public string BindingName { get; set; }

        [DataMember]
        public string BindingType { get; set; }

        [DataMember]
        public int BindingPriority { get; set; }

        [DataMember]
        public string BindingXml { get; set; }

        [DataMember]
        public string BindingProtocol { get; set; }
    }
}
