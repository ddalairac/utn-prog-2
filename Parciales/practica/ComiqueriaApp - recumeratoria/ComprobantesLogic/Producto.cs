using System;
using System.Collections.Generic;
using System.Text;

namespace ComprobantesLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value > 1 ? value : this.precio; }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Descripcion: {this.descripcion}");
            str.AppendLine($"Codigo: {this.codigo}");
            str.AppendLine($"Precio: ${this.precio:#,##.00}");
            str.AppendLine($"Stock: {this.stock} unidades");
            return str.ToString();
        }


    }
}
