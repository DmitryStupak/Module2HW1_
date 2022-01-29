using System;
using System.Collections.Generic;

namespace Module2HW1
{
    public class Logger
    {
        private static Logger instance = new Logger();
        private static List<string> log = new List<string>();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public enum TypeLog
        {
            Error,
            Info,
            Warning
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void LogWrite(object type, string str)
        {
            string logStr = $"{DateTime.Now} : {(TypeLog)type} : {str}";
            Console.WriteLine(logStr);
            AddToLog(logStr);
        }

        public static void AddToLog(string str)
        {
            log.Add(str);
        }

        public static List<string> GetLog()
        {
            return log;
        }
    }
}
