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
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            string nombre;
            string apellido;
            int legajo;
            Random rand = new Random();

            List<Alumno> alumnos = new List<Alumno>();
            //alumnos.Add(new Alumno("Diego", "Dalairac", 123));
            //alumnos.Add(new Alumno("Jorge", "Gonsalez", 456));
            //alumnos.Add(new Alumno("Marcos", "Hernandes", 789));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese datos del alumno (nombre, apellido y legajo):");
                nombre = Console.ReadLine();
                apellido = Console.ReadLine();
                if (int.TryParse(Console.ReadLine(), out legajo))
                {
                    alumnos.Add(new Alumno(nombre, apellido, legajo));
                }
                else
                {
                    Console.WriteLine("Error al introducir datos");
                }
            }

            foreach (Alumno alumno in alumnos)
            {
                alumno.Estudiar((byte)rand.Next(1, 11), (byte)rand.Next(1, 11));
                alumno.CalcularFinal();
                Console.WriteLine("{0}", alumno.Mostrar());

            }
            Console.ReadKey();
        }
    }
}
