﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Services.Exceptions
{
    public class TempoException:ApplicationException
    {
        public TempoException(string message) : base(message)
        {

        }
    }
}
