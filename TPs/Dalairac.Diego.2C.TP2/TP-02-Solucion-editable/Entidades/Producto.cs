using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// Clase abstracta: atributos, propiedad, metodos y operadores comunes a todos los productos
    /// </summary>
    public abstract class Producto
    {
        /// <summary>
        /// Enum: Tipos de marcas posibles para productos
        /// </summary>
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// Constructor: Inicializa los atributos del producto con los parametros recibidos, no posee sobrecargas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDeBarras"></param>
        /// <param name="colorPrimarioEmpaque"></param>
        public Producto(EMarca marca,string codigoDeBarras,ConsoleColor colorPrimarioEmpaque)
        {
            this.marca = marca;
            this.codigoDeBarras = codigoDeBarras;
            this.colorPrimarioEmpaque = colorPrimarioEmpaque;
        }

        /// <summary>
        /// Propiedad (Solo lectura): Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }

        /// <summary>
        /// Metodo: Retorna una cadena con todos los atributos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string) this;
        }
        /// <summary>
        /// Parseo a string explicito: retorna una cadena con todos los atributos del Producto.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            if (!(p is null))
            {
                sb.AppendLine($"CODIGO DE BARRAS : {p.codigoDeBarras}\r");
                sb.AppendLine($"MARCA            : {p.marca.ToString()}\r");
                sb.AppendLine($"COLOR EMPAQUE    : {p.colorPrimarioEmpaque.ToString()}\r");
                sb.AppendLine($"CALORIAS         : {p.CantidadCalorias}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Operador Igualdad: Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            bool aux = false;
            if (!(v1 is null) && !(v2 is null))
            {
                aux = (v1.codigoDeBarras == v2.codigoDeBarras) ? true : false;
            }
            return aux;
        }
        /// <summary>
        /// Operador Diferencia: Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }
    }
}
