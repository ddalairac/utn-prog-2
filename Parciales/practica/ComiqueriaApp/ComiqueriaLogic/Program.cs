using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Comiqueria comiqueria;
            Dictionary<Guid, string> listaProductos;
            //Utilice este campo para acceder al producto seleccionado actualmente. 
            //Producto productoSeleccionado;

            comiqueria = new Comiqueria();
            //Productos
            Producto producto1 = new Comic("AMAZING SPIDER-MAN 01: SUERTE DE ESTAR VIVO", 5, 560.00, "Dan Slott", Comic.TipoComic.Occidental);
            Producto producto2 = new Figura("DC FIGURAS 29: STARFIRE", 2, 650.00, 29.00);
            Producto producto3 = new Figura(1, 349.58, 20);
            producto3.Stock = -2; //No debería cambiar el stock. 
            Producto producto4 = new Comic("AKIRA 01 (EDICION CON SOBRECUBIERTA)", 10, 800.00, "KATSUHIRO OTOMO", Comic.TipoComic.Oriental);
            producto4.Stock = 5; //El stock debería ser 5. 
            Producto producto5 = new Figura(3, 649.58, 20);

            comiqueria += producto1;
            comiqueria += producto2;
            comiqueria += producto3;
            comiqueria += producto4;

            //No debería agregar
            comiqueria += producto5;

            //Sobrecargas de vender. 
            comiqueria.Vender(producto1);
            comiqueria.Vender(producto4, 2);

            listaProductos = comiqueria.ListarProductos();
            Console.WriteLine(comiqueria.ToString());
            Console.WriteLine(comiqueria.ListarVentas());

            Console.ReadKey();

        }
    }
}

