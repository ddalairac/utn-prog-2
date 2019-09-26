﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº39";
            Sobreescrito sobrecarga = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.Write("Comparación Sobrecargas con Sobreescrito: ");
            Console.WriteLine(sobrecarga.Equals(new SobreSobreescrito()));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
