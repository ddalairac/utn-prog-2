using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }
        public Caja Caja1
        {
            get { return this.caja1; }
            //set { this.caja1 = value; }
        }
        public Caja Caja2
        {
            get { return this.caja2; }
            //set { this.caja2 = value; }
        }
        public List<string> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.clientes.ToList())
            {
                if(this.Caja1.FilaClientes.Count < this.Caja2.FilaClientes.Count)
                {
                    this.Caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    this.Caja2.FilaClientes.Add(cliente);
                }
                this.clientes.Remove(cliente);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Todos los clientes estan asignados a una caja");



            //Thread tC1 = new Thread(caja1.AtenderClientes);
            //Thread tC2 = new Thread(caja2.AtenderClientes);

        }

    }
}
