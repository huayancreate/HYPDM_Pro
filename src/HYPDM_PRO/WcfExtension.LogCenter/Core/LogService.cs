using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace WcfExtension.LogCenter.Core
{
    /// <summary>
    /// 日志服务
    /// </summary>
    public class LogService
    {
        private static object locker = new object();

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Write(string message)
        {
            DoWrite(LogType.Info, message);
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void WriteDebug(string message)
        {
#if DEBUG
            DoWrite(LogType.Debug, message);//在debug模式下不记录日志
#endif
        }

        /// <summary>
        /// 写异常
        /// </summary>
        /// <param name="ex">异常</param>
        public static void Write(Exception ex)
        {
            DoWrite(LogType.Error, ex.ToString());
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="message">消息</param>
        private static void Write(LogType logType, string message)
        {
            DoWrite(logType, message);
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="message">消息</param>
        private static void DoWrite(LogType logType, string message)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(logType.ToString());
                sb.Append(" ");
                sb.Append(DateTime.Now.ToString());
                sb.Append(" ");
                sb.Append(message);
                sb.Append("\r\n");
                WriteLogFile(sb.ToString());

            }
            catch
            {
            }
        }


        private static void WriteLogFile(string content)
        {
            if (string.IsNullOrEmpty(content)) return;
            try
            {
                string tempDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
                if (!Directory.Exists(tempDirectory))
                {
                    Directory.CreateDirectory(tempDirectory);
                }
                lock (locker)
                {
                    //yyyyMMddhhmmss 
                    string FilePath = Path.Combine(tempDirectory, "log" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
                    File.AppendAllText(FilePath, content);
                }
            }
            catch { }
        }


        /// <summary>
        /// 日志类型
        /// </summary>
        public enum LogType
        {
            Debug = 1,
            Info = 2,
            Warning = 3,
            Error = 4
        }
    }
}
