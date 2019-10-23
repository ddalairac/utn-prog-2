using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Torneo<T> where T : Equipo

    {
        public List<T> equipos;
        public string nombre;
        private Random r;

        public Torneo(string nombre){
            this.nombre = nombre;
            this.equipos = new List<T>();
            this.r = new Random();
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach (T item in t.equipos)
            {
                if (item == e) return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if (t != e)
            {
                t.equipos.Add(e);
            }
            return  t;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder($"Torneo: {this.nombre}\n\n");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1, T e2)
        {
            return $"{e1.nombre} [{this.r.Next(0,5)}] – {e2.nombre} [{this.r.Next(0, 5)}]";
        }
        

        public string JugarPartido
        {
            get {
                return CalcularPartido(
                    this.equipos[r.Next(this.equipos.Count)], 
                    this.equipos[r.Next(this.equipos.Count)]
                );
            }
        }

    }
}
