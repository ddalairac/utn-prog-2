using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
   
    public class Avion : IAvion
    {
        public event ReporteDeEstado reporteDeEstado;

        private int horasVuelo;
        private Thread vuelo;

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        #region Propiedades
        public Thread Vuelo
        {
            get { return this.vuelo; }
            set { this.vuelo = value; }
        }
        public EstadoVuelo Estado
        {
            get
            {
                if (this.Vuelo.ThreadState == ThreadState.Aborted) return EstadoVuelo.Atrerrizado;
                if (this.Vuelo.IsAlive) return EstadoVuelo.Volando;
                return Avion.EstadoVuelo.Programado;
            }
        }

        public int HorasDeVuelo
        {
            get {
                return this.horasVuelo;
            }
        }

        #endregion

        #region Metodos

        public void Volar()
        {
            int horasRestantes = this.horasVuelo;

            while (this.horasVuelo > 0)
            {
                Thread.Sleep(1000);
                this.horasVuelo--;
                reporteDeEstado.Invoke(horasRestantes, this.horasVuelo);
            }
            this.Vuelo.Abort();
        }

        void IAvion.Despegar()
        {
            this.Vuelo = new Thread(Volar);
            this.Vuelo.Start();
            
        }

        void IAvion.Estrellar()
        {
            if (Vuelo.IsAlive)
            {
                Vuelo.Abort();
            }
        }
        #endregion
        public enum EstadoVuelo
        {
            Programado,
            Volando,
            Atrerrizado
        }

    }
}
