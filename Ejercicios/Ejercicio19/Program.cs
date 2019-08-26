using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";
            Console.WriteLine("Sobrecarga (constructor, metodo y operadores)\n");
            Sumador sum1 = new Sumador();
            Sumador sum2 = new Sumador(2);
            Console.WriteLine(sum1.Sumar(2,2));
            Console.WriteLine(sum1.Sumar("2", "2"));
            Console.WriteLine(sum1 + sum2);
            Console.WriteLine(sum1 | sum2);
            Console.ReadKey();
        }
    }
}
