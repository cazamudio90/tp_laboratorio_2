using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int Dni;

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad, int Dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.Dni = Dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                Regex Val = new Regex(@"/^[a-zA-Z]+$/");
                if (!Val.IsMatch(value))
                {
                    nombre = null;
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public ENacionalidad Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public int DNI
        {
            get { return Dni; }
            set
            {
                try
                {
                    if (this.nacionalidad == ENacionalidad.Argentino && value >= 1 && value <= 89999999)
                    {
                        Dni = value;
                    }
                    else if (this.nacionalidad == ENacionalidad.Extranjero && value >= 90000000 && value <= 99999999)
                    {
                        Dni = value;
                    }
                    else
                    {
                        if (this.nacionalidad != ENacionalidad.Extranjero && this.nacionalidad != ENacionalidad.Argentino)
                        {
                            throw new NacionalidadInvalidaException("Nacionalidad invalida");
                        }

                    }
                }
                catch (NacionalidadInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    throw new DniInvalidoException("DNI INVALIDO");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.Nombre);
            sb.AppendFormat("Apellido: {0}", this.Apellido);
            sb.AppendFormat("Nacionalidad: {0}\n", this.Nacionalidad);
            sb.AppendFormat("DNI: {0}\n", this.DNI);
            return sb.ToString();
        }
    }
}
