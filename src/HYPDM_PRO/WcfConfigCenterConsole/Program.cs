using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfExtension.ConfigCenter;
using WcfExtension;
using System.Threading;
using System.ServiceModel;
using System.Configuration;

namespace WcfConfigCenterConsole
{
    /// <summary>
    /// This is the console host of config service, just for test.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConfigUpdateManager.InitHeart();

            try
            {
                using (var host = WcfServiceHostFactory.CreateServiceHost<WcfConfigService>())
                {
                    host.Open();
                    Console.WriteLine("Config service started");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}

