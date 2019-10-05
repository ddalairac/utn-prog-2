using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }

        public string NroDestino { get { return nroDestino; } }

        public string NroOrigen { get { return nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("\tDuracion: {0}", Duracion);
            str.AppendFormat("\tDestino: {0}", NroDestino);
            str.AppendFormat("\tOrigen: {0}", NroOrigen);

            return str.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int response = 0;

            if (llamada2.duracion > llamada1.duracion)
            {
                response = -1;
            }
            else if (llamada2.duracion < llamada1.duracion)
            {
                response = 1;        
            }
            return response;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
