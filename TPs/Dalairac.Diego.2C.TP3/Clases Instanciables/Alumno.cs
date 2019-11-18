using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    /// <summary>
    /// Clase sellada de Alumno Universitario.
    /// </summary>
    public sealed class Alumno: Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores
        /// <summary>
        /// Inicializa la clase Alumno con los valores default. 
        /// Nombre y apellido: "", id: 1, nacionalidad: Argentino, legajo: 0.
        /// </summary>
        public Alumno() : base() { }

        /// <summary>
        /// Inicializa la clase Alumno con los valores recibidos como parametro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) 
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }
        /// <summary>
        /// Inicializa la clase Alumno con los valores recibidos como parametro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="clasesQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma) 
            : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma, EEstadoCuenta.Deudor) { }

        #endregion

        #region Metodos
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona, su nacionalidad, legajo, estado de cuenta y clase que toma el Alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            string estadoCuentaParaUsuario = (this.estadoCuenta == EEstadoCuenta.AlDia) ? "Cuota al día" : this.estadoCuenta.ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: {estadoCuentaParaUsuario}");
            sb.Append(ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Retorna una cadena con la clase que toma el Alumno.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE: {this.claseQueToma}";
        }
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona, su nacionalidad, legajo, estado de cuenta y clase que toma el Alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// El alumno sera igual a una clase, si su estado de cuenta no es Deudor y si la clase que toma es igual a la clase comparada.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase;
        }
        /// <summary>
        /// El alumno sera diferente a una clase, si la clase que toma es diferente a la clase comparada.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        #endregion
        /// <summary>
        /// Estados de cuenta posibles del Alumno
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
