using System;
using System.Collections.Generic;
using System.Text;

namespace ComprobantesLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;
        static Stack<Comprobante> comprobantes;
        static Comiqueria()
        {
            comprobantes = new Stack<Comprobante>();
        }
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public List<Comprobante> this[Producto prod, bool isListed]
        {
            get
            {
                List<Comprobante> comp = new List<Comprobante>();
                return comp;
            }
        }

        public Producto this[Guid codigo]
        {
            get
            {
                Producto prodAux = null;
                foreach (Producto prod in this.productos)
                {
                    if ((Guid)prod == codigo)
                    {
                        prodAux = prod;
                    }
                }
                return prodAux;
            }
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> dic = new Dictionary<Guid, string>();
            foreach (Producto prod in this.productos)
            {
                if (!(prod is null) && !(dic.ContainsKey((Guid)prod)))
                {
                    dic.Add((Guid)prod, prod.Descripcion);
                }
            }
            return dic;
        }
        public string ListarVentas()
        {
            StringBuilder srt = new StringBuilder("LISTADO DE VENTAS:\n");
            if (this.ventas.Count > 0)
            {
                foreach (Venta venta in this.ventas)
                {
                    if (!(venta is null))
                    {
                        srt.AppendLine(venta.ObtenerDescripcionBreve());
                    }
                }
            } else
            {
                srt.AppendLine("No hay ventas en la lista");
            }
            return srt.ToString();
        }
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool rta = false;
            if (!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto prod in comiqueria.productos)
                {
                    if (prod.Descripcion == producto.Descripcion)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria is null) && !(producto is null))
            {
                if (comiqueria != producto)
                {
                    comiqueria.productos.Add(producto);
                }
            }
            return comiqueria;
        }
    }
}
