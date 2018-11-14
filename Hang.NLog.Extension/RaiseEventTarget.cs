using NLog;
using NLog.Targets;
using System;

namespace Hang.NLog.Extension
{
    [Target("RaiseEvent")]
    public class RaiseEventTarget : TargetWithLayout
    {
        public static event EventHandler<LoggerEventArgs> WriteEvent;

        protected override void Write(LogEventInfo logEvent)
        {
            var args = new LoggerEventArgs(logEvent)
            {
                RenderLayout = Layout.Render(logEvent)
            };

            WriteEvent?.Invoke(null, args);
        }
    }
}
