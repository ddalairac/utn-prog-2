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
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            return numero * numero;
        }
        public static double CalcularTriangulo(double numero1, double numero2)
        {
            return numero1 * numero2 / 2;
        }
        public static double CalcularCirculo(double numero)
        {
            return Math.PI * (Math.Pow(numero,2) / 2);
        }
    }
}
