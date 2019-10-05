using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;


        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("LISTADO DE COMPETIDORES: ");
            str.AppendLine($"Tipo: {this.tipo}");
            if (this.competidores.Count > 0)
            {
                foreach (VehiculoDeCarrera a in this.competidores)
                {
                    str.AppendLine(a.MostrarDatos());
                    str.AppendLine($"GetType: {a.GetType().ToString()}");
                    str.AppendLine("- \n");
                }
            }
            else
            {
                str.AppendLine("No hay autos inscriptos ");
            }
            return str.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool rta = false;
            Random r = new Random();
            if (!(c is null) && !(a is null))
            {
                if (c != a && ("Ejercicio36."+c.Tipo.ToString()) == a.GetType().ToString())//
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
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool isInList = false;
            if (!(c is null) && !(a is null))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item == a)
                    {
                        c.competidores.Remove(item);
                        isInList = true;
                        break;
                    }
                }

            }
            return isInList;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool isInList = false;
            if (!(c is null) && !(a is null))
            {
                if (c.cantidadCompetidores > c.competidores.Count)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (item == a)
                        {
                            isInList = true;
                            break;
                        }
                    }
                }
            }
            return isInList;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public enum TipoCompetencia{
            AutoF1, MotoCross
        }
    }
}
