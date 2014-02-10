using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace WcfExtension.LogCenter.Core
{
    /// <summary>
    /// 公共服务
    /// </summary>
    public class CommonService
    {

        public void PrintProperties<T>(T t)
        {
            if (t == null)
            {
                return;
            }

            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties.Length <= 0)
            {
                return;
            }

            foreach (PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    Console.WriteLine("{0}:{1}", name, value);
                }
                else
                {

                    PrintProperties(value);
                }
            }
        }
    }
}