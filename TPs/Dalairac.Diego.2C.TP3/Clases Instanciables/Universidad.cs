using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    /// <summary>
    /// Contiene listas de alumnos, profesores y jornadas.
    /// </summary>
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        #region Constructor
        /// <summary>
        /// Inicializa las listas
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
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
        /// Retorna y sobreescribe la lista de instructores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        /// <summary>
        /// Retorna y sobreescribe la lista de jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }
        /// <summary>
        /// Accede a los items de la lista de jornadas.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }
            set
            {
                this.jornadas[i] = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda la informacion de la universidad (en universidad.xml) recibida en formato xml.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            try
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Universidad.xml";
                return xml.Guardar(archivo, uni);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Lee los datos de guardados de la universidad (en universidad.xml) y los retorna.
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            try
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Universidad.xml";

                Universidad uni;
                xml.Leer(archivo, out uni);
                Console.WriteLine(uni);
                return uni;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Retorna una cadena con loas datos de la universidad.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada j in uni.Jornadas)
            {
                sb.AppendLine(j.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Retorna una cadena con loas datos de la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Una Universidad será igual a un Alumno si este está en la lista alumnos de la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
             
            return g.alumnos.Any(alumno => alumno == a);
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Una Universidad será igual a un Profesor, si este está en la lista de profesores de la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            return g.Instructores.Contains(i);
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Retornará: El primer Profesor (de la lista de profesores), que sea igual a la clase. 
        /// Sino, lanzará la Excepción SinProfesorException.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p == clase)
                {
                    return p;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Retornará: El primer Profesor (de la lista de profesores), que sea diferente a la clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p != clase)
                {
                    return p;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Agregar una clase a una universidad, creara una nueva jornada con los instructores y alumnos que esten en esa clase.
        /// Caso contrario, se lanzaran las excepciones correspondientes.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = g == clase;
            Jornada j = new Jornada(clase, profesor);
            List<Alumno> jornadaAlumnos = new List<Alumno>();
            foreach (Alumno alumno in g.Alumnos)
            {
                if(alumno == clase)
                {
                    jornadaAlumnos.Add(alumno);
                }
            }
            j.Alumnos = jornadaAlumnos;
            g.jornadas.Add(j);

            return g;
        }
        /// <summary>
        /// Al sumar un alumno a una universida, si este no se encuentra en la lista de alumnos, sera agregado a la misma.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        /// <summary>
        /// Al sumar un instructor a una universida, si este no se encuentra en la lista de instructores, sera agregado a la misma.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.Instructores.Add(i);
            }
            else
            {
                throw new SinProfesorException();
            }

            return g;
        }
        #endregion

        /// <summary>
        /// Clases posibles de la universidad.
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
