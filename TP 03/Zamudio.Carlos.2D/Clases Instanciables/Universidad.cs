using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Instanciables
{
    public class Universidad
    {
        List<Alumno> alumnos;
        List<Profesor> profesores;
        List<Jornada> jornadas;

        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            jornadas = new List<Jornada>();
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }
        public Jornada this[int indice]
        {
            get
            {
                if (indice >= this.jornadas.Count || indice < 0)
                {
                    return null;
                }
                else
                {
                    return this.jornadas[indice];
                }
            }
            set
            {
                if (indice >= 0 && indice < this.jornadas.Count)
                {
                    this.jornadas[indice] = value;
                }
            }
        }

        public static bool operator ==(Universidad universidad, Alumno alumno)
        {
            bool v_return = false;

            foreach (Alumno aux in universidad.alumnos)
            {
                if (aux.DNI == alumno.DNI)
                {
                    v_return = true;
                }
            }
            return v_return;
        }
        public static bool operator !=(Universidad universidad, Alumno alumno)
        {
            return !(universidad == alumno);
        }

        public static bool operator ==(Universidad universidad, Profesor profesor)
        {
            bool v_return = false;

            foreach (Profesor aux in universidad.profesores)
            {
                if (aux.DNI == profesor.DNI)
                {
                    v_return = true;
                }
            }
            return v_return;
        }
        public static bool operator !=(Universidad universidad, Profesor profesor)
        {
            return !(universidad == profesor);
        }

        public static Universidad operator +(Universidad universidad, EClase clase)
        {
            foreach (Jornada aux in universidad.Jornadas)
            {
                if (aux.Clase1 == clase)
                {
                    universidad.jornadas.Add(new Jornada(aux.Profesor1, clase));
                    break;
                }
            }

            foreach (Alumno aux in universidad.alumnos)
            {
                if (aux.ClaseQueToma1 == clase)
                {
                    universidad.jornadas[universidad.jornadas.Count - 1] = universidad.jornadas[universidad.jornadas.Count - 1] + aux;
                }
            }
            return universidad;
        }

        public static Universidad operator +(Universidad universidad, Alumno alumno)
        {
            if (!(universidad == alumno))
            {
                universidad.alumnos.Add(alumno);
            }
            else
            {
                throw new AlumnoRepetidoException("Ya existe el alumno");
            }

            return universidad;
        }

        public static Universidad operator +(Universidad universidad, Profesor profesor)
        {
            if (!(universidad == profesor))
            {
                universidad.profesores.Add(profesor);
            }

            return universidad;
        }

        public static Profesor operator ==(Universidad universidad, EClase clase)
        {

            foreach (Profesor aux in universidad.profesores)
            {
                if (aux.ClasesDelDia.Dequeue() == clase)
                {
                    return aux;
                }
            }

            throw new SinProfesorException("No hay profesor disponible");

        }

        public static Profesor operator !=(Universidad universidad, EClase clase)
        {
            foreach (Profesor aux in universidad.profesores)
            {
                if (aux.ClasesDelDia.Dequeue() == clase)
                {
                    return aux;
                }
            }
            throw new SinProfesorException("No hay profesor disponible");
        }

        private static string MostrarDatos(Universidad universidad)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada aux in universidad.jornadas)
            {
                sb.Append("JORNADA:\n");
                sb.Append(aux.ToString());
                sb.AppendLine("--------------------------");
                sb.AppendLine("--------------------------");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }
    }
}
