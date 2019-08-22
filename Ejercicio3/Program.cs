using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            System.Console.WriteLine("Ingresar un número");
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                System.Console.WriteLine("Numeros primos");
                for (int i=2; i <= userInput; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ( i % j == 0)
                        {
                            break;
                        }
                        if (j == i - 1)
                        {
                            System.Console.WriteLine("{0}", i);
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
