namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfServerSetting : WcfSetting
    {
        [DataMember]
        public WcfCoreSetting WcfCoreSetting { get; set; }  
    }
}
