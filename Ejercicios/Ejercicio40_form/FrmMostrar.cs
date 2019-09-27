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
    public partial class FrmMostrar : Form
    {
        Llamada llamada;
        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "Resultado";
        }
    }
}
