using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(double). Convierte un número de entero a binario. 
 * double BinarioDecimal(string). Convierte un número binario a entero.
 * */

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";
            double userInput;
            string conversion1;
            double conversion2;
            Console.Write("Ingrese un numero: ");
            if(double.TryParse(Console.ReadLine(), out userInput))
            {
                conversion1 = Conversor.DecimalBinario(userInput);
                Console.WriteLine("DecimalBinario: {0}", conversion1);
                conversion2 = Conversor.BinarioDecimal(conversion1);
                Console.WriteLine("BinarioDecimal: {0}", conversion2);
            }

            Console.ReadKey();
        }
    }
}
