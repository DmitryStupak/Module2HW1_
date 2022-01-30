using System;

namespace Module2HW1
{
    public class LogType
    {
        public LogType(string type, string str)
        {
            Time = DateTime.Now;
            Str = str;
            Type = type;
        }

        public DateTime Time { get; set; }
        public string Str { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{Time} : {Type} : {Str}";
        }
    }
}