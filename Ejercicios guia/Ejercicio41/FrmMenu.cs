using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio41
{
    public partial class FrmMenu : Form
    {

        Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
            this.Text = "Central Telefonica";
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//no resize
            //this.CenterToScreen();
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.central = new Centralita("Saltamonte");

            Local l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Local l1b = l1;
            Provincial l2 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            Local l3 = new Local("6785678", 40, "6345346", (float)2.65);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            try
            {
                this.central = central + l1;
                this.central = central + l1b;
                this.central = central + l2;
                this.central = central + l3;
                this.central = central + l4;
            }

            catch (CentralitaExcepction exep)
            {
                MessageBox.Show(exep.Message,"Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            FrmLlamador formLlamador = new FrmLlamador(this.central);
            formLlamador.ShowDialog();
        }

        private void buttonFacTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void buttonFacLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = Llamada.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void buttonFacProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = Llamada.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
