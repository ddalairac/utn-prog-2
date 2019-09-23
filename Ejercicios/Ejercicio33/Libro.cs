using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {
        private List<string> paginas;
        public Libro()
        {
            paginas = new List<string>();
        }
        public string this[int index]
        {
            get {
                string rta = "";
                if (index >= 0 && index < paginas.Count)
                {
                    rta = paginas[index];
                }
                return rta;
            }
            set {
                if (index >= 0 && index < paginas.Count)
                {
                    paginas[index] = value;
                }
                else if (index > 0)
                {
                    paginas.Add(value);
                }
            }
        }
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder("LISTADO DE LIBROS:\n");
            foreach(string p in this.paginas)
            {
                str.AppendLine(p);
            }
            return str.ToString();
        }
    }
}
