using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    // NO SE ENTIENDE QUE HAY QUE HACER
    public class Centralita<T> : IGuardar<T> 
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        
        public string Mostrar(Llamada.TipoLlamada tipo)
        {
            Local local;
            Provincial provincial;
            StringBuilder str = new StringBuilder();
            str.AppendFormat("\tRazon social: {0} \n", razonSocial);
            str.AppendLine("\t-");

            foreach (Llamada l in Llamadas)
            {
                if (l is Local && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Local))
                {
                    local = (Local)l;
                    str.AppendLine(local.ToString());
                }
                else if(l is Provincial && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Provincial))
                {
                    provincial = (Provincial)l;
                    str.AppendLine(provincial.ToString());
                }
            }
            str.AppendLine("\t------------------------------------------------------------------------------------");
            str.Append("\tGANANCIAS:: ");
            switch (tipo)
            {
                case Llamada.TipoLlamada.Todas:
                    str.AppendFormat("¦  Total: {0}  ", GananciasPorTotal);
                    str.AppendFormat("¦  Local: {0}  ", GananciasPorLocal);
                    str.AppendFormat("¦  Provincial: {0}  ", GananciasPorProvincial);
                    break;
                case Llamada.TipoLlamada.Local:
                    str.AppendFormat("¦  Local: {0}  ", GananciasPorLocal);
                    break;
                case Llamada.TipoLlamada.Provincial:
                    str.AppendFormat("¦  Provincial: {0}  ", GananciasPorProvincial);
                    break;

            }
            str.AppendLine("  ¦\n");

            return str.ToString();
        }
        public string Mostrar()
        {
            //Local local;
            //Provincial provincial;
            //StringBuilder str = new StringBuilder();
            //str.AppendFormat("\tRazon social: {0} \n", razonSocial);
            //str.Append("\tGanancias:: ");
            //str.AppendFormat("Total: {0}", GananciasPorTotal);
            //str.AppendFormat("  ¦  Local: {0}  ¦  Provincial: {1}\n", GananciasPorLocal, GananciasPorProvincial);
            //str.AppendLine("\t-");

            //foreach (Llamada l in Llamadas)
            //{
            //    if (l is Local)
            //    {
            //        local = (Local)l;
            //        str.AppendLine(local.ToString());
            //    }
            //    else
            //    {
            //        provincial = (Provincial)l;
            //        str.AppendLine(provincial.ToString());
            //    }
            //}
            //str.AppendLine("\t-----------------------------------------------------------");

            //return str.ToString();
            return Mostrar(Llamada.TipoLlamada.Todas);
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acum = 0;
            Local local;
            Provincial provincial;

            foreach (Llamada l in Llamadas)
            {
                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (l is Local)
                    {
                        local = (Local)l;
                        acum += local.CostoLlamada;
                    }
                    else
                    {
                        provincial = (Provincial)l;
                        acum += provincial.CostoLlamada;
                    }
                }
                else if (tipo == Llamada.TipoLlamada.Local)
                {
                    if (l is Local)
                    {
                        local = (Local)l;
                        acum += local.CostoLlamada;
                    }
                }
                else if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (l is Provincial)
                    {
                        provincial = (Provincial)l;
                        acum += provincial.CostoLlamada;
                    }
                }
            }

            return acum;
        }

        private bool AgregarLlamada( Llamada l)
        {
            bool rta = false;
            if (!(l is null) && l is Llamada)
            {
                this.Llamadas.Add(l);
                rta = true;
            }
            return rta;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Centralita<T> c, Llamada l)
        {
            bool rta = false;
            if (!(l is null) && !(c is null) && l is Llamada && c is Centralita<T>)
            {
                foreach (Llamada aux in c.Llamadas)
                {
                    if (aux == l)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Centralita<T> c, Llamada l)
        {
            return !(c == l);
        }
        public static Centralita<T> operator +(Centralita<T> c, Llamada l)
        {
            
            if(c != l)
            {
                c.AgregarLlamada(l);
            }
            else
            {
                throw new CentralitaExcepction("Esta llamada ya se encuentra registrada en el sistema","Centralita","+");
            }
            return c;
        }
    }
}
