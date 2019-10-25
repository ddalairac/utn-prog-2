using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    public class Remito: Documento
    {
        public Remito(int numero) : base(numero) { }
        public Remito() : this(0) { }

        public override string Mostrar()
        {
            return $"R: {base.Mostrar()}";
        }
    }
}
