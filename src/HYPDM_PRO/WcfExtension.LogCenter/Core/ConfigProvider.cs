using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml;
using System.Web;
using System.Web.Caching;

namespace WcfExtension.LogCenter.Core
{
    class ConfigProvider
    {
        private static string AppInfoCenterServiceConfigFilePath = "Config\\WcfLogServer.config";
        private static readonly string CacheAppInfoCenterConfigFilePathDependencyKey = "CacheWcfLogConfigFilePathDependency";
        /// <summary>
        /// WcfLog存储节点
        /// </summary>
        internal static readonly string MemcacheWcfLogGroupKey = "WcfLog";

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void Init()
        {
            try
            {

                string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppInfoCenterServiceConfigFilePath);

                LogService.Write("载入配置文件:" + configFilePath);

                HttpRuntime.Cache.Insert(CacheAppInfoCenterConfigFilePathDependencyKey, "",
                    new CacheDependency(configFilePath),
                    Cache.NoAbsoluteExpiration,
                    Cache.NoSlidingExpiration,
                    CacheItemPriority.Default, AppInfoCenterServiceConfigFileUpdated);

                XmlDocument xml = new XmlDocument();
                xml.Load(configFilePath);

                XmlNode appInfoCenter = xml.SelectSingleNode("WcfLogServer");
                {
                    XmlNode common = appInfoCenter.SelectSingleNode("Common");
                    if (common != null)
                    {
                        if (common.SelectSingleNode("WorkThreadCount") != null)
                        {
                            int.TryParse(common.SelectSingleNode("WorkThreadCount").InnerText, out Common.WorkThreadCount);
                        }

                        if (common.SelectSingleNode("WorkThreadSleepInterval") != null)
                        {
                            int.TryParse(common.SelectSingleNode("WorkThreadSleepInterval").InnerText, out Common.WorkThreadSleepInterval);
                        }

                        if (common.SelectSingleNode("SubmitToServerBatchSize") != null)
                        {
                            int.TryParse(common.SelectSingleNode("SubmitToServerBatchSize").InnerText, out Common.SubmitToServerBatchSize);
                        }

                        if (common.SelectSingleNode("MemoryQueueMaxCount") != null)
                        {
                            int.TryParse(common.SelectSingleNode("MemoryQueueMaxCount").InnerText, out Common.MemoryQueueMaxCount);
                        }

                        if (common.SelectSingleNode("MongoConnWcfLog") != null)
                        {
                            Common.MongoConnWcfLog = common.SelectSingleNode("MongoConnWcfLog").InnerText;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }

        }

        private static void AppInfoCenterServiceConfigFileUpdated(string key, object value, CacheItemRemovedReason reason)
        {
            Init();
        }

        /// <summary>
        /// 公共信息
        /// </summary>
        public static class Common
        {
            /// <summary>
            /// 工作线程数
            /// </summary>
            public static int WorkThreadCount = Environment.ProcessorCount * 2;

            /// <summary>
            /// 工作线程休眠时间,单位毫秒
            /// </summary>
            public static int WorkThreadSleepInterval = 50;

            /// <summary>
            /// 批量提交记录的大小
            /// </summary>
            public static int SubmitToServerBatchSize = 500;

            /// <summary>
            /// 内存队列最大记录数
            /// </summary>
            public static int MemoryQueueMaxCount = 50000;

            /// <summary>
            /// WcfLog MongoDB 数据库链接
            /// </summary>
            public static string MongoConnWcfLog = "";

            /// <summary>
            /// 已创建索引列表
            /// </summary>
            public static List<string> DicInfoSetting = new List<string>();
        }

    }
}
