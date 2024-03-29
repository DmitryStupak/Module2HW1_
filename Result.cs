﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Result
    {
        public Result(bool status, string error)
        {
            Status = status;
            Error = error;
        }

        public Result(bool status)
        {
            Status = status;
            Error = string.Empty;
        }

        public bool Status { get; set; }
        public string Error { get; set; }
    }
}
