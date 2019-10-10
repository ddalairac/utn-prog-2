using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaSolar sistemaSolar = new SistemaSolar();
            List<Astro> planetas = new List<Astro>();
            planetas.Add(new Planeta(234, 24, "Marte", 1, Tipo.Rocoso));
            planetas.Add(new Planeta(365, 24, "Tierra", 1, Tipo.Rocoso));
            sistemaSolar.Planetas = planetas;
            //Console.WriteLine(sistemaSolar.MostrarInformacionAstros());
            Console.WriteLine(sistemaSolar.ListarPlsnetas());

            Console.ReadKey();
        }
    }
}
