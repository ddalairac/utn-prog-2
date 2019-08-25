using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Partiendo de la base del ejercicio anterior, se pide realizar un programa 
 que imprima por pantalla una pirámide como la siguiente:
         * 
        *** 
       ***** 
      ******* 
     *********
Nota: Utilizar estructuras repetitivas y selectivas.
*/
namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int espacio = 0;
            System.Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                // Duplica el numero porque voy a saltear la mitad
                number = number * 2;
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0) 
                    {
                        espacio = ((number / 2) - i/2);
                    
                        for (int j = 0; j <= espacio; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= i; j++)
                        {
                        
                            Console.Write("*");
                        }
                    Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
