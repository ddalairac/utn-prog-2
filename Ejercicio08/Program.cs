using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Por teclado se ingresa 
 * el valor hora, 
 * el nombre, 
 * la antigüedad (en años) 
 * y la cantidad de horas trabajadas en el mes 
 * de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que 
el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 

    Mostrar el recibo correspondiente con el 
        nombre, 
        la antigüedad, 
        el valor hora, 
        el total a cobrar en bruto, 
        el total de descuentos 
        y el valor neto a cobrar de todos los empleados ingresados. 
    
    Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            char continuar = 's';

            string nombre;
            int valorHora;
            int antiguedad;
            int horasTrabajadasMes;

            List<Empleado> empleados = new List<Empleado>();

            do
            {
                Console.WriteLine("Ingrese datos del empleado (Nombre / valor hora / antiguedad / horas trabajadas):");
                nombre = Console.ReadLine();
                if (int.TryParse(Console.ReadLine(), out valorHora) &&
                    int.TryParse(Console.ReadLine(), out antiguedad) &&
                    int.TryParse(Console.ReadLine(), out horasTrabajadasMes))
                {
                    empleados.Add(new Empleado(nombre, valorHora, antiguedad, horasTrabajadasMes));
                } else {
                    Console.WriteLine("Error al introducir datos");
                }

                System.Console.WriteLine("¿Continuar? (S/N)");
                if (char.TryParse(Console.ReadLine(), out continuar)) {
                } else {
                    System.Console.WriteLine("Error, debe ingresar un caracter \n");
                }
            } while (continuar == 's');

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine("Recibo Empleado nombre: {0}", empleado.nombre);
                Console.WriteLine(" {0,-20} {1,10}", "valorHora", empleado.valorHora);
                Console.WriteLine(" {0,-20} {1,10}", "antiguedad", empleado.antiguedad);
                //Console.WriteLine(" {0,-20} {1,10}", "horas Trabajadas", empleado.horasTrabajadasMes);
                //Console.WriteLine(" {0,-20} {1,10}", "valor Antiguedad", empleado.valorAntiguedad);
                Console.WriteLine(" {0,-20} {1,10:#,###.00}", "bruto", empleado.bruto);
                Console.WriteLine(" {0,-20} {1,10:#,###.00}", "impuestos", empleado.impuestos);
                Console.WriteLine(" . . . . . . . . . . . . . . . .");
                Console.WriteLine(" {0,-20} {1,10:#,###.00}", "neto", empleado.neto);
                Console.WriteLine(" \n - \n");
            }
            Console.ReadKey();
        }
    }
}
