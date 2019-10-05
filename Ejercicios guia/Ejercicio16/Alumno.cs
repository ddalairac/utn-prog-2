using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. 
Colocarle nombre, apellido y legajo a cada uno de ellos.
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4, 
   caso contrario la inicializará con -1. Para darle un valor a la nota final utilice el método de instancia Next
   de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos.
   La nota final se mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
*/
namespace Ejercicio16
{
    public class Alumno
    {
        public Alumno(string nombre, string apellido, int legajo){
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        private string nombre;
        private string apellido;
        private int legajo;
        private int nota1;
        private int nota2;
        private int final;
        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random rand = new Random();
                this.final = rand.Next(4,11);
            } else
            {
                this.final = -1;
            }
        }
        public string Mostrar()
        {
            string cadena = "Nombre: ";
            cadena += this.nombre.ToString() + "\n";
            cadena += "Apellido: ";
            cadena += this.apellido.ToString() + "\n";
            cadena += "Legajo: ";
            cadena += this.legajo.ToString() + "\n";
            cadena += "Nota1: ";
            cadena += this.nota1.ToString() + "\n";
            cadena += "Nota2: ";
            cadena += this.nota2.ToString() + "\n";
            cadena += "Final: ";
            if (this.final == -1)
            {
                cadena += "Alumno desaprobado \n\n";
            } else { 
                cadena += this.final.ToString() + "\n\n";
            }
            return cadena;
        }
    }
}
