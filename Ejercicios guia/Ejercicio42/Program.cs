using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase mc = new MiClase();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Catch externo {e}") ;
            }
            Console.ReadKey();
        }
    }
}
