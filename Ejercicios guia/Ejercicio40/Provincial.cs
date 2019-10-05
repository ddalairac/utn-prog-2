using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada { get { return CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        protected new string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\tPROVINCIAL");
            str.AppendLine(base.Mostrar());
            str.AppendFormat("\tCosto: ${0:#,###.00} \tFranja: {1}\n", this.CostoLlamada, franjaHoraria);
            return str.ToString();
        }


        private float CalcularCosto()
        {
            float response = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    response = (float)0.99;
                    break;
                case Franja.Franja_2:
                    response = (float)1.25;
                    break;
                case Franja.Franja_3:
                    response = (float)0.66;
                    break;
            }

            return base.Duracion * response;
        }

        public override bool Equals(object o)
        {
            return (!(o is null) && !(o is Provincial)) ? true : false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
