namespace WcfExtension
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public class ServerInvokeInfo : InvokeInfo, IServerInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ServiceName { get; set; }

        [DataMember]
        public List<string> Parameters { get; set; }

        [DataMember]
        public List<string> Results { get; set; }
    }
}
