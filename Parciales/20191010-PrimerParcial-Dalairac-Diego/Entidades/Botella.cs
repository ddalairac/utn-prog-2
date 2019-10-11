using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        private int capacidadML;
        private int contenidoML;
        private string marca;
        protected Botella(string marca, int capacidad, int contenido)
        {
            if (capacidad < contenido)
            {
                this.contenidoML = capacidad;
            }
            else
            {
                this.contenidoML = contenido;
            }
            this.capacidadML = capacidad;
            this.marca = marca;
        }
        #region propiedades

        /// <summary>
        /// Retorna la capacidad de la botella en litros
        /// </summary>
        public int CapacidadLitros
        {
            get { return this.capacidadML / 1000; }
        }

        /// <summary>
        /// Retorna el contenido en mililitros
        /// </summary>
        public int Contenido
        {
            get { return this.contenidoML; }
            set { this.contenidoML = value; }
        }

        /// <summary>
        /// Retorna el porcentaje de contenido
        /// </summary>
        public float PorcentajeContenido
        {
            get { return this.contenidoML * 100 / this.capacidadML; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// retorna los datos de la botella
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca {this.marca}");
            sb.AppendLine($"Capacidad {this.capacidadML}");
            sb.AppendLine($"Contenido {this.contenidoML}");
            return sb.ToString();
        }
        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion

        public enum Tipo
        {
            Plastico, Vidrio
        }
    }
}
