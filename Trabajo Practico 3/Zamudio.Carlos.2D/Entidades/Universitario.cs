using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario(string nombre, string apellido, ENacionalidad nacionalidad, int Dni, int legajo): base( nombre,  apellido,  nacionalidad, Dni)
        {
            this.Legajo = legajo;
        }

        protected int Legajo 
        {
            get { return legajo; }
            set { legajo = value; }
        }

        protected virtual string MostrarDatos()
        {
            return base.ToString() + "\n Legajo: " + this.legajo;
        }

        protected abstract string ParticiparEnClase();

        public override bool Equals(object obj)
        {
            bool v_return = false;
            if (obj is Universitario)
            {

                if (this == (Universitario)obj)
                {
                    v_return = true;
                }

            }
            return v_return;
        }
        public static bool operator !=(Universitario p1, Universitario p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Universitario p1, Universitario p2)
        {
            bool v_return = false;
            if ( ((Universitario)p1 == (Universitario)p2) && (p1.DNI == p2.DNI || p1.legajo == p2.legajo) )
            {
                v_return = true;
            }
            return v_return;
        }

        
    }
}
