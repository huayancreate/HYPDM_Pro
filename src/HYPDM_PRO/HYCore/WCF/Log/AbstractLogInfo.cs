namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [KnownType(typeof(WcfExceptionInfo))]
    [KnownType(typeof(ServerExceptionInfo))]
    [KnownType(typeof(ClientExceptionInfo))]
    [KnownType(typeof(InvokeInfo))]
    [KnownType(typeof(ServerInvokeInfo))]
    [KnownType(typeof(ClientInvokeInfo))]
    [KnownType(typeof(WcfMessageInfo))]
    [KnownType(typeof(ServerMessageInfo))]
    [KnownType(typeof(ClientMessageInfo))]
    [KnownType(typeof(StartInfo))]
    [KnownType(typeof(ServerStartInfo))]
    [KnownType(typeof(ClientStartInfo))]
    [BsonIgnoreExtraElementsAttribute]
    public abstract class AbstractLogInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ID { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string RequestIdentity { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public DateTime Time { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string MachineName { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string MachineIP { get; set; }

        [DataMember]
        public string ExtraInfo { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.GetType().GetProperties().ToList().ForEach(p =>
            {
                var o = p.GetValue(this, null);
                sb.AppendLine(p.Name + ": " + o);
                if (o is Dictionary<string, string>)
                {
                    var dic = o as Dictionary<string, string>;
                    foreach (var key in dic)
                    {
                        sb.AppendLine(" " + key.Key + ": " + key.Value);
                    }
                }

            });

            return sb.ToString();
        }
    }
}
