using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio n = new Negocio(new Caja("1"), new Caja("2"));

            //n.Caja1.FilaClientes.Add("Juan");
            //n.Caja1.FilaClientes.Add("Ana");
            //n.Caja1.FilaClientes.Add("Pedro");
            //n.Caja1.FilaClientes.Add("Lucas");
            //n.Caja1.FilaClientes.Add("Adam");
            //n.Caja1.FilaClientes.Add("Diego");
            //n.Caja1.FilaClientes.Add("Matias");
            //n.Caja1.AtenderClientes();


            n.Clientes.Add("Juan");
            n.Clientes.Add("Ana");
            n.Clientes.Add("Pedro");
            n.Clientes.Add("Lucas");
            n.Clientes.Add("Adam");
            n.Clientes.Add("Diego");
            n.Clientes.Add("Matias");

            n.AsignarCaja();
            //n.Caja1.AtenderClientes();
            //n.Caja2.AtenderClientes();
            Thread tAsignar = new Thread(n.AsignarCaja);
            Thread tC1 = new Thread(n.Caja1.AtenderClientes);
            Thread tC2 = new Thread(n.Caja2.AtenderClientes);
            //tAsignar.Start();
            tC1.Start();
            tC2.Start();

            

            Console.ReadKey();
        }
    }
}
