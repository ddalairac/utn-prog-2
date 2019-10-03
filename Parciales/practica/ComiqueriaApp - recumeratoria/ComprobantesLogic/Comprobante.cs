using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
    class Comprobante
    {
        protected DateTime fechaEmision;

        private Venta venta;

        public Venta Venta
        {
            get { return this.venta; }
        }
        public Comprobante(Venta venta)
        {
            this.venta = venta;
            this.fechaEmision = venta.Fecha;
        }
        public virtual string GenerarComprobante() { return ""; }

        public override bool Equals(Object obj)
        {
            bool aux = false;
            if (!(obj is null) && obj is Comprobante)
            {
                Comprobante comp = (Comprobante)obj;
                if (comp.fechaEmision == this.fechaEmision)
                {
                    aux = true;
                }
            }
            return aux;
        }

    }
}
