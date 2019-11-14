using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class NotImplementedException : Exception
    {
        public NotImplementedException(Exception innerException)
               : base("Exception no implementada", innerException) { }
    }
}
