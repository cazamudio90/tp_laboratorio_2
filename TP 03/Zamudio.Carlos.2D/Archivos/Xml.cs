﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool respuesta = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, datos);
                    respuesta = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Error al guardar archivo Xml.");
            }
            return respuesta;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool respuesta = false;
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                    respuesta = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Error al leer archivo Xml.");
            }
            return respuesta;
        }
    }
}
