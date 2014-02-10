namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public abstract class WcfMessageInfo : AbstractLogInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public MessageDirection MessageDirection { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
