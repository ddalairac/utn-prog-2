using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class CentralitaExcepction : Exception
    {
        //public string message;
        public CentralitaExcepction(string message) : base($"Exc Centralita: {message}") { }
    }
}
