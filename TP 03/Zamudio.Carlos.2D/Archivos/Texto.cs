using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using Archivos;

namespace Archivos
{
    class Texto
    {
        public bool Guardar(string archivo, string datos)
        {
            bool respuesta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, false, Encoding.UTF8))
                {
                    sw.WriteLine(datos);
                    respuesta = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Error al guardar archivo de texto.");
            }
            return respuesta;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool respuesta = false;
            StringBuilder sbAux = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(archivo, Encoding.UTF8))
                {
                    while ((datos = sr.ReadLine()) != null)
                        sbAux.Append(datos);
                    datos = sbAux.ToString();
                    respuesta = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Error al leer archivo de texto.");
            }
            return respuesta;
        }
    }
}
