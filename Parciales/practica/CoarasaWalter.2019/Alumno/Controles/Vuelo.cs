using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Controles
{
    public partial class Vuelo : UserControl, IAvion
    {
        Avion avion;
        public Vuelo(int horasVuelo)
        {
            InitializeComponent();
            avion = new Avion(horasVuelo);
            try
            {
                avion.GuardarSql("dbo.Bitacora", horasVuelo);
                avion.reporteDeEstado += this.MoverAvion;
            }
            catch (Exception e)
            {
                // aca iria un evento que disparar un modal
            }
            try
            {
                avion.GuardarTxt("Bitacora.txt", horasVuelo);
                avion.reporteDeEstado += this.MoverAvion;
            }
            catch (Exception e)
            {
                // aca iria un evento que disparar un modal
            }

        }
        //private EstadoVuelo estado;

        public Avion.EstadoVuelo Estado
        {
            get { return avion.Estado; }
        }
        public void Despegar()
        {
            picAvion.Visible = true;
            IAvion a = avion;
            a.Despegar();
        }
        public void Estrellar()
        {
            IAvion a = avion;
            a.Estrellar();
        }


        public int MoverAvion(int horasTotales, int horasRestantes)
        {            
            if (this.picAvion.InvokeRequired)
            {
                ReporteDeEstado d = new ReporteDeEstado(this.MoverAvion);
                return (int) this.Invoke(d, new object[] { horasTotales, horasRestantes });
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);
                return porcentajeCompletado;
            }
        }
    }
}
