using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }
        Persona persona;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (this.persona is null)
            {
                this.persona = new Persona();
                persona.eventoString += this.NotificarCambio;
                persona.Nombre = textNombre.Text;
                persona.Apellido = textApellido.Text;
            }
        }
        public void NotificarCambio(string msj)
        {
            MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
