using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WcfExtension.LogCenter.Core;

namespace WcfExtension.LogCenter
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "WcfExtension")]
    public class WcfLogService : IWcfLogService
    {
        public string Health()
        {
            return "OK";
        }

        public void Log(List<AbstractLogInfo> logInfo)
        {

#if DEBUG
            Console.WriteLine("===================================START=======================================");
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + logInfo.First().GetType().Name);
            logInfo.ForEach(Console.WriteLine);
            Console.WriteLine("=================================== END =======================================");
       
#endif
            if (logInfo == null || logInfo.Count == 0) return;

            // You can rerite rewrite this logic to implement your log persistence logic.
            MemoryQueue.BatchEnqueue(logInfo);
            
        }

        public void Log(AbstractLogInfo logInfo)
        {
            Log(new List<AbstractLogInfo> { logInfo });
        }
    }
}