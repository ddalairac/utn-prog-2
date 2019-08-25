using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;/*
Crear la clase Bolígrafo a partir del siguiente diagrama:
a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante en el Boligrafo llamada 
   cantidadTintaMaxima donde se guardará dicho valor.
b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor del mismo).
c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
    i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo (gastar tinta)
    ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a 0 y menor o igual a cantidadTintaMaxima.
d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100 y otro de tinta roja 
   (ConsoleColor.Red) y 50 de tinta.
f. El método Pintar(int, out string) restará la tinta gastada (reutilizar código SetTinta), sin poder quedar el nivel en negativo, 
   avisando si pudo pintar (nivel de tinta mayor a 0). También informará mediante el out string tantos "*" como haya podido "gastar" 
   del nivel de tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
g. Utilizar todos los métodos en el Main.
h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/
namespace Ejercicio17
{
    public class Boligrafo
    {
        public int cantidadTintaMax;
        public int tinta;
        public ConsoleColor color;
        public  Boligrafo(ConsoleColor color, int tinta) {
            this.color = color;
            SetTinta(tinta);
        }
        public ConsoleColor GetColor() {
            return this.color;
        }
        public int GetTinta(){
            return this.tinta;
        }
        public int SetTinta(int tinta) {
            int gastada = 0;
            // gasta tinta
            if (tinta < 0){ 
                if (this.tinta + tinta <= 0){
                    gastada = -this.tinta;
                    this.tinta = 0;
                } else {
                    gastada = tinta;
                    this.tinta += tinta;
                }
            // Carga de tinta
            } else { 
                if (this.tinta + tinta >= 100){
                    this.tinta = 100;
                } else {
                    this.tinta += tinta;
                }
            }
            return gastada;
        }
        public string Pintar(int tinta) {
            string pintar = "";
            int cant;
            cant = SetTinta(- tinta);
            pintar += "Gasto:" + cant.ToString() + " \n";

            for (int i = 0; i < (cant *-1); i++){
                pintar += "*";
            }
            return pintar;
        }
        public void Recargar() {
            SetTinta(100);
        }

    }
}
