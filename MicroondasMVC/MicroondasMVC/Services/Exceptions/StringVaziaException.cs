using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Services.Exceptions
{
    public class StringVaziaException:ApplicationException
    {
        public StringVaziaException(string message) : base(message)
        {

        }
    }
}
