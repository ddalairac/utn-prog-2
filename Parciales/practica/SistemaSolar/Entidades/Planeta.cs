using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantidaSatelites;
        private Tipo tipo;
        private List<Astro> satelites;
        public Planeta(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre) {
            this.satelites = new List<Astro>();
        }
        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantidaSatelites, Tipo tipo)
            : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantidaSatelites = cantidaSatelites;
            this.tipo = tipo;
        }

        public List<Astro> Satelites
        {
            get { return this.satelites; }
            //set { this.satelites = value; }
        }

        public override string Orbitar()
        {
            return $"Orbita el planeta: {(string)this}\n.";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Cantidad Satelites: {this.cantidaSatelites} - Tipo: {this.tipo}");
            return sb.ToString();
        }

        public new string Rotar()
        {
            return $"Orbita el planeta: {(string)this}.\n";
        }
        public static Planeta operator +(Planeta p, Astro a)
        {
            if (!(p is null) && !(a is null) && a.GetType() == Type.GetType("Satelite"))
            {
                p.satelites.Add(a);
            }

            return p;
        }
        public static bool operator ==(Planeta p, Satelite s)
        {
            bool aux = false;
            if (!(p is null) && !(s is null))
            {
                foreach (Astro sat in p.satelites)
                {
                    if ((string)sat == (string)s)
                    {
                        aux = true;
                    }
                }
            }

            return aux;
        }
        public static bool operator !=(Planeta p, Satelite s)
        {
            return !(p == s);
        }

        public static bool operator ==(Planeta p1, Planeta p2)
        {
            bool aux = false;
            if (!(p1 is null) && !(p2 is null) && (string)p1 == (string)p2)
            {
                aux = true;
            }
            return aux;
        }
        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }
    }
    public enum Tipo
    {
        Rocoso, Gaseoso
    }
}

