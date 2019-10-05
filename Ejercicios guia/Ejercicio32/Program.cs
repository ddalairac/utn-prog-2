using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 32";

            Equipo team = new Equipo(3, "Osos");

            Jugador j1 = new Jugador(29747505, "Diego", 50, 10);
            bool r = team + j1;

            Console.WriteLine(team + new Jugador(132155315, "Marcelo"));
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(team + j1);
            Console.WriteLine(team + new Jugador(2442642, "Chacho"));
            Console.WriteLine(team + new Jugador(384516543, "Oliver"));
            Console.WriteLine(team.Mostrar());



            Console.ReadKey();
        }
    }
}
