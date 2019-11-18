using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta Universitario
    /// </summary>
    public abstract class Universitario : Persona
    {
        private int legajo;
        /// <summary>
        /// Get / Set del legajo
        /// </summary>
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }


        #region Constructores
        /// <summary>
        /// 
        /// Inicializa la clase Universitario con los valores default. 
        /// Nombre y apellido: "", id: 1, nacionalidad: Argentino, y legajo: 0.
        /// </summary>
        public Universitario() : base() { }

        /// <summary>
        /// Inicializa la clase Universitario con los valores recibidos como parametro.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// El objeto sera equivalente, si es del tipo Universitario y si el Dni o Legajo son iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Universitario) && this == (Universitario)obj;
        }
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona, su nacionalidad y legajo.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"\nLEGAJO NúMERO: {this.legajo}");
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Operadores
        /// <summary>
        /// Seran iguales si son del mismo tipo y el Dni o Legajo son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.GetType() == pg2.GetType() &&
                   (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
        }
        /// <summary>
        /// Seran diferentes no son del mismo tipo o si el Dni o Legajo son diferentes.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
