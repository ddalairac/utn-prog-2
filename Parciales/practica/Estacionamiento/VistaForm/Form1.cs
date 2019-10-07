using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Crear PickUp";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PickUp p = new PickUp(this.textPatente.Text,this.textModelo.Text);
            var result = MessageBox.Show($"Se ha creado una nueva PickUp\n{p.ConsultarDatos()}", "Nueva PickUp",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void EnableButton()
        {
            if (this.textPatente.Text.Length == 6 && this.textModelo.Text != "")
            {
                this.button1.Enabled = true;
            }
        }
        private void TextPatente_TextChanged(object sender, EventArgs e)
        {
            this.EnableButton();
        }

        private void TextModelo_TextChanged(object sender, EventArgs e)
        {

            this.EnableButton();
        }
    }
}
