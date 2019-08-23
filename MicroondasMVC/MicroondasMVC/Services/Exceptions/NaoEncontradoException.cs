using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Services.Exceptions
{
    public class NaoEncontradoException:ApplicationException
    {
        public NaoEncontradoException(string message) : base(message)
        {

        }
    }
}
