namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public class ServerMessageInfo : WcfMessageInfo, IServerInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ServiceName { get; set; }
    }
}
