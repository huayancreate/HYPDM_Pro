namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [KnownType(typeof(WcfService))]
    [BsonIgnoreExtraElementsAttribute]
    public class ServerStartInfo : StartInfo , IServerInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ServiceName { get; set; }

        [DataMember]
        public WcfService WcfService { get; set; }
    }
}
