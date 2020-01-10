using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public Correo() {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #region Propiedades
        /// <summary>
        /// GET/SET de la lista de paquetes del correo
        /// </summary>
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// finaliza todos los hilos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                if (item != null && item.IsAlive) item.Abort();
            }
        }
        /// <summary>
        /// Retorna un string con la lista de paquetes del correo recibido como parametro
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string rta = "";
            Correo c = (Correo)elementos;
            foreach (Paquete item in c.Paquetes)
            {
                rta += String.Format("{0} para {1} ({2})\n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString());
            }
            return rta;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Si el paquete no esta en la lista del correo, lo agrega a la misma e inicializa la simulacion del paquete en un hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.Paquetes)
            {
                if(item == p)
                {
                    throw new TrackingIdRepetidoException($"El tracking id {p.TrackingID} ya figura en la lista de envios");
                }
            }
            c.paquetes.Add(p);
            Thread t = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(t);
            t.Start();

            return c;
        }
        #endregion
    }
}
