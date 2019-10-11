using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(string marca, int capacidad, Tipo tipo, int contenido) 
            : base(marca, capacidad, contenido)
        {
            this.tipo = tipo;
        }
        public Cerveza(string marca, int capacidad, int contenido) 
            : this(marca, capacidad,Tipo.Vidrio, contenido){ }

        #region Metodos
        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            float auxMedida = medida * 0.8f;
            int servido = (auxMedida > this.Contenido) ? this.Contenido : (int)auxMedida;
            this.Contenido -= servido;
            return servido;
        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder(base.GenerarInforme());
            sb.AppendLine($"Medida estandar {MEDIDA}");
            sb.AppendLine($"Tipo {this.tipo}");
            return sb.ToString();
        }
        #endregion

        public static implicit operator Botella.Tipo(Cerveza c)
        {
            return c.tipo;
        }
    }
}
