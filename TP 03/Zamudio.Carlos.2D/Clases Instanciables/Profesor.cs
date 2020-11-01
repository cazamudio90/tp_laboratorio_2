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
        Queue<EClase> clasesDelDia;
        static Random random;

        public Queue<EClase> ClasesDelDia { get => clasesDelDia; set => clasesDelDia = value; }

        public Profesor(string nombre, string apellido, ENacionalidad nacionalidad, int dni, int legajo)
            : base(nombre, apellido, nacionalidad, dni, legajo)
        {
            this.ClasesDelDia = new Queue<EClase>();
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
            foreach (EClase clase in this.ClasesDelDia)
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
                this.ClasesDelDia.Enqueue( (EClase)random.Next(0, Enum.GetValues(typeof(EClase)).Length) );
            }
        }

        public static bool operator ==(Profesor i, EClase clase)
        {
            bool v_return = false;
            foreach (EClase claseAux in i.ClasesDelDia)
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
