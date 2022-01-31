using System;
using System.IO;

namespace Module2HW1
{
    public static class Starter
    {
        public static void Run()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = rand.Next(1, 4);
                switch (num)
                {
                    case 1:
                        if (!Actions.First().Status)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {Actions.First().Error}"));
                        }

                        break;
                    case 2:
                        if (!Actions.Second().Status)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {Actions.Second().Error}"));
                        }

                        break;
                    case 3:
                        if (!Actions.Third().Status)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {Actions.Third().Error}"));
                        }

                        break;
                }

                File.WriteAllLines("log.txt", Logger.GetLog());
            }
        }
    }
}
