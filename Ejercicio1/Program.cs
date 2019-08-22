using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ingresar 5 números por consola, guardándolos en una variable escalar. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInput = new int[5];
            int min = int.MaxValue;
            int max = int.MinValue;
            int total = 0;
            float average = 0;
            int loopNum = 5;

            System.Console.WriteLine("Ingresar {0} números", loopNum);
            for (int i = 0; i < loopNum; i++)
            {
                System.Console.WriteLine("num {0}:",i);
                if (int.TryParse(Console.ReadLine(), out userInput[i]))
                {
                    // System.Console.WriteLine("data {0}", userInput[i]);
                    total += userInput[i];
                    if (min > userInput[i])
                    {
                        min = userInput[i];
                    };
                    if (max < userInput[i])
                    {
                        max = userInput[i];
                    };
                }
                else
                {
                    System.Console.WriteLine("userInput no se puede parsear a numero");
                }
            }
            average = (float) total / loopNum;

            System.Console.WriteLine("\nmin {0} max {1} average {2:#.00}", min,max,average);

            System.Console.WriteLine("\nNumeros ingresados:");
            for (int i = 0; i < loopNum; i++)
            {
                System.Console.WriteLine("num {0}: {1}", i, userInput[i]);
            }

            Console.ReadKey();
        }
    }
}
