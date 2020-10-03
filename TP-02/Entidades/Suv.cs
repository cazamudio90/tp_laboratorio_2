using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base( marca, chasis, color)
        {

        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected string Tamanio
        {
            get
            {
                return "Grande";
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine((string)this);
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
