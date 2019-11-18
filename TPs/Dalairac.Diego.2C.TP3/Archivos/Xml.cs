using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda en la ruta especificada el objeto recibido, en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(archivo, System.Text.Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }
        /// <summary>
        /// Llee de la ruta especificada el contenido y lo almacena en el parameto referencia (datos) del tipo especificado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                datos = (T)ser.Deserialize(reader);
                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

    }
}
