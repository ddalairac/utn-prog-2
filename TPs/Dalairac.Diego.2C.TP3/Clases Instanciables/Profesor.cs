using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
/*
 Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
 Sobrescribir el método MostrarDatos con todos los datos del profesor.
 ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
 ToString hará públicos los datos del Profesor.
 Se inicializará a Random sólo en un constructor.
 En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
mediante el método randomClases. Las dos clases pueden o no ser la misma.
 Un Profesor será igual a un EClase si da esa clase.*/

namespace Clases_Instanciables
{
    /// <summary>
    /// Clase de Profesor Universitario.
    /// </summary>
    public class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores
        /// <summary>
        /// Inicializa el atributo estatico random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }
        /// <summary>
        /// Inicializa la clase Profesor con los valores default. 
        /// Nombre y apellido: "", id: 1, nacionalidad: Argentino, legajo: 0.
        /// </summary>
        public Profesor() : base() { }
        /// <summary>
        /// Inicializa la clase Profesor con los valores recibidos como parametro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
                : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Agrega a la cola de clases del dia del profesor, 2 clases aleatorias.
        /// </summary>
        private void _randomClases()
        {
            int length = Enum.GetNames(typeof(Universidad.EClases)).Length;
            this.clasesDelDia.Enqueue((Universidad.EClases)(Profesor.random.Next(length)));
            this.clasesDelDia.Enqueue((Universidad.EClases)(Profesor.random.Next(length)));
        }
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona, su nacionalidad, legajo y clases del dia del Profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Retorna una cadena con las clases del dia del Profesor.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder("CLASES DEL DIA:\n");
            foreach (Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Retorna una cadena con el nombre completo de la persona, su nacionalidad, legajo y clases del dia del Profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un profesor sera igual a una clase, si la misma se encuentra en la cola de clases del dia.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }
        /// <summary>
        /// Un profesor sera diferente a una clase, si la misma no se encuentra en la cola de clases del dia.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
