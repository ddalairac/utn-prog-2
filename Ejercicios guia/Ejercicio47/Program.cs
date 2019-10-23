using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> nba = new Torneo<EquipoBasquet>("NBA");
            Torneo<EquipoFutbol> afa = new Torneo<EquipoFutbol>("Libertadores");

            EquipoBasquet b1 = new EquipoBasquet("Bulls", DateTime.Now.AddDays(5));
            EquipoBasquet b2 = new EquipoBasquet("Spurs", DateTime.Now.AddDays(-15));
            EquipoBasquet b3 = new EquipoBasquet("Cavaliers", DateTime.Now.AddDays(50));
            
            EquipoFutbol f1 = new EquipoFutbol("Banfield", DateTime.Now.AddDays(-12));
            EquipoFutbol f2 = new EquipoFutbol("Boca", DateTime.Now.AddDays(120));
            EquipoFutbol f3 = new EquipoFutbol("River", DateTime.Now.AddDays(43));

            nba += b1;
            nba += b2;
            nba += b3;

            afa += f1;
            afa += f2;
            afa += f3;

            Console.WriteLine(nba.Mostrar());
            Console.WriteLine(afa.Mostrar());


            Console.WriteLine("-------- Jugar Partidos -------- \n");

            Console.WriteLine(nba.JugarPartido);
            Console.WriteLine(nba.JugarPartido);
            Console.WriteLine(nba.JugarPartido);
            Console.WriteLine(afa.JugarPartido);
            Console.WriteLine(afa.JugarPartido);
            Console.WriteLine(afa.JugarPartido);
            Console.WriteLine(afa.JugarPartido);

            Console.ReadKey();
        }
    }
}
