namespace WcfExtension
{
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Serialization;

    [CollectionDataContract(Namespace = "WcfExtension", ItemName = "Context")]
    public class ServerApplicationContext : ApplicationContext
    {
        public string ClientMachineName
        {
            get
            {
                return base["ClientMachineName"];
            }
            set
            {
                base["ClientMachineName"] = value;
            }
        }

        public string ClientVersion
        {
            get
            {
                return base["ClientVersion"];
            }
            set
            {
                base["ClientVersion"] = value;
            }
        }

        public static ServerApplicationContext Current
        {
            get
            {
                return CallContext.GetData(CallContextKey) as ServerApplicationContext;
            }
            set
            {
                CallContext.SetData(CallContextKey, value);
            }
        }
    }
}
