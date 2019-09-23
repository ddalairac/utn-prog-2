using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, 
sino retornará un string vacio “”. En el set, la asignará si esta ya existe.Si el índice es superior al máximo existente, 
agregará una nueva página.
Generar el código en el Main para probar la clase.
*/
namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 33";
            Libro libro = new Libro();

            libro[0] = "Intro";
            libro[1] = "Prologo";
            libro[2] = "Indice";
            libro[3] = "Capitulo 1";
            libro[4] = "Capitulo 1.2";
            libro[5] = "Capitulo 1.3";

            Console.WriteLine(libro.Mostrar());

            Console.ReadKey();

        }
    }
}
