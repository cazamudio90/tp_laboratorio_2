﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        EMarca marca;
        string chasis;
        ConsoleColor color;

        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public  ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        /// 
        public virtual string Mostrar() => (string)this;
        /*{
            return "chasis: " + this.chasis + "Color: " + this.color +  "Marca: " + this.marca + "Tamanio: " + this.Tamanio;
        }*/

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            bool v_return = false;
            
            if (v1.chasis == v2.chasis)
            {
                v_return = true;
            }

            return v_return;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator != (Vehiculo v1, Vehiculo v2)
        {
            bool v_return = false;

            if (!(v1.chasis == v2.chasis))
            {
                v_return = true;
            }

            return v_return;
        }
    }
}
