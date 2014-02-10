namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class StartInfoSetting
    {
        [DataMember]
        public bool Enabled { get; set; }
    }
}
