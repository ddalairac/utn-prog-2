using System;
using System.Collections.Generic;
using System.Text;

namespace ComprobantesLogic
{
    public class Figura : Producto
    {
        private double altura;
        public Figura(string descripcion, int stock, double precio, double altura)
            : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        public Figura(int stock, double precio, double altura)
            : this(("Figura " + altura + " cm"), stock, precio, altura)
        { }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Altura: {this.altura}");
            return str.ToString();
        }
    }
}
