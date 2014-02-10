namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    [KnownType(typeof(WcfClientSetting))]
    [KnownType(typeof(WcfServerSetting))]
    public abstract class WcfSetting
    {
        [DataMember]
        public WcfLogSetting WcfLogSetting { get; set; }

        [DataMember]
        public WcfSecuritySetting WcfSecuritySetting { get; set; }
    }
}
