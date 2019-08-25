using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). 
 * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
 * (pulsando el caracter +, -, * ó /). 
 * El usuario decidirá cuándo finalizar el programa. 
 * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
    a. Calcular (público): Recibirá tres parámetros, 
        el primer número, 
        el segundo número 
        y la operación matemática. 
        El método devolverá el resultado de la operación.
    b. Validar (privado): Recibirá como parámetro el segundo número. 
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá TRUE si el número es distinto de CERO.*/
namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInputNum1;
            double userInputNum2;
            char userInputOp;
            double resultado;
            char continuar = 's';
            while(continuar == 's') { 
                Console.Write("\nIngrese un numero: ");
                if (double.TryParse(Console.ReadLine(), out userInputNum1)) { } else { Console.WriteLine("Error, numero invalido"); }
                Console.Write("Ingrese otro numero: ");
                if (double.TryParse(Console.ReadLine(), out userInputNum2)) { } else { Console.WriteLine("Error, numero invalido"); }
                Console.Write("Ingrese un operacion (+ - * /): ");
                if (char.TryParse(Console.ReadLine(), out userInputOp)) { } else { Console.WriteLine("Error, operacion invalida"); }

                resultado = Calculadora.Calcular(userInputNum1, userInputNum2, userInputOp);
                Console.WriteLine("\nResultado: {0}", resultado);
                Console.WriteLine("Continuar (S/N)");
                if (char.TryParse(Console.ReadLine(), out continuar)) { }
            }
        }
    }
}
