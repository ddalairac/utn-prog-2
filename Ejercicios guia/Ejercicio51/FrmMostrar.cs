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
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipo;
        Centralita central;
        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
            this.central = central;
            this.tipo = Llamada.TipoLlamada.Todas;
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "\n\t::::::::::::::::::::::::::::::::::::::: FACTURACION :::::::::::::::::::::::::::::::::::::::\n\n";
            richTextBox.Text += this.central.Mostrar(this.tipo);
            richTextBox.Enabled = false;
        }

        public Llamada.TipoLlamada Tipo {
            set { this.tipo = value; }
        }
    }
}
