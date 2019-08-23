using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.


        SIN TERMINAR
*/
namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = getNumber("dia");
            int month = getNumber("mes");
            int year = getNumber("año");
            string actualDate = DateTime.Now.ToString("MM/dd/yyyy");

            biciesto();
            Console.ReadKey();
        }
        static int getNumber(string args)
        {
            int userInput = 0;
            bool loop = true;
            do
            {
                System.Console.WriteLine("{0}", args);
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    loop = false;
                }
                else
                {
                    System.Console.WriteLine("Error");
                }
            } while (loop == true);
            return userInput;
        }

        static void biciesto()
        {
            int userInputInit = 0;
            int userInputEnd = 0;
            bool loop = true;
            do
            {
                System.Console.WriteLine("Ingrese un año de inicio");
                if (int.TryParse(Console.ReadLine(), out userInputInit))
                {
                    loop = false;
                }
                else
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
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    System.Console.Write("{0} ", i);
                }
            }

        }
    }
}
