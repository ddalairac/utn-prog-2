using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente.
*/
namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 26";
            Random random = new Random();
            int[] numbers = new int[20];
            int[] numbersNegative;
            int[] numbersPositive;
            string separator = "";
            int i;
            int lenNeg;
            int lenPos;

            // Definir funcion para imprimir array 
            void DisplayList(int max, string msj, ref int[] arr)
            {
                for (i = 0; i < max; i++)
                {
                    separator = (i == 0) ? msj : ((i != arr.Length) ? ", " : "");
                    Console.Write("{0}{1}", separator, arr[i]);
                }
                Console.Write("\n\n");
            }

            // Llenar lista con muneros random 
            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 10);
            }

            // mostrar Lista random
            DisplayList(numbers.Length, "Ini:  ", ref numbers);

            // ordenar listra random
            Array.Sort(numbers);
            DisplayList(numbers.Length, "Sort: ", ref numbers);

            // Buscar cantidad de + & -
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                    break;
            }
            lenNeg = i;
            lenPos = 20 - i;

            // instanciar arrays de + & -
            numbersNegative = new int[lenNeg];
            numbersPositive = new int[lenPos];

            // llenar arr negativos
            for (int j = 0; j < lenNeg; j++)
            {
                numbersNegative[j] = numbers[j];
            }


            // llenar arr positivos
            i = lenNeg;
            for (int j = 0; j < lenPos; j++)
            {
                numbersPositive[j] = numbers[i];
                i++;
            }

            // ordenar nuevos arrays + & -
            Array.Reverse(numbersPositive);
            //Array.Reverse(numbersNegative);
            DisplayList(lenNeg, "neg:  ", ref numbersNegative);
            DisplayList(lenPos, "pos:  ", ref numbersPositive);



            // LLENAR numbers nuevo orden
            i = 0;
            for (int j = 0; j < lenNeg; j++, i++)
            {
                numbers[i] = numbersNegative[j];
            }
            for (int j = 0; j < lenPos && i < numbers.Length; j++, i++)
            {
                numbers[i] = numbersPositive[j];
            }
            DisplayList(numbers.Length, "res:  ", ref numbers);


            Console.ReadKey();
        }

    }
}
