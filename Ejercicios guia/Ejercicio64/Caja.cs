using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;
        private string name;


        public Caja()
        {
            this.filaClientes = new List<string>();
        }
        public Caja(string name):this()
        {
            this.name = name;
        }
        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
            //set { this.filaClientes = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public void AtenderClientes()
        {
            foreach (string item in this.filaClientes.ToList())
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"{Name}: {item}");
                this.filaClientes.Remove(item);
            }

        }

    }
}
