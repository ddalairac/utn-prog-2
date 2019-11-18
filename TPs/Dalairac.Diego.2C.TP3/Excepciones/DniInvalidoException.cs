using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Sera lanzada si la cadena recibida en DNI contiene caracteres que no son numeros.
    /// </summary>
    public class DniInvalidoException : Exception
    {
        private const string mensajeBase = "El DNI debe contener solo números.";

        static DniInvalidoException() {
        }
        public DniInvalidoException()
            : base(mensajeBase) { }
        public DniInvalidoException(Exception innerException)
            : base(mensajeBase, innerException) { }
        public DniInvalidoException(string message)
            : base(message) { }
        public DniInvalidoException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
