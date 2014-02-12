using PDM_Services_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WcfExtension;

namespace PDM_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            ServerManager.StartService(typeof(TestService));
            ServerManager.StartService(typeof(TestService2));
            Console.WriteLine("TestService Started...");
            Console.ReadLine();
        }
    }
}
