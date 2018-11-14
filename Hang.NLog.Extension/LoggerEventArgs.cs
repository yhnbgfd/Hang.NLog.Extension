using NLog;
using System;

namespace Hang.NLog.Extension
{
    /// <summary>
    /// 日志事件参数
    /// </summary>
    public class LoggerEventArgs : EventArgs
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Date => Info.TimeStamp;
        /// <summary>
        /// 等级
        /// </summary>
        public string Level => Info.Level.ToString();
        /// <summary>
        /// 对象名（不带命名空间）
        /// </summary>
        public string Logger => Info.LoggerName.Substring(Info.LoggerName.LastIndexOf('.') + 1);
        /// <summary>
        /// 内容
        /// </summary>
        public string Message => Info.Message;
        /// <summary>
        /// 格式化后的日志（本地保存时的格式）
        /// </summary>
        public string RenderLayout { get; set; }
        /// <summary>
        /// NLog.LogEventInfo（原始NLog对象）
        /// </summary>
        public LogEventInfo Info { get; set; }

        /// <summary>
        /// 传入NLog.LogEventInfo的构造函数
        /// </summary>
        /// <param name="info"></param>
        public LoggerEventArgs(LogEventInfo info)
        {
            Info = info;
        }
    }
}
