using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfExtension.LogCenter.Core
{
    public class WcfLogServer
    {

        public static void Start()
        {
            LogService.Write("启动WcfLogService...");
            MemoryQueue.Start();
        }

        public static void End()
        {
            MemoryQueue.End();
            LogService.Write("关闭WcfLogService...");
        }



    }
}