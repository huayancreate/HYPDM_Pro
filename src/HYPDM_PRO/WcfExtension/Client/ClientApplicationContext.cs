namespace WcfExtension
{
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Serialization;

    [CollectionDataContract(Namespace = "WcfExtension", ItemName = "Context")]
    public class ClientApplicationContext : ApplicationContext
    {
        public string ServerMachineName
        {
            get
            {
                return base["ServerMachineName"];
            }
            set
            {
                base["ServerMachineName"] = value;
            }
        }

        public string ServerVersion
        {
            get
            {
                return base["ServerVersion"];
            }
            set
            {
                base["ServerVersion"] = value;
            }
        }

        public static ClientApplicationContext Current
        {
            get
            {
                return CallContext.GetData(CallContextKey) as ClientApplicationContext;
            }
            set
            {
                CallContext.SetData(CallContextKey, value);
            }
        }
    }
}
