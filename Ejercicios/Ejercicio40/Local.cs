using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Local : Llamada
    {
        protected float costo;
        public override float CostoLlamada { get { return CalcularCosto(); } }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
        protected new string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\tLOCAL");
            str.AppendLine(base.Mostrar());
            str.AppendFormat("\tCosto: ${0:#,###.00}\n", this.CostoLlamada);
            return str.ToString();
        }
        public override bool Equals(object o)
        {
            return (!(o is null) && !(o is Local)) ? true : false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
