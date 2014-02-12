using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Services_Implementation
{
    public class LogService : ILogService
    {
        public void Log(string s)
        {
            Console.WriteLine(s);
        }
    }
}
