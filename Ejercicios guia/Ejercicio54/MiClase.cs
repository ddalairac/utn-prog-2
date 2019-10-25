using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear el código necesario para:
a. Crear una clase llamada MiClase y dentro colocar un método estático, otro de instancia y 2
constructores de instancia.

e. Luego crear un método de instancia que capture la excepción anterior. Este método
generará una excepción propia llamada MiException y la lanzará.

f. MiException será capturada en el Main, mostrando el mensaje de error que esta almacena
por pantalla y los mensajes de todas las excepciones almacenadas en sus innerException.
*/
namespace Ejercicio52
{
    public class MiClase
    {
        // b. Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        public static bool McStatic(int num)
        {
            Console.WriteLine("Metodo estatico que lanza excepcion \n");
            throw new DivideByZeroException();
        }

        /* c. Capturar la excepción del punto a en un constructor de instancia y relanzarla 
              hacia otro constructor de instancia. */
        public MiClase(int num)
        {
            try
            {
                MiClase.McStatic(1);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Catch DivideByZeroException \n\n{e}\n\n");
                throw e;
            }
            //catch (Exception e) { Console.WriteLine($"Catch Exception  GENERAL \n\n{e}\n\n"); }

            Console.WriteLine("Despues del Try catch \n");
        }

        /* d. En este segundo constructor, crear una excepción propia llamada UnaException (utilizar
              innerException para almacenar la excepción original) y volver a lanzarla.*/
        public MiClase() //: this(0)
        {
            try
            {
                new MiClase(9);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Catch Segundo constructor UnaException \n\n{e}\n\n");
                throw new UnaException("un mensaje", e);
            }
        }
        public bool McInstance(int num)
        {
            return false;
        }
    }
}
