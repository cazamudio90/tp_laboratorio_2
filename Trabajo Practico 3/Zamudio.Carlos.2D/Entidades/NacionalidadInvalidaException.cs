using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {
             Console.WriteLine(Message);
        }
    }
}
