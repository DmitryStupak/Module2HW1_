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

        public void LogWrite(LogType log)
        {
            Console.WriteLine(log.ToString());
            AddToLog(log.ToString());
        }

        public static List<string> GetLog()
        {
            return log;
        }

        private static void AddToLog(string str)
        {
            log.Add(str);
        }
    }
}
