using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 34";
            VehiculoTerrestre v = new VehiculoTerrestre(1, 0, Colores.Azul);
            Camion c = new Camion(4, 2, Colores.Gris, 3000);
            Automovil a = new Automovil(4, 5, Colores.Negro, 5, 5);
            Moto m = new Moto(2, 0, Colores.Rojo, 250);

            Console.WriteLine($"VehiculoTerrestre: {v.Mostrar()}\n");

            Console.WriteLine($"{c.Mostrar()}");
            Console.WriteLine($"{a.Mostrar()}");
            Console.WriteLine($"{m.Mostrar()}");


            Console.ReadKey();
        }
    }
}
