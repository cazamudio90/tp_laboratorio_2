using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Excepciones;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        EClase ClaseQueToma;
        EEstadoCuenta EstadoCuenta;

        public Alumno(string nombre, string apellido, ENacionalidad nacionalidad, int Dni, int legajo, EClase ClaseQueToma, EEstadoCuenta EstadoCuenta)
            : base(nombre, apellido, nacionalidad, Dni, legajo)
        {
            this.ClaseQueToma1 = ClaseQueToma;
            this.EstadoCuenta1 = EstadoCuenta;
        }

        public EClase ClaseQueToma1 
        {
            get { return ClaseQueToma; }
            set { ClaseQueToma = value; }
        }
        public EEstadoCuenta EstadoCuenta1 
        {
            get { return EstadoCuenta; }
            set { EstadoCuenta = value; }
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASES DE: " + this.ClaseQueToma1 + "\n";
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + "\n " + this.ParticiparEnClase() + "\n Estado de cuenta: " + this.EstadoCuenta1;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a, EClase clase)
        {
            bool v_return = false;
            if (a.ClaseQueToma1 == clase && a.EstadoCuenta1 != EEstadoCuenta.Deudor)
            {
                v_return = true;
            }
            return v_return;
        }
        public static bool operator !=(Alumno a, EClase clase)
        {
            bool v_return = false;
            if (a.ClaseQueToma1 != clase)
            {
                v_return = true;
            }
            return v_return;
        }
    }
}
