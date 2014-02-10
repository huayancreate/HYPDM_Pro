namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class InvokeInfoSetting
    {
        [DataMember]
        public bool Enabled { get; set; }
    }
}
