using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Services_Interface.Log
{
    public class LogService : ILogService
    {
        public void Log(string s)
        {
            Console.WriteLine(s);
        }
    }
}
