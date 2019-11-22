using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
        public string GetDirectoryPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"; }
        }

        public void Guardar(string nombrearchivo, T objeto, Encoding encoding)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(nombrearchivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                }
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Error al guardar archivo XML", e);
            }
        }

        public void Guardar(string nombrearchivo, T objeto) {
            this.Guardar(nombrearchivo, objeto, System.Text.Encoding.UTF8);
        }


        public bool Leer(string nombrearchivo, out T objeto, Encoding encoding)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(nombrearchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    objeto = (T)ser.Deserialize(reader);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Error al leer archivo XML", e);
            }
        }
        public bool Leer(string nombrearchivo, out T objeto)
        {
            return this.Leer(nombrearchivo, out objeto, System.Text.Encoding.UTF8);
        }
    }
}
