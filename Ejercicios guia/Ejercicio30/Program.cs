using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 30";

            AutoF1 a1 = new AutoF1(1, "Ford");
            AutoF1 a2 = new AutoF1(1, "Fiat");
            Console.WriteLine(a1.MostrarDatos());
            Competencia comp = new Competencia(10, 2);
            bool _ = comp + a1;
            Console.WriteLine(comp + a1);
            Console.WriteLine(comp + a2);
            Console.WriteLine(comp + new AutoF1(2, "Mercedes"));
            Console.WriteLine(comp.MostrarDatos());

            Console.ReadKey();
        }
    }
}
