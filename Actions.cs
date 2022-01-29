using System;

namespace Module2HW1
{
    public class Actions
    {
        public static Result First()
        {
            Logger log = Logger.Instance;
            log.LogWrite(Logger.TypeLog.Info, $"Start method: First ");
            return new Result(true);
        }

        public static Result Second()
        {
            Logger log = Logger.Instance;
            log.LogWrite(Logger.TypeLog.Warning, $"Skipped logic in method: Second");
            return new Result(true);
        }

        public static Result Third()
        {
            return new Result(false, "I broke a logic");
        }
    }
}