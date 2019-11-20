using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{

    public class Planeta<T> : Astro, IAstro where T : Astro, IAstro 
    {
        private int cantAstros;
        private Tipo tipo;
        private List<T> satelites;

        public Planeta(int durOrb, int duraRot, string nmbr)
            : base(durOrb, duraRot, nmbr)
        {
            this.satelites = new List<T>();
        }

        public Planeta(int durOrb, int durRot, string nmbr, int cantAstr, Tipo tipo)
            : this(durOrb, durRot, nmbr)
        {
            this.cantAstros = cantAstr;
            this.tipo = tipo;
        }

        #region Propiedades

        public List<T> Satelites
        {
            get
            {
                return this.satelites;
            }

            set
            {
                this.satelites = value;
            }
        }

        public int CantAstros
        {
            get
            {
                return this.cantAstros;
            }
            set
            {
                this.cantAstros = value;
            }
        }

        public Tipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Metodos

        public string Orbitar()
        {
            return $"Termino de orbitar el planeta {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Termino de rotar el planeta {this.Nombre}";
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Planeta");
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Tipo: {tipo}");
            retorno.AppendLine($"Cantidad de Satelites {cantAstros}");

            foreach (T satelite in this.satelites)
            {
                retorno.AppendLine(satelite.ToString());
            }

            return retorno.ToString();
        }

        public void RunEvntOrb()
        {

            while (this.duraOrbita != 0)
            {
                Thread.Sleep(1000);
                this.duraOrbita--;
            }
            base.InvocarEvento(this.Orbitar());
        }

        public void RunEvntRotar()
        {

            while (this.duracionRotacion != 0)
            {
                Thread.Sleep(3000);
                this.duracionRotacion--;
            }
            base.InvocarEvento(this.Rotar());

        }
        #endregion
        
        #region Operadores
        public static Planeta<T> operator +(Planeta<T> planeta, T astro)
        {
            

            foreach (T item in planeta.satelites)
            {
                if (item.Nombre == astro.Nombre) throw new SateliteException();
            }
            planeta.satelites.Add(astro);
            return planeta;
            
        }

        public static bool operator ==(Planeta<T> planeta, T satelite)
        {
            
            foreach (T astro in planeta.satelites)
            {
                if (astro.Nombre == astro.Nombre)
                {
                    return false;
                }
            }

            return false;
        }

        public static bool operator !=(Planeta<T> planeta, T astro)
        {
            return !(planeta == astro);
        }
        #endregion


    }
}
