using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobey.CodeHelper.Common
{
    /// <summary>
    /// 日志
    /// </summary>
    public static class LogManager
    {
        public static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Error(object content)
        {
            log4net.LogManager.GetLogger(LogType.ErrorLog.ToString()).Error(Newtonsoft.Json.JsonConvert.SerializeObject(content));
        }

        public static void Debug(object content)
        {
            log4net.LogManager.GetLogger(LogType.DebugLog.ToString()).Debug(Newtonsoft.Json.JsonConvert.SerializeObject(content));
        }

        public static void Warn(object content)
        {
            log4net.LogManager.GetLogger(LogType.WarnLog.ToString()).Warn(Newtonsoft.Json.JsonConvert.SerializeObject(content));
        }

        public static void Info(object content)
        {
            log4net.LogManager.GetLogger(LogType.InfoLog.ToString()).Info(Newtonsoft.Json.JsonConvert.SerializeObject(content));
        }

    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogType
    {
        ErrorLog,
        DebugLog,
        WarnLog,
        InfoLog
    }
}
