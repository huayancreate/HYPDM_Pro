namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfSecuritySetting
    {
        [DataMember]
        public PasswordCheck PasswordCheck { get; set; }
    }
}
