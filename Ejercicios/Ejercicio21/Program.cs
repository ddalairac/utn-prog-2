﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
21. Crear tres clases: Fahrenheit, Celsius y Kelvin. Realizar un ejercicio similar al anterior, teniendo encuenta que:
F = C * (9/5) + 32
C = (F-32) * 5/9
F = K * 9/5 – 459.67
K = (F + 459.67) * 5/9
*/

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int argNumber;
            string argMessage, argDefault;

            Test test = new Test();

            test.Method(out argNumber, out argMessage, out argDefault);
            Console.WriteLine(argNumber);
            Console.WriteLine(argMessage);
            Console.WriteLine(argDefault == null);

            int result;
            Console.WriteLine("\n");
            Console.WriteLine(int.TryParse("100", out result));
            Console.WriteLine(result);


            StringBuilder sb = new StringBuilder("ABC");
            sb.AppendLine("GHI");
            sb.Append(123456);
            sb.Append(result);
            sb.AppendLine("DEF");
            Console.WriteLine(sb.ToString());

            sb.Remove(1, 11);
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
    public class Test
    {
        public void Method(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }

    }
}
