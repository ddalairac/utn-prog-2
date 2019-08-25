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

    Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, 
    el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. 
    
    Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio08
{
    public class Empleado
    {
        public string nombre;
        public int valorHora;
        public int antiguedad;
        public int horasTrabajadasMes;
        public int valorAntiguedad {
            get{
                return this.antiguedad * 150;
            }
            set
            {
                this.antiguedad = value;
            }
        }
        public double bruto
        {
            get
            {
                return (this.valorHora * this.horasTrabajadasMes) + valorAntiguedad;
            }
            set
            {
                this.bruto = value;
            }
        }
        public double neto
        {
            get
            {
                return this.bruto * 0.87;
            }
            set
            {
                this.neto = value;
            }
        }
        public double impuestos
        {
            get
            {
                return this.bruto * 0.13;
            }
            set
            {
                this.impuestos = value;
            }
        }

        // Constructor
        public Empleado(
            string nombre,
            int valorHora,
            int antiguedad,
            int horasTrabajadasMes
            )
        {
            this.nombre = nombre;
            this.valorHora = valorHora;
            this.antiguedad = antiguedad;
            this.horasTrabajadasMes = horasTrabajadasMes;
        }
    }
}
