using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    abstract public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }

        public string NroDestino { get { return nroDestino; } }

        public string NroOrigen { get { return nroOrigen; } }

        abstract public float CostoLlamada { get; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        virtual protected string Mostrar()
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

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (!(l1 is null) 
                && !(l2 is null) 
                && l1.NroDestino == l2.NroDestino 
                && l1.NroOrigen == l2.NroOrigen) ? true : false;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public override bool Equals(object o)
        {
            bool rta = false;
            if (!(o is null)  && !(o is Llamada)) {
                Llamada l = (Llamada)o;
                if(l.NroDestino == this.NroDestino
                && l.NroOrigen == this.NroOrigen)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
