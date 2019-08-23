using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.
*/
namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int userInput = 0;
            bool valid = true;

            for (int i = 0; i < 10; i++)
            {
                do {
                    userInput = getNumber("Ingrese un numero:");
                    valid = Validacion.Validate(userInput, -100, 100);
                    //System.Console.WriteLine("valid: {0}", valid);
                    if(valid == false)
                    {
                        System.Console.WriteLine("Numero invalido");
                    }
                    
                    
                } while (valid != true);

                System.Console.WriteLine("{0}",i);

                if (userInput < min)
                {
                    min = userInput;
                }
                if (userInput > max)
                {
                    max = userInput;
                }
            };

            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("min: {0}", min);
            System.Console.WriteLine("max: {0}", max);

            Console.ReadKey();

        }

        public static int getNumber(string args)
        {
            int userInput = 0;
            int response = 0;
            bool loop = true;
            do
            {
                System.Console.WriteLine("{0}", args);
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    response = userInput;
                    loop = false;
                }
                else
                {
                    System.Console.WriteLine("Error parse getNumber");
                }
            } while (loop == true);
            return response;
        }
    }
}
