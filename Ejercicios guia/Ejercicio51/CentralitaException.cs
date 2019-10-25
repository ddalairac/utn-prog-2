using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public class CentralitaExcepction : Exception
    {
        private string clase;
        public string Clase
        {
            get { return this.clase; }
        }
        private string metodo;
        public string Metodo
        {
            get { return this.metodo; }
        }
        
        public CentralitaExcepction(string message, Exception innerException) : base(message, innerException) { }

        public CentralitaExcepction(string message) : this(message,null) { }

        public CentralitaExcepction(string message, string clase, string metodo, Exception innerException) : this(message, innerException)
        {
            this.clase = clase;
            this.metodo = metodo;
        }
        public CentralitaExcepction(string message, string clase, string metodo) : this(message,clase,metodo,null){ }
    }
}
