using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks:Producto
    {
        /// <summary>
        ///  Constructor: Inicializa los atributos del producto con los parametros recibidos
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(marca,codigo, color)
        {
        }
        /// <summary>
        /// Propiedad (Solo lectura): Retornará la cantidad de calorias del producto
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }
        /// <summary>
        /// Metodo: Retorna una cadena con todos los atributos del Producto.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** SNACKS ***");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"--------------------------------------");

            return sb.ToString();
        }
    }
}
