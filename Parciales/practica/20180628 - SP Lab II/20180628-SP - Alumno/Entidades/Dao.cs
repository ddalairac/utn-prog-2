using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                /*using (*/
                //XmlTextWriter writer = new XmlTextWriter(rutaArchivo, System.Text.Encoding.UTF8); /*) { */
                //XmlSerializer serializer = new XmlSerializer(typeof(T));
                //serializer.Serialize(writer, objeto);
                ////}
                //writer.Close();
                return true;
            }
            //catch (Exception e)
            //{
            //    throw new ErrorArchivoException(e);
            //}
        }
        public T Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
