using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite:Astro
    {
        public Satelite(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre) { }

        public string Nombre
        {
            get { return (string)this; }
            //set { this.satelites = value; }
        }
        public override string Orbitar()
        {
            return $"Orbita el satelite: {(string)this}.";
        }
        public override string ToString()
        {
            return base.Mostrar();
        }
    }
}
