using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public string Escuderia
        {
            get { return escuderia; }
            set { this.escuderia = value; }
        }
        public short Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }
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

        public VehiculoDeCarrera(short numero, string escuderia)
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
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool rta = false;
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.numero == v2.numero && v1.escuderia == v2.escuderia)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
