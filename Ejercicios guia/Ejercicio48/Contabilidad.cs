using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    public class Contabilidad<T,U> where T: Documento where U : Documento, new()

    {
        private List<T> egresos;
        private List<U> ingresos;
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public List<T> Egresos
        {
            get { return this.egresos; }
        }

        public List<U> Ingresos
        {
            get { return this.ingresos; }
        }


        public static Contabilidad<T,U> operator +(Contabilidad<T, U> c, T t)
        {
            c.egresos.Add(t);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U u)
        {
            c.ingresos.Add(u);
            return c;
        }

        public string MostrarEgresos()
        {
            StringBuilder sb = new StringBuilder("Egresos:\n");
            foreach (T item in this.egresos)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }

        public string MostrarIngresos()
        {
            StringBuilder sb = new StringBuilder("Ingresos:\n");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }
        public string Mostrar<X>()
        {
            StringBuilder sb = new StringBuilder("Ingresos:\n");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MostrarIngresos());
            sb.AppendLine(MostrarEgresos());
            return sb.ToString();
        }
    }
}
