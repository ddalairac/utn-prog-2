using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas. 
 */
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int i = 2;
            int suma = 0;
            int perfectos = 0;
            System.Console.WriteLine("4 primeros numeros perfectos");
            while (perfectos < 4)
            {
                suma = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        suma += j;
                    }
                }
                if (suma == i)
                {
                    perfectos++;
                    System.Console.WriteLine("numero perfecto {0}", i);
                }
                i++;

            }
            Console.ReadKey();
        }
    }
}
