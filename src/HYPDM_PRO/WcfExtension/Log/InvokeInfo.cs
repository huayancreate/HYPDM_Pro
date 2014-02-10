namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [KnownType(typeof(ApplicationContext))]
    [BsonIgnoreExtraElementsAttribute]
    public abstract class InvokeInfo : AbstractLogInfo
    {
        [DataMember]
        public long ExecutionTime { get; set; }

        [DataMember]
        public bool IsSuccessuful { get; set; }

        [DataMember]
        public string MethodName { get; set; }

        [DataMember]
        public ApplicationContext ApplicationContext { get; set; }
    }
}
