using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        public Producto(string marca, string codigo, float precio) {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca() {
            return this.marca;
        }
        public float GetPrecio() {
            return this.precio;
        }
        public static string MostrarProducto(Producto p) {
            string aux = "";
            if (!(p is null))
            {
                aux += String.Format("Marca: {0} \nPrecio: {1:#,###.00}\nCódigo de Barras: {2}\n\n", p.marca, p.precio, p.codigoDeBarra);
            }
            return aux;  
        }

        public static explicit operator string(Producto p)
        {
            string aux = "";
            if (!(p is null)) {
                aux = p.codigoDeBarra;
            }
            return aux;
        }
        public static bool operator ==(Producto p1, Producto p2)
        { 
            bool aux = false;
            if (!(p1 is null) && !(p2 is null)) { 
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    aux = true;
                }
            }
            return aux;
            //return p1.marca.Equals(p2.marca) && p1.codigoDeBarra.Equals(p2.codigoDeBarra);

        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            bool aux = false;
            if (!(p1 is null)) 
            {
                if (p1.marca == marca)
                {
                    aux = true;
                }
            }
                return aux;
            //return p1.marca.Equals(marca);
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }

    }
}
