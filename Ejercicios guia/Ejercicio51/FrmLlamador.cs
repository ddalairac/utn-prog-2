using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio51
{
    public partial class FrmLlamador : Form
    {
        Centralita central;
        Random random;

        #region Init
        public FrmLlamador(Centralita central)
        {
            InitializeComponent();
            this.central = central;
            this.random = new Random();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "";
            this.txtNroDestino.Enabled = false;
            this.cmbFranja.Enabled = false;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            buttonLlamar.Enabled = false;
            buttonLimpiar.Enabled = false;
        }
        #endregion

        #region Input Usuario
        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            this.cmbFranja.Enabled = (txtNroDestino.Text.StartsWith("#")) ? true : false;
        }
        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            this.HabilitarBotonesAccion();
        }
        #endregion

        #region Botones Telefono

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
            this.HabilitarBotonesAccion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
            this.HabilitarBotonesAccion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
            this.HabilitarBotonesAccion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
            this.HabilitarBotonesAccion();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
            this.HabilitarBotonesAccion();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
            this.HabilitarBotonesAccion();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
            this.HabilitarBotonesAccion();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
            this.HabilitarBotonesAccion();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
            this.HabilitarBotonesAccion();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
            this.HabilitarBotonesAccion();
        }

        private void buttonAst_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
            this.HabilitarBotonesAccion();
        }

        private void buttonhass_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
            this.HabilitarBotonesAccion();
        }
        #endregion

        #region Botones Accion
        private void HabilitarBotonesAccion()
        {
            if (this.txtNroDestino.Text != "" && this.txtNroOrigen.Text != "")
            {
                buttonLlamar.Enabled = true;
            }
            if (this.txtNroDestino.Text != "" || this.txtNroOrigen.Text != "")
            {
                buttonLimpiar.Enabled = true;
            }
        }
        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            float duracion = (float)random.Next(1, 50);
            if (this.cmbFranja.Enabled)
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                Provincial llamada = new Provincial(this.txtNroOrigen.Text, franja, duracion, this.txtNroDestino.Text);
                try
                {
                    central = central + llamada;
                }
                catch (CentralitaExcepction exep)
                {
                    MessageBox.Show(exep.Message,"Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                float costo = (float)random.Next(5, 56) / 10;
                Local llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
                central = central + llamada;
            }
            this.txtNroDestino.Text = "";
            this.txtNroOrigen.Text = "";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
