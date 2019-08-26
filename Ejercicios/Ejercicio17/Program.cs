using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Crear la clase Bolígrafo a partir del siguiente diagrama:
a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante en el Boligrafo llamada 
   cantidadTintaMaxima donde se guardará dicho valor.
b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor del mismo).
c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
    i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo (gastar tinta)
    ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a 0 y menor o igual a cantidadTintaMaxima.
d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100 y otro de tinta roja 
   (ConsoleColor.Red) y 50 de tinta.
f. El método Pintar(int, out string) restará la tinta gastada (reutilizar código SetTinta), sin poder quedar el nivel en negativo, 
   avisando si pudo pintar (nivel de tinta mayor a 0). También informará mediante el out string tantos "*" como haya podido "gastar" 
   del nivel de tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
g. Utilizar todos los métodos en el Main.
h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/
namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";
            short tinta;
            char continuar;
            short menu;
            Boligrafo boligrafoBlue = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo boligrafoRed = new Boligrafo(ConsoleColor.Red, 50);
            do {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(
                    " Tinta Azul: {0} \n" +
                    " Tinta Roja: {1} \n" +
                    "1 .pintar azul \n" +
                    "2 .pintar rojo \n" +
                    "3 .cargar tinta azul \n" +
                    "4 .cargar tinta roja \n\n"+
                    "Seleccione un item: ", 
                    boligrafoBlue.GetTinta(), boligrafoRed.GetTinta()
                );
                if (short.TryParse(Console.ReadLine(), out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            Console.Write("Ingrese cantidad a pintar azul: ");
                            if (short.TryParse(Console.ReadLine(), out tinta))
                            {
                                Console.ForegroundColor = boligrafoBlue.GetColor();
                                Console.WriteLine("{0}", boligrafoBlue.Pintar(tinta));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("tinta azul: {0} ", boligrafoBlue.GetTinta());
                            }
                            break;
                        case 2:
                            Console.Write("Ingrese cantidad a pintar rojo: ");
                            if (short.TryParse(Console.ReadLine(), out tinta))
                            {
                                Console.ForegroundColor = boligrafoRed.GetColor();
                                Console.WriteLine("{0}", boligrafoRed.Pintar(tinta));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("tinta roja: {0} ", boligrafoRed.GetTinta());
                            }
                            break;
                        case 3:
                            Console.Write("Ingrese cantidad azul a cargar: ");
                            if (short.TryParse(Console.ReadLine(), out tinta))
                            {
                                boligrafoBlue.SetTinta(tinta);
                                Console.WriteLine("tinta azul: {0} ", boligrafoBlue.GetTinta());
                            }
                            break;
                        case 4:
                            Console.Write("Ingrese cantidad roja a cargar: ");
                            if (short.TryParse(Console.ReadLine(), out tinta))
                            {
                                boligrafoRed.SetTinta(tinta);
                                Console.WriteLine("tinta roja: {0} ", boligrafoRed.GetTinta());
                            }
                            break;;
                    }
                }
                Console.WriteLine("Continuar (S/N)");
                if (char.TryParse(Console.ReadLine(), out continuar)) { }
            } while (continuar == 's');
        }
    }
}
