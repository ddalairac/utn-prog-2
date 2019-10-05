using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
27. Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas.
*/

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numbersList = new List<int>();
            Stack<int> numbersPila = new Stack<int>();
            Queue<int> numbersCola = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                int numRand = random.Next(-10, 10);
                numbersList.Add(numRand);
                numbersPila.Push(numRand);
                numbersCola.Enqueue(numRand);
            }

            foreach (int s in numbersList)
            {
                Console.Write(s);

                Console.Write(", ");
            }
            Console.Write("\n\n");


            numbersList.Sort();
            stackMethods.Print(numbersPila);
            stackMethods.Sort(numbersPila);
            stackMethods.Print(numbersPila);

            Console.ReadKey();
        }
    }
}
