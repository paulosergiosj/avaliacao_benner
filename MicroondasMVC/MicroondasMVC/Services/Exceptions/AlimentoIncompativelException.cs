using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Services.Exceptions
{
    public class AlimentoIncompativelException:ApplicationException
    {
        public AlimentoIncompativelException(string message) : base(message)
        {

        }
    }
}
