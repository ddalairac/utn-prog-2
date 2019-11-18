using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException(string message)
            : base(message) { }
        public PatenteInvalidaException(string message, Exception innerException)
            : base(message, innerException) { }

    }
}
