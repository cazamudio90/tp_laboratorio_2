using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DniInvalidoException : Exception
    {
        public DniInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
