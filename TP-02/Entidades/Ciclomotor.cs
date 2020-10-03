using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected string Tamanio
        {
            get
            {
                return ETamanio.Chico.ToString();
            }
        }

        public  override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine((string)this);
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
