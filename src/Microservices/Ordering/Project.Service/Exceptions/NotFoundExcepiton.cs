﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Exceptions
{
    public class NotFoundExcepiton : Exception
    {
        public NotFoundExcepiton(string message) : base(message)
        {

        }
    }
}
