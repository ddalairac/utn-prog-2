using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 31";


            Negocio n = new Negocio("Un Negocio");
            Cliente c1 = new Cliente(1, "Juan");
            Cliente c2 = new Cliente(2, "Carlos");
            Cliente c3 = new Cliente(3);

            Console.WriteLine($"Agregarse C1 {n + c1}");
            Console.WriteLine($"Agregarse C1 {n + c1}");
            Console.WriteLine($"Agregarse C2 {n + c2}");
            Console.WriteLine($"Agregarse C3 {n + c3}");


            Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");

            if (~n)
            {
                Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
            }

            if (~n)
            {
                Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
            }

            if (~n)
            {
                Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
            }

            if (~n)
            {
                Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
            }
            else
            {
                Console.WriteLine($"No hay clientes que atender");
            }


            Console.ReadKey();
        }
    }
}
