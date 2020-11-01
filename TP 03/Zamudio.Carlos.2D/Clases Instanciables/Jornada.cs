using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace Clases_Instanciables
{
    public class Jornada
    {
        Profesor Instructor;
        EClase Clase;
        List<Alumno> Alumnos;

       
        public Jornada(Profesor profesor, EClase clase)
        {
            this.Profesor1 = profesor;
            this.Clase1 = clase;
            Alumnos = new List<Alumno>();
        }
        public Profesor Profesor1 
        { 
            get { return Instructor; }
            set { this.Instructor = value; }
        }
        public EClase Clase1 
        {
            get { return Clase; }
            set { this.Clase = value; }
        }
        public List<Alumno> Alumnos1 
        {
            get { return Alumnos; }
            set { this.Alumnos = value; }
        }


        public static Jornada operator +(Jornada jornada, Alumno estudiante)
        {
            bool v_return = true;

            foreach (Alumno alumaux in jornada.Alumnos1)
            {
                if (alumaux.DNI == estudiante.DNI)
                {
                    v_return = false;
                    break;
                }
            }
            if (v_return == true)
            {
                jornada.Alumnos1.Add(estudiante);
            }

            return jornada;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR:\n", this.Clase1);
            sb.Append(this.Profesor1.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno aux in this.Alumnos1)
            {
                sb.Append(aux.ToString());
            }
                
            return sb.ToString();
        }
    }
}
