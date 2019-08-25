using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Escribir un programa que imprima por pantalla una pirámide como la siguiente: 
 * * 
 * *** 
 * ***** 
 * ******* 
 * *********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
Para el ejemplo anterior la altura ingresada fue de 5. 
Nota: Utilizar estructuras repetitivas y selectivas.
*/
namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            System.Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i=0;i<number;i++)
                {
                    for (int j = 0; j <=i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
