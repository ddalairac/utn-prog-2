using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Sera lanzada cuando la Nacionalidad no corresponda con el numero de DNI
    /// </summary>
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException(string message) 
            : base(message) { }
        public NacionalidadInvalidaException() 
            : this("La nacionalidad no se condice con el numero de DNI") { }
    }
}
