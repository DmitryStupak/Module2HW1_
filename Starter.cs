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
                        Actions.First();
                        break;
                    case 2:
                        Actions.Second();
                        break;
                }

                if (num == 3)
                {
                    Logger log = Logger.Instance;
                    log.LogWrite(Logger.TypeLog.Error, $"Action failed by a reason:{Actions.Third().Error}");
                }
            }

            File.WriteAllLines("log.txt", Logger.GetLog());
        }
    }
}
