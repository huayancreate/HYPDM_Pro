using System;
using System.Collections.Generic;
using System.Text;

namespace WcfExtension.LogCenter.Core
{
    [Serializable]
    public class PerformanceCounterItem
    {
        public PerformanceCounterItem()
        {
            MachineName = Environment.MachineName;
        }

        public string MachineName { get; set; }

        public string CategoryName { get; set; }

        public string InstanceName { get; set; }

        public string CounterName { get; set; }

        public string Value { get; set; }

        public string Key
        {
            get
            {
                return string.Format("{0}_{1}_{2}_{3}", MachineName, CategoryName, InstanceName, CounterName);
            }
        }
    }
}
