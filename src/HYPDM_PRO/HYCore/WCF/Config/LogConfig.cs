namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class LogConfig
    {
        [DataMember]
        public bool EnableExceptionInfo { get; set; }

        [DataMember]
        public bool EnableInvokeInfo { get; set; }

        [DataMember]
        public bool EnableMessageInfo { get; set; }
    }
}
