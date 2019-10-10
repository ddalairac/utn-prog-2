using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro(int duraOrbita, int duraRotacion, string nombre) {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }
        protected string Mostrar()
        {
            return $"Nombre: {this.nombre} \nÓrbita: {this.duracionOrbita} \nRotación: {this.duracionRotacion}.\n";
        }
        public abstract string Orbitar();
        public virtual string Rotar()
        {
            return $"Rotando. Tiempo estimado: {this.duracionRotacion}.\n";
        }
        public static explicit operator string(Astro a)
        {
            return a.nombre.ToString();
        }
    }
}
