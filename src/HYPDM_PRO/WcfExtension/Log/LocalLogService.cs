namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class LocalLogService : IWcfLogService
    {
        private static object locker = new object();
        private static Timer changePathTimer;
        private static readonly int CHANGEPATHINTERVAL = 60 * 60 * 1000;

        static LocalLogService()
        {
            changePathTimer = new Timer(state =>
            {
                lock (locker)
                {
                    Init();
                }
            }, null, CHANGEPATHINTERVAL, CHANGEPATHINTERVAL);
            Init();
        }

        private static void Init()
        {
            var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wcflog");
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);
            Debug.Listeners.Clear();
            Debug.Listeners.Add(new TextWriterTraceListener(logPath + "/wcflog" + DateTime.Now.ToString("yyyyMMdd") + ".txt"));
            Debug.AutoFlush = true;
        }

        public static void Log(string text)
        {
            lock (locker)
            {
                Debug.WriteLine("================================== START ======================================");
                Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                Debug.WriteLine(text);
                Debug.WriteLine("=================================== END =======================================");
            }
        }

        public string Health()
        {
            throw new NotImplementedException("Local log service does not need to support this!");
        }

        public void Log(List<AbstractLogInfo> logInfo)
        {
            Debug.WriteLine("================================== START ======================================");
            Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + logInfo.First().GetType().Name);
            logInfo.ForEach(item => Debug.WriteLine(item));
            Debug.WriteLine("=================================== END =======================================");
        }

        public void Log(AbstractLogInfo logInfo)
        {
            Log(new List<AbstractLogInfo> { logInfo });
        }
    }
}
