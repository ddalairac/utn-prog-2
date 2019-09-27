using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 40: Centralita";

            #region Init Data
            Centralita central = new Centralita("Saltamonte");
            Local l1 = new Local("Banfield", 30, "Lomas", (float)2.65);
            Local l1b = l1;
            Provincial l2 = new Provincial("Bahia Blanca", Provincial.Franja.Franja_1, 15, "Mar del Plata");
            //Local l3 = new Local(new Llamada(40, "Temperley", "Lanus"), (float)2.65);
            Local l3 = new Local("Temperley", 40, "Lanus", (float)2.65);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Agregar llamadas a la central
            //bool na = central + l1;
            //na = central + l2;
            //central.Llamadas.Add(l3);
            //na = central + l4;
            #endregion
            

            #region Test

            Console.WriteLine($"l1 == l1b {l1 == l1b}");
            Console.WriteLine($"l1 == l2 {l1 == l2}");
            Console.WriteLine($"central == l1 {central == l1}");

            Console.WriteLine($"+ l1 {(central = central + l1).Llamadas.Count}");
            Console.WriteLine($"+ l1b {(central = central + l1b).Llamadas.Count}");
            Console.WriteLine($"+ l2 {(central = central + l2).Llamadas.Count}");
            Console.WriteLine($"+ l3 {(central = central + l3).Llamadas.Count}");
            Console.WriteLine($"+ l4 {(central = central + l4).Llamadas.Count}");
            Console.WriteLine(central.Mostrar());
            // Ordenar llamadas en la central
            central.OrdenarLlamadas();
            Console.WriteLine(central.Mostrar());
            Console.ReadKey();
            #endregion

        }
    }
}
