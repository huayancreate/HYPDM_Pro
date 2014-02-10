using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;


namespace WcfExtension.LogCenter.Core
{
    public class MemoryQueue
    {
        private static Queue<AbstractLogInfo> memoryInfoQueue = new Queue<AbstractLogInfo>();
        private static object memoryInfoQueueLocker = new object();
        private static bool enabled = true;
        private static List<Thread> workThreadList = new List<Thread>();
        //private static MemcachedClient mc = MemcachedClient.CacheClient;


        /// <summary>
        /// 批量保存数据到队列中
        /// </summary>
        /// <param name="infoList"></param>
        public static void BatchEnqueue(List<AbstractLogInfo> infoList)
        {
            lock (memoryInfoQueueLocker)
            {
                foreach (var info in infoList)
                {
                    if (memoryInfoQueue.Count >= ConfigProvider.Common.MemoryQueueMaxCount)
                        memoryInfoQueue.Dequeue();
                    memoryInfoQueue.Enqueue(info);
                }
            }
        }

        /// <summary>
        /// 从队列中读取数据
        /// </summary>
        /// <returns></returns>
        public static AbstractLogInfo Dequeue()
        {
            lock (memoryInfoQueueLocker)
            {
                if (memoryInfoQueue.Count > 0)
                    return memoryInfoQueue.Dequeue();
                return null;
            }
        }

        /// <summary>
        /// 获取队列中保存的记录数量
        /// </summary>
        /// <returns></returns>
        internal static int GetLength()
        {
            lock (memoryInfoQueueLocker)
            {
                return memoryInfoQueue.Count;
            }
        }

        /// <summary>
        /// 开始
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void Start()
        {
            ConfigProvider.Init();

            memoryInfoQueue = new Queue<AbstractLogInfo>();

            for (int i = 1; i <= ConfigProvider.Common.WorkThreadCount; i++)
            {
                Thread t = new Thread(WorkMethod) { IsBackground = true, Name = "WcfExtension.LogCenter.WcfLogServerQueueWorker " + i };
                workThreadList.Add(t);
            }

            foreach (Thread t in workThreadList)
            {
                t.Start();//开启线程
            }

            //自动创建索引
            Thread index = new Thread(() =>
            {
                Thread.Sleep(10000);//10秒
                while (enabled)
                {
                    try
                    {
                        new NoSqlMongoDB().CreateIndex();
                    }
                    finally
                    {
                        Thread.Sleep(60 * 60 * 1000);//一小时
                    }
                }
            });
            index.IsBackground = true;
            index.Start();

        }

        /// <summary>
        /// 结束
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void End()
        {
            enabled = false;
            foreach (var t in workThreadList)
            {
                t.Join();
            }
        }

        /// <summary>
        /// 工作线程
        /// </summary>
        private static void WorkMethod()
        {
            while (enabled)
            {
                Thread.Sleep(ConfigProvider.Common.WorkThreadSleepInterval);
                SaveBatch();
            }
        }

        /// <summary>
        /// 批量保存数据到数据库
        /// </summary>
        private static void SaveBatch()
        {
            //if (GetLength() < ConfigProvider.Common.SubmitToServerBatchSize) return;
            //定时批量提交
            List<AbstractLogInfo> list = new List<AbstractLogInfo>();
            for (int i = 0; i < ConfigProvider.Common.SubmitToServerBatchSize; i++)
            {
                var info = Dequeue();
                if (info != null)
                {
                    list.Add(info);
                }
            }
            if (list.Count > 0)
            {
                try
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    new NoSqlMongoDB().SaveData(list);
                    LogService.WriteDebug("SaveBatch：" + list.Count + "条 用时：" + sw.ElapsedMilliseconds + "ms");
                }
                catch (Exception ex)
                {
                    LogService.Write(ex.ToString());
                }
            }

        }
    }
}
