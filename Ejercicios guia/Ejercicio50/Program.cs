using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<bool, string> gt = new GuardarTexto<bool, string>();
            Serializar<bool, string> s = new Serializar<bool, string>();

            Console.WriteLine(gt.Guardar(false));
            Console.WriteLine(gt.Leer());
            Console.WriteLine(s.Guardar(false));
            Console.WriteLine(s.Leer());
            Console.ReadKey();

        }
    }
}
