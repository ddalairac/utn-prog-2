using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// Clase sellada: No se podra heredar de esta clase.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;


        #region "Constructores"
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        ///  Constructor: Define el espacio total disponible en la lista de productos del changuito.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Changuito(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Metodo Sobrecargado: Muestra el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Metodo: Retorna una cadena con todos los elementos del tipo seleccionado de la lista de productos.
        /// Expone todos los atributos (incluidos los de herencias) de de cada uno.
        /// </summary>
        /// <param name="c">Changuito del que se mostraran los pructos</param>
        /// <param name="ETipo">Tipos de ítems a mostrar de la lista</param>
        /// <returns>Cadena con los productos del tipo requerido</returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", c.productos.Count, c.espacioDisponible);
            sb.AppendLine($"* Tipos de productos en la lista: {c.productos.Select(p => p.GetType()).Distinct().Count()}");

            if (tipo != ETipo.Todos)
            {
                sb.Append($"* Cantidad del tipo {tipo}: ");
                switch (tipo)
                {
                    case ETipo.Snacks:
                        sb.Append(c.productos.OfType<Snacks>().Count());
                        break;
                    case ETipo.Leche:
                        sb.Append(c.productos.OfType<Leche>().Count());
                        break;
                    case ETipo.Dulce:
                        sb.Append(c.productos.OfType<Dulce>().Count());
                        break;
                }
            }
            sb.AppendLine("\n");




            foreach (Producto v in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (v is Snacks)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Dulce:
                        if (v is Dulce)
                        {
                            sb.AppendLine(v.Mostrar());
                        }

                        break;
                    case ETipo.Leche:
                        if (v is Leche)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Operador +: Agregará un producto a la lista si, 
        /// el mismo no se encuentra en la misma,
        /// y hay espacio disponible.
        /// </summary>
        /// <param name="c">Changuito con lista donde se agregará el Producto</param>
        /// <param name="p">Producto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            bool isInList = false;
            if (!(c is null) && !(p is null) && c.productos.Count < c.espacioDisponible)
            {
                foreach (Producto prod in c.productos)
                {
                    if (prod == p)
                    {
                        isInList = true;
                        break;
                    }
                }
                if (isInList == false)
                {
                    c.productos.Add(p);
                }

            }
            return c;
        }
        /// <summary>
        /// Operador -: Quitará un elemento de la lista si este se encuentra en la misma.
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            if (!(c is null) && !(p is null))
                foreach (Producto prod in c.productos)
                {
                    if (prod == p)
                    {
                        c.productos.Remove(prod);
                        break;
                    }
                }

            return c;
        }
        #endregion

        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }
    }
}
