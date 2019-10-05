using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        public static int NumeroActual {
            get {
                return numeroActual++;
            }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente c)
        {
            bool rta = false;
            if(!(c is null)) { 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"El cliente {c.Numero} ({c.Nombre}) esta siendo atendido");
                Console.ResetColor();
                System.Threading.Thread.Sleep(2000);
                rta = true;
            }
            return rta;
        }

        public enum Puesto
        {
            Caja1 = 0,
            Caja2 = 1
        }
    }
}
