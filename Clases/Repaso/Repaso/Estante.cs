using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string response = "";
            if (!(e is null))
            {
                foreach (var prod in e.productos)
                {
                    response += Producto.MostrarProducto(prod);
                }
            }
            return response;
        }
        public static bool operator ==(Estante e,Producto p){
            bool aux = false;
            if(!(p is null)){ 
                foreach (var prod in e.productos)
                {
                    if(prod == p)
                    {
                        aux = true;
                        break;
                    }
                }
            }
            return aux;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool aux = false;
            if (!(p is null) && e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        aux = true;
                        break;
                    }
                }
            }
            return aux;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (!(p is null) && e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
    }
}
