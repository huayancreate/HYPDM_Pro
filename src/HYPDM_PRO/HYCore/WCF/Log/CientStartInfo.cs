namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    [KnownType(typeof(WcfClientEndpoint))]
    public class ClientStartInfo : StartInfo , IClientInfo
    {
        [DataMember]
        public string ContractName { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ClientTypeName { get; set; }

        [DataMember]
        public WcfClientEndpoint WcfEndpoint { get; set; }
    }
}
