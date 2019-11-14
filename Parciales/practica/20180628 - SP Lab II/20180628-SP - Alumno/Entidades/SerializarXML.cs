using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                /*using (*/
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, System.Text.Encoding.UTF8); /*) { */
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                //}
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }
        public T Leer(string rutaArchivo)
        {
            try
            {
                T datos;
                using (XmlTextReader reader = new XmlTextReader(rutaArchivo)) { 
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                }
                //reader.Close();
                return datos;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }

    }
}
