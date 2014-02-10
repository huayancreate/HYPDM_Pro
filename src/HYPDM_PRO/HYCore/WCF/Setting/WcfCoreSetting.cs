namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfCoreSetting
    {
        [DataMember]
        public bool EnableUnity { get; set; }
    }
}
