using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
using PruebaGeometria;/*
a.La clase Punto ha de tener dos atributos privados con acceso de sólo lectura(sólo con getters), que serán las coordenadas del punto.
  También un constructor que reciba los parámetros x e y.
b.La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
c.La base de todos los rectángulos de esta clase será siempre horizontal.
  Por lo tanto, debe tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para obtener la distancia entre puntos).
d.Realizar los métodos getters para los atributos privados área y perímetro.
e.Los atributos área(base * altura) y perímetro((base + altura)*2) se deberán calcular sólo una vez, al llamar por primera vez a su correspondiente método getter.
  Luego se deberá retornar siempre el mismo valor.
  En el espacio de nombres PruebaGeometria es donde se escribirá una clase con el método Main.
f.Probar las funcionalidades de las clases Punto y Rectangulo.
  i.Generar un nuevo Rectangulo.
  ii.Imprimir por pantalla los valores de área y perímetro.
g.Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como parámetro.
*/
namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";
            Punto p1 = new Punto(5, 0);
            Punto p2 = new Punto(10, 20);
            Rectangulo rec = new Rectangulo(p1,p2);
            Console.WriteLine("parametros: \n{0}", rec.GetParametros());
            Console.WriteLine("Area: {0:#,###.00}", rec.GetArea());
            Console.WriteLine("Perimetro: {0:#,###.00}", rec.GetPerimetro());
            Console.ReadKey();
        }
    }
}
