using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Test prueba = new Test();
            Console.WriteLine(prueba);
            Console.WriteLine((int)prueba);
            Console.ReadKey();
        }
    }
}
