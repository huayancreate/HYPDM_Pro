using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfExtension;
using WcfExtension.LogCenter;
using WcfExtension.LogCenter.Core;

namespace WcfLogCenterConsole
{
    /// <summary>
    /// This is the console host of log service, just for test.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WcfLogServer.Start();
            try
            {
                using (var host = WcfServiceHostFactory.CreateServiceHost<WcfLogService>())
                {
                    host.Open();
                    Console.WriteLine("Log service started");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            WcfLogServer.End();
        }
    }
}

