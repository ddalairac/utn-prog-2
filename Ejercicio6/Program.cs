using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)
*/
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int userInputInit = 0;
            int userInputEnd = 0;
            bool loop = true;
            do { 
                System.Console.WriteLine("Ingrese un año de inicio");
                if (int.TryParse(Console.ReadLine(), out userInputInit) )
                {
                    loop = false;
                } else
                {
                    System.Console.WriteLine("Error");
                }
            } while (loop == true);


            loop = true;
            do
            {
                System.Console.WriteLine("Ingrese un año de fin");
                if (int.TryParse(Console.ReadLine(), out userInputEnd))
                {
                    if (userInputInit < userInputEnd)
                    {
                        loop = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Error, ingrese un año mayor al de inicio");
                    }
                }
                else
                {
                    System.Console.WriteLine("Error");
                }
            } while (loop == true);


            System.Console.WriteLine("incio {0} fin {1}", userInputInit, userInputEnd);
            
            System.Console.WriteLine("\nAños biciestos:");
            for (int i = userInputInit; i < userInputEnd; i++)
            {
                if((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    System.Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();

        }
    }
}
