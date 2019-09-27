using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40;

namespace Ejercicio40_form
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
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            FrmLlamador FormLlamador = new FrmLlamador(this.central);
            FormLlamador.ShowDialog();
        }

        private void buttonFacTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonFacLocal_Click(object sender, EventArgs e)
        {

        }

        private void buttonFacProvincial_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
