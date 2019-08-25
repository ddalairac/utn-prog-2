using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que sume números enteros hasta que el usuario lo determine, 
 * por medio de un mensaje "¿Continuar? (S/N)". 
 * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, 
 * se validará el ingreso de opciones. 
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            bool continuar = true;
            char response = 's';
            int number = 0;
            int total = 0;
            do
            {
                System.Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    total += number;
                }
                else
                {
                    System.Console.WriteLine("Error, numero invalido \n");
                }
                System.Console.WriteLine("¿Continuar? (S/N)");
                if (char.TryParse(Console.ReadLine(), out response))
                {
                    continuar = ValidarRespuesta.ValidaS_N(response);
                } else
                {
                    System.Console.WriteLine("Error, debe ingresar un caracter \n");
                }
            } while (continuar == true);

            System.Console.WriteLine(" \n total: {0}",total);
            Console.ReadKey();
        }
    }
}
