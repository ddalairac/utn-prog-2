using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia() {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this() {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos() {
            StringBuilder str = new StringBuilder();
            str.AppendLine("LISTADO DE COMPETIDORES: ");
            if(this.competidores.Count > 0) { 
                foreach (AutoF1 a in this.competidores)
                {
                    str.AppendLine(a.MostrarDatos());
                    str.AppendLine("- \n");
                }
            } else
            {
                str.AppendLine("No hay autos inscriptos ");
            }
            return str.ToString();
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool rta = false;
            Random r = new Random();
            if (!(c is null) && !(a is null))
            {
                if (c != a)
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)r.Next(15, 100);
                    c.competidores.Add(a);
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            return true;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool isInList = false;
            if (!(c is null) && !(a is null))
            {
                if (c.cantidadCompetidores > c.competidores.Count)
                {
                    foreach (AutoF1 item in c.competidores)
                    {
                        if (item == a )
                        {
                            isInList = true;
                            break;
                        }
                    }
                }
            }
            return isInList;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
