using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Remito> cont = new Contabilidad<Factura, Remito>();

            cont += new Factura(500);
            cont += new Factura(670);
            cont += new Factura(80);
            cont += new Factura(23500);
            cont += new Remito(23423);
            cont += new Remito(654);
            cont += new Remito(867);
            cont += new Remito(25);
            cont += new Remito();
            
            Console.WriteLine(cont.Mostrar());
            Console.ReadKey();

        }
    }
}
