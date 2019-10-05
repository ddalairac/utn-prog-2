using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.nombre = PuestoAtencion.Puesto.Caja1.ToString();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get {
                Cliente cChau;
                if (this.clientes.Count > 0) { 
                    cChau = clientes.Dequeue();
                } else
                {
                    cChau = null;
                }
                return cChau;
            }
            set {
                if(this != value) { 
                    clientes.Enqueue(value);
                }
            }
        }
        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool rta = false;
            if(!(n is null) && !(c is null)) { 
                if (n != c)
                {
                    n.Cliente = c;
                    rta = true;
                }
            }

            return rta;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool rta = false;
            if (!(n is null) && !(c is null))
            {
                foreach (Cliente c2 in n.clientes)
                {
                    if (c.Numero == c2.Numero)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }


    }
}
