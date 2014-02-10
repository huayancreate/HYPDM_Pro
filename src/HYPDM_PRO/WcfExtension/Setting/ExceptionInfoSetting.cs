namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class ExceptionInfoSetting
    {
        [DataMember]
        public bool Enabled { get; set; }
    }
}
