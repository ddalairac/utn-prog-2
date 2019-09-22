using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // print array  
            void DisplayList(int max, string msj, ref int[] arr)
            {
                for (i = 0; i < max; i++)
                {
                    separator = (i == 0) ? msj : ((i != arr.Length) ? ", " : "");
                    Console.Write("{0}{1}", separator, arr[i]);
                }
                Console.Write("\n\n");
            }
            // put random numbers in array  
            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 10);
            }


            DisplayList(numbers.Length,"Ini:  ",ref numbers);
            Array.Sort(numbers);
            DisplayList(numbers.Length, "Sort: ",ref numbers);

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                    break;
            }
            lenNeg = i ;
            lenPos = 20 - i;

            numbersNegative = new int[lenNeg];
            numbersPositive = new int[lenPos];

            for (int j = 0; j < lenNeg; j++)
            {
                numbersNegative[j] = numbers[j];
            }
            DisplayList(lenNeg, "neg:  ",ref numbersNegative);

            Array.Reverse(numbersNegative);
            DisplayList(lenNeg, "neg:  ", ref numbersNegative);

            i = lenNeg;
            for (int j = 0; j < lenPos; j++)
            {
                numbersPositive[j] = numbers[i];
                i++;
            }

            DisplayList(lenPos, "pos:  ",ref numbersPositive);


            
            //Array.Sort(numbers,
            //    (x, y) =>
            //    {
            //        Console.Write(x);
            //        Console.WriteLine(y);
            //        return (x > y) ? x : -x;
            //    });
            




            Console.ReadKey();
        }

    }
}
