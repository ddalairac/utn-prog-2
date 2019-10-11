using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua:Botella
    {
        private const int MEDIDA = 400;

        public Agua(string marca, int capacidad, int contenido):base(marca,capacidad,contenido)
        {

        }
        #region Metodos
        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            int servido = (medida > this.Contenido) ? this.Contenido : medida;
            this.Contenido -= servido;
            return servido;
        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder(base.GenerarInforme());
            sb.AppendLine($"Medida estandar {MEDIDA}");
            return sb.ToString();
        }
        #endregion
    }
}
