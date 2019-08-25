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
            DateTime birthDate;
            Console.WriteLine("Calcular dias vividos!;");
            Console.Write("Ingrese fecha de nacimiento (DD/MM/YYY): ");
            if (DateTime.TryParse(Console.ReadLine(), out birthDate)){
                DateTime today = DateTime.Now;
                Console.WriteLine("Dias vividos {0}", (today - birthDate).Days);
            }
            else {
                Console.WriteLine("Incorrect date format!");
            }
            Console.ReadKey();
        }
        /*
        static int GetNumber(string args)
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
        static int AddDiaBiciesto(int year)
        {
            int response = 0;
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                response = 1;
            }
            return response;
        }
        */
    }
}
