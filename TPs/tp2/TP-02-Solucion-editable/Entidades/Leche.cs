using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        /// <summary>
        /// Enum: Tipos de Leches
        /// </summary>
        public enum ETipo { Entera, Descremada }

        private ETipo tipo;


        #region "Constructores"
        /// <summary>
        /// Constructor: Inicializa los atributos del producto con los parametros recibidos
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo)
            : base(marca, codigo, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Constructor: Inicializa los atributos del producto con los parametros recibidos
        /// TIPO: Por defecto será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
           : this(marca, codigo, color, ETipo.Entera) { }

        #endregion


        /// <summary>
        /// Propiedad (Solo lectura): Retornará la cantidad de calorias del producto
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Metodo: Retorna una cadena con todos los atributos del Producto.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** LECHE ***");
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($"TIPO             : {this.tipo}");
            sb.AppendLine($"--------------------------------------");

            return sb.ToString();
        }
    }
}
