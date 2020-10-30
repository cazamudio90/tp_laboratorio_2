using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    class DniInvalidoException : Exception
    {
        public DniInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
