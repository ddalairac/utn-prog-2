using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{

    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(Object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;


        public Paquete(string direccionEntrega, string trakingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trakingID;
            this.estado = EEstado.Ingresado;
        }

        #region Propiedades
        /// <summary>
        /// GET/SET de la direccion de entrega
        /// </summary>
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }
        /// <summary>
        /// GET/SET del estado
        /// </summary>
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        /// <summary>
        /// GET/SET del Tracking ID
        /// </summary>
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Simula el proceso de envio del paquete, dejando un delay de 4 segundos en cada etapa.
        /// Al finalizar la simulacion guarda el paquete en la DB.
        /// </summary>
        public void MockCicloDeVida()
        {
            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.estado++;
                this.InformaEstado.Invoke(this, new EventArgs());
            }
            try            {

                PaqueteDao.Insertar(this);
            }
            catch (InsertarEnDBExcepcion e)
            {
                MessageBox.Show(e.Message, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Retorna un string con los datos del paquetes recibido como parametro.
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return String.Format("{0} para {1}", p.TrackingID, p.direccionEntrega);
        }
        /// <summary>
        /// Retorna un string con los datos del paquetes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un paquete sera igual a otro si tiene el mismo trackingID.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1.trackingID == p2.trackingID;
        }
        /// <summary>
        /// Un paquete sera diferente a otro si su trackingID es diferente.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion

        /// <summary>
        /// Enum de los estados posibles de un paquete.
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
