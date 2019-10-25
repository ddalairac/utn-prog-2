using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string data)
        {
            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(data);
            sw.Close();
        }
        public static void Leer(string ruta)
        {
            string str;
            StreamReader sw;
            try
            {
                sw = new StreamReader(ruta);
            }
            catch (Exception)
            {
                throw new FileNotFoundException();
            }
            str = sw.ReadToEnd();
            sw.Close();
        }
    }
}
