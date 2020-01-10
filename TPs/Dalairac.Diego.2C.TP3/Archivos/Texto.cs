using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Guarda y lee archivos txt
    /// </summary>
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda en la ruta especificada el string recibido, en formato .txt
        /// </summary>
        /// <param name="archivo"></param,>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))
                {
                    sw.WriteLine(datos.ToString());
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Llee de la ruta especificada todo el contenido y lo almacena en el parameto referencia string: datos
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            StreamReader sr = new StreamReader(archivo);
            try
            {
                datos = sr.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            finally
            {
                sr.Close();
            }

        }
    }
}
