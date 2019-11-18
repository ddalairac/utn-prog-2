using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    public partial class VistaPatente : UserControl
    {
        public event FinExposicionPatente finExposicion;
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();

                    // Llamar al hilo principal
                    // ALUMNO
                    if (this.InvokeRequired)
                    {
                        MostrarPatente d = new MostrarPatente(this.MostrarPatente);
                        this.Invoke(d, new object[] { patente });
                    }
                    else
                    {
                        if(patente is Patente) { 
                            Patente p = (Patente)patente;
                            this.lblPatenteNro.Text = p.CodigoPatente;
                        }
                    }


                    Thread.Sleep(r.Next(2000, 5000));

                    // Agregar evento de que finalizó la exposición de la patente
                    // ALUMNO
                    finExposicion.Invoke(this);
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }

    }
}
