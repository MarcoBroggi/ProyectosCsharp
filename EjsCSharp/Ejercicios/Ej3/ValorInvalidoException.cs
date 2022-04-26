using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(string mensaje): base(mensaje)
        {

        }
    }
}
