﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;
/*
20.Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.
a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, 
   teniendo presente que 1 Euro equivale a 1,16 dólares y 1 dólar equivale a 38,33 pesos.
b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
d. Colocar dentro del Main el código necesario para probar todos los métodos.
e. Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.
f. Los comparadores == compararan cantidades.
g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido. Por ejemplo, si quiero sumar Dólar y Euro, 
   deberé convertir el Euro a Dólar y luego sumarlos.
h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
*/
namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";
            Dolar mon1 = new Dolar(10);
            Euro mon2 = new Euro(10);
            Peso mon3 = new Peso(10);

            Console.WriteLine("mon1 (Dolar) = {0}",mon1.GetCantiad());
            Console.WriteLine("mon2 (Euro) = {0}", mon2.GetCantiad());
            Console.WriteLine("mon3 (Peso) = {0}\n", mon3.GetCantiad());

            Console.WriteLine("mon1 (GetCotizacion) = {0}", mon1.GetCotizacion());
            Console.WriteLine("mon2 (GetCotizacion) = {0}", mon2.GetCotizacion());
            Console.WriteLine("mon3 (GetCotizacion) = {0}\n", mon3.GetCotizacion());

            Console.WriteLine("mon1 + mon2 = {0:#,###.00}", mon1 + mon2);
            Console.WriteLine("mon1 - mon2 = {0:#,###.00}", mon1 - mon2);
            Console.WriteLine("mon1 * mon2 = {0:#,###.00}", mon1 * mon2);
            Console.WriteLine("mon1 / mon2 = {0:#,###.00}", mon1 / mon2);
            Console.WriteLine("mon1 == mon2 = {0}", mon1 == mon2);
            Console.WriteLine("mon1 != mon2 = {0}", mon1 != mon2);

            //Console.WriteLine(mon1 == mon2);
            //Console.WriteLine(mon1 != mon2);

            Console.ReadKey();
        }
    }
}
