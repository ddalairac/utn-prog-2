using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        static Venta()
        {
            porcentajeIva = 32;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        internal DateTime Fecha
        {
            get { return this.fecha; }
        }
        private void Vender(int cantidad)
        {
            int vendidos = 0;
            if (this.producto.Stock >= cantidad)
            {
                this.producto.Stock -= cantidad;
                vendidos = cantidad;
            }
            //else
            //{
            //    int noVendidos = cantidad - this.producto.Stock;
            //    vendidos = cantidad - noVendidos;
            //    this.producto.Stock = 0;
            //}
            this.fecha = DateTime.Today;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, vendidos);

        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.fecha} - ");
            str.Append($"{this.producto.Descripcion} - ");
            str.Append($"{this.precioFinal:#,###.00}");
            return str.ToString();
        }
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioFinal = precioUnidad * cantidad * ((Venta.porcentajeIva / 100)+1);
            return precioFinal;
        }

    }
}
