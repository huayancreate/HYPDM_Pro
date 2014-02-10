namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class PasswordCheck
    {
        [DataMember]
        public bool Enable { get; set; }

        [DataMember]
        public OperationDirection Direction { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
