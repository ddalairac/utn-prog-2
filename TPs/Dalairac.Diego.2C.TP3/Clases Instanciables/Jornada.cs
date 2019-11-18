using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Constructores
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y sobreescribe la lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// Retorna y sobreescribe la clase.
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        /// <summary>
        /// Retorna y sobreescribe la lista de instructores.
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda la informacion de la jornada (en jornada.txt) recibida en formato texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                Texto t = new Texto();
                return t.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Jornada.txt", jornada.ToString());
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Lee los datos de guardados de la jornada (en jornada.txt) y los retorna en una cadena.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            try
            {
                Texto t = new Archivos.Texto();
                string texto;
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Jornada.txt";
                t.Leer(archivo, out texto); ;
                //Console.WriteLine(texto);
                return texto;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        ///  Retorna una cadena con loas datos de la jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            sb.AppendLine($"CLASE DE {this.Clase} POR NOMBRE COMPLETO: {this.Instructor}");
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine($"NOMBRE COMPLETO: {a.ToString()}");
            }
            sb.AppendLine("<---------------------------------------------->\n");
            return sb.ToString();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Una jornada sera igual a un alumno, si este se encuentra en su lista de alumnos.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return j.Alumnos.Contains(a);
        }
        /// <summary>
        /// Una jornada sera diferente a un alumno, si este no se encuentra en su lista de alumnos.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Al sumar un alumno a una jornada, si este no se encuentra en la lista de alumnos, sera agregado a la misma.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
        }
        #endregion
    }
}
