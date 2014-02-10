namespace WcfExtension
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "WcfExtension")]
    public class MessageInfoSetting
    {
        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        public MessageDirection MessageDirection { get; set; }
    }
}
