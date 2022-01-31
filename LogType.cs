using System;

namespace Module2HW1
{
    public class LogType
    {
        public LogType(Log type, string mes)
        {
            Time = DateTime.Now;
            Mes = mes;
            Type = type;
        }

        public enum Log
        {
            Info,
            Warning,
            Error
        }

        public DateTime Time { get; set; }
        public string Mes { get; set; }
        public Log Type { get; set; }
        public override string ToString()
        {
            return $"{Time} : {Type} : {Mes}";
        }
    }
}