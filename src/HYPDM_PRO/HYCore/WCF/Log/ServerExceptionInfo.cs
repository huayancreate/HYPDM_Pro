namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public class ServerExceptionInfo : WcfExceptionInfo, IServerInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ServiceName { get; set; }

        [DataMember]
        public string InnerException { get; set; }
    }
}
