using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClase> clasesDelDia;
        private static Random random;

        public Profesor(string nombre, string apellido, ENacionalidad nacionalidad, int dni, int legajo)
            : base(nombre, apellido, nacionalidad, dni, legajo)
        {
            this.clasesDelDia = new Queue<EClase>();
            randomClases();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Legajo: {0}", this.Legajo);
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CLASES DEL DÍA:\n");
            foreach (EClase clase in this.clasesDelDia)
            {
                sb.AppendFormat("{0}\n", clase);
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        private void randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue( (EClase)random.Next(0, Enum.GetValues(typeof(EClase)).Length) );
            }
        }

        public static bool operator ==(Profesor i, EClase clase)
        {
            bool v_return = false;
            foreach (EClase claseAux in i.clasesDelDia)
            {
                if (claseAux.Equals(clase))
                {
                    v_return = true;
                }
            }
            return v_return;
        }
        public static bool operator !=(Profesor i, EClase clase)
        {
            return !(i == clase);
        }
    }
}
