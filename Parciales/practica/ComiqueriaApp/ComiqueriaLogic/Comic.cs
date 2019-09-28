using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Autor: {this.autor}");
            str.AppendLine($"Tipo de Comic: {this.tipoComic.ToString()}");
            return str.ToString();
        }
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
    }
}
