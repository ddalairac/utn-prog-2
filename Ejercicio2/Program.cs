using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool loop = true;
            bool flag = false;
            long square = 0;
            long cube = 0;
            
            do
            {
                if (flag == true)
                {
                    System.Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                flag = true;
                System.Console.WriteLine("Ingresar un namero mayor a 0");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput > 0)
                    {
                        loop = false;
                        square = (long)Math.Pow(userInput, 2);
                        cube = (long)Math.Pow(userInput, 3);
                        System.Console.WriteLine("Numero: {0} Cuadrado: {1} cubo: {2}", userInput, square, cube);
                    }
                }
            } while (loop == true);


            Console.ReadKey();
        }
    }
}
