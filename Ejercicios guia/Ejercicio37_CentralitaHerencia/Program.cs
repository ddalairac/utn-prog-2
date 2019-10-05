using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 37: Centralita";
            Centralita central = new Centralita("Saltamonte");
            Local l1 = new Local("Banfield", 30, "Lomas", (float)2.65);
            Provincial l2 = new Provincial("Bahia Blanca", Provincial.Franja.Franja_1, 15, "Mar del Plata");
            Local l3 = new Local(new Llamada(40, "Temperley",  "Lanus"), (float)2.65);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Agregar llamadas a la central
            central.Llamadas.Add(l1);
            central.Llamadas.Add(l2);
            central.Llamadas.Add(l3);
            central.Llamadas.Add(l4);
            Console.WriteLine(central.Mostrar());

            // Ordenar llamadas en la central
            central.OrdenarLlamadas();
            Console.WriteLine(central.Mostrar());
            Console.ReadKey();
        }
    }
}
