using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYHTTPRequestLib.Interface
{
    interface ISendRequset
    {
        bool AsynSend(string url, Dictionary<string, string> data);
        bool SynSend(string url, Dictionary<string, string> data);
    }
}
