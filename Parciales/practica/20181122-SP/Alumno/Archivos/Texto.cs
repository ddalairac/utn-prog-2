using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo), true))
                {
                    sw.WriteLine(datos.ToString());
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar archivo de texto",e);
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(desktop, archivo)))
                {
                    datos = sr.ReadToEnd();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer archivo de texto", e);
            }
        }
    }
}

