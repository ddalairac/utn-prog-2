using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class AutoF1
    {   
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Numero: {this.numero}");
            str.AppendLine($"Escuderia: {this.escuderia}");
            str.AppendLine($"Cantidad Combustible: {this.cantidadCombustible}");
            str.AppendLine($"En competencia: {this.enCompetencia}");
            str.AppendLine($"VueltasRestantes: {this.vueltasRestantes}");
            return str.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool rta = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
