using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) 
 * que realicen el cálculo del área que corresponda:
    a. double CalcularCuadrado(double)
    b. double CalcularTriangulo(double, double)
    c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;
            Console.Write("Ingrese un numero: ");
            if (double.TryParse(Console.ReadLine(),out userInput)) {
                areaCuadrado = CalculoDeArea.CalcularCuadrado(userInput);
                areaTriangulo = CalculoDeArea.CalcularTriangulo(userInput, userInput);
                areaCirculo = CalculoDeArea.CalcularCirculo(userInput);
                Console.WriteLine("areaCuadrado: {0:#.00}", areaCuadrado);
                Console.WriteLine("areaTriangulo: {0:#.00}", areaTriangulo);
                Console.WriteLine("areaCirculo: {0:#.00}", areaCirculo);
            }
            Console.ReadKey();
        }
    }
}
