using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase absracta persona
    /// </summary>
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        #region  Constructores
        /// <summary>
        /// Inicializa la clase Persona con los valores recibidos como parametro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Inicializa la clase Persona con los valores recibidos como parametro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Inicializa la clase Persona con los valores recibidos como parametro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// Inicializa la clase Persona con los valores default. 
        /// Nombre y apellido: "", id: 1 y nacionalidad: Argentino.
        /// </summary>
        public Persona() { }
        #endregion
        #region Propiedades
        /// <summary>
        /// Get / Set del Nombre. Valida que el contenga solo letras. Caso contrario setea 'Error'.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Get / Set del Apellido. Set valida que el contenga solo letras. Caso contrario setea 'Error'.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Get / Set del DNI. Set valida que el numero este en el rango 1-89999999 si es argentino, y
        /// 90000000-99999999 si es extrangero.
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.nacionalidad, value); }
        }
        /// <summary>
        /// Get / Set del DNI. Set Valida que la cadena ingresada contenga solo numeros, y que el rango corresponda a la nacionalidad.
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.nacionalidad, value); }
        }
        /// <summary>
        /// Get / Set de la nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set
            {
                this.nacionalidad = value;
            }
        }

        #endregion
        #region Metodos
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona y su nacionalidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.apellido}, {this.nombre}");
            sb.AppendLine($"NACIONALIDAD: {this.nacionalidad}");
            //sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }
        /// <summary>
        /// Valida que el numero recibido este en el rango 1-89999999 para nacionalidad argentino, 
        /// 90000000-99999999 para nacionalidad extrangero. Caso contrario lanza la excepcion 'NacionalidadInvalidaException'.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>DNI validados</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if ((nacionalidad == ENacionalidad.Argentino && dato > 1 && dato < 89999999) ||
                (nacionalidad == ENacionalidad.Extranjero && dato > 90000000 && dato < 99999999))
            {
                return dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }
        }
        /// <summary>
        /// Valida que la cadena ingresada contenga solo numeros y que el rango corresponda a la nacionalidad.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>DNI validados</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            bool esNumero = Regex.IsMatch(dato, @"^[0-9]+$");
            if (esNumero && int.TryParse(dato, out dni) && dato.Length <= 8)
            {
                return this.ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoException();
            }
        }
        /// <summary>
        /// Valida que la cadena ingresada contenga solo letras. Caso contrario retorna 'Error'.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            string rta = "Error";
            Regex r = new Regex(@"^[a-zA-Z ]+$");
            if (r.IsMatch(dato))
            {
                rta = dato;
            }
            return rta;
        }
        #endregion
        /// <summary>
        /// Nacionalidades posibles de la Persona
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
