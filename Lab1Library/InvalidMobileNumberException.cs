﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Library
{
    public class InvalidMobileNumberException : ApplicationException
    {
        public InvalidMobileNumberException(string msg = null) : base(msg)
        {

        }
    }
}
