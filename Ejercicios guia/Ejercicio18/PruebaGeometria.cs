using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
/*
a.La clase Punto ha de tener dos atributos privados con acceso de sólo lectura(sólo con getters), que serán las coordenadas del punto.
  También un constructor que reciba los parámetros x e y.
b.La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
c.La base de todos los rectángulos de esta clase será siempre horizontal.
  Por lo tanto, debe tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 
  (utilizar el método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para obtener la distancia entre puntos).
d.Realizar los métodos getters para los atributos privados área y perímetro.
e.Los atributos área(base * altura) y perímetro((base + altura)*2) se deberán calcular sólo una vez, al llamar por primera vez a su correspondiente método getter.
  Luego se deberá retornar siempre el mismo valor.
  En el espacio de nombres PruebaGeometria es donde se escribirá una clase con el método Main.
f.Probar las funcionalidades de las clases Punto y Rectangulo.
  i.Generar un nuevo Rectangulo.
  ii.Imprimir por pantalla los valores de área y perímetro.
g.Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como parámetro.
*/
namespace PruebaGeometria
{
    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;
        public int lado;
        public int altura;
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = new Punto(vertice1.GetX(), vertice1.GetY());
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = new Punto(vertice3.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.lado = Math.Abs(this.vertice3.GetX() - this.vertice1.GetX());
            this.altura = Math.Abs(this.vertice4.GetY() - this.vertice2.GetY());
            this.Area();
            this.Perimetro();
        }
        void Area()
        {
            this.area = this.lado * this.altura;
        }
        void Perimetro()
        {
            this.perimetro = (this.lado + this.altura) * 2;
        }
        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }
        public string GetParametros()
        {
            string response = "";
            response += " vertice1 X: "+ vertice1.GetX().ToString() + " vertice1 Y: " + vertice1.GetY().ToString() + "\n";
            response += " vertice3 X: " + vertice3.GetX().ToString() + " vertice3 Y: " + vertice3.GetY().ToString() + "\n";
            response += " = (lado: "+ lado + " & altura: " + altura +")";
            return response;
        }
    }
}
