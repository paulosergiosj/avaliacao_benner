using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Services.Exceptions
{
    public class PotenciaException:ApplicationException
    {
        public PotenciaException(string message) : base(message)
        {

        }
    }
}
