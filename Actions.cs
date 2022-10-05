using System;
using System.Threading;

namespace Module2HW1
{
    public class Actions
    {
        public static Result First()
        {
            Logger log = Logger.Instance;
            log.LogWrite(new LogType(LogType.Log.Info, $"Start method : First "));
            Thread.Sleep(100);
            return new Result(true);
        }

        public static Result Second()
        {
            Logger log = Logger.Instance;
            log.LogWrite(new LogType(LogType.Log.Warning, $"Skipped logic in method : Second"));
            Thread.Sleep(100);
            return new Result(true);
        }

        public static Result Third()
        {
            Thread.Sleep(100);
            return new Result(false, "I broke a logic");
        }
    }
}