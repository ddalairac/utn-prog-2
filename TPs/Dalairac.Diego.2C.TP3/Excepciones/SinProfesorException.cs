using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Sera lanzada si se intenta sumar una clase a una universidad y no hay profesores que la tengan en su lista de clases del dia.
    /// </summary>
    public class SinProfesorException : Exception
    {
        public SinProfesorException()
            : base("No hay profesor para la clase.") { }
    }
}
