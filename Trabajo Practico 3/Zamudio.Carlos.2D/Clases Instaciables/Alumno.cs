using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clases_Instaciables
{
    public sealed class Alumno : Universitario
    {
        EClase ClaseQueToma;
        EEstadoCuenta EstadoCuenta;

        public Alumno(string nombre, string apellido, ENacionalidad nacionalidad, int Dni, int legajo, EClase ClaseQueToma, EEstadoCuenta EstadoCuenta )
            : base(nombre, apellido, nacionalidad, Dni, legajo)
        {
            this.ClaseQueToma = ClaseQueToma;
            this.EstadoCuenta = EstadoCuenta;
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASES DE: " + this.ClaseQueToma + "\n";
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + "\n "+ this.ParticiparEnClase() + "\n Estado de cuenta: " + this.EstadoCuenta;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a, EClase clase)
        {
            bool v_return = false;
            if (a.ClaseQueToma == clase && a.EstadoCuenta != EEstadoCuenta.Deudor)
            {
                v_return = true;
            }               
            return v_return;
        }
        public static bool operator !=(Alumno a, EClase clase)
        {
            bool v_return = false;
            if (a.ClaseQueToma != clase)
            {
                v_return = true;
            }                
            return v_return;
        }
    }
}
