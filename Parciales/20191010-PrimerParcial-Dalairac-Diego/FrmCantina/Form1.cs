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

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        //Cantina barraInstance;
        public Form1()
        {
            InitializeComponent();
            //this.barraInstance = Cantina.GetCantina(10);
            this.barra.SetCantina = Cantina.GetCantina(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.numCapacidad.Text = "10000";
            this.numContenido.Text = "10000";
            comboTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;

            string marca = txtMarca.Text;
            int contenido = (int)numContenido.Value;
            int capacidad = (int)numCapacidad.Value;

            if (radioCerveza.Checked == true)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(comboTipo.SelectedValue.ToString(), out tipo);
                botella = new Cerveza(marca, capacidad, tipo, contenido);
                this.barra.AgregarBotella(botella);
                //this.ModalMsj(botella);
                //this.barra.DibujarBotellas();
            }
            if (radioAgua.Checked == true)
            {
                botella = new Agua(marca, capacidad, contenido);
                this.barra.AgregarBotella(botella);
                //this.ModalMsj(botella);
                //this.barra.DibujarBotellas();
            }
            

        }
        //private void ModalMsj(Botella botella)
        //{
        //    MessageBox.Show(
        //    botella.ToString(),
        //    "datos botella agregada",
        //    MessageBoxButtons.OK,
        //    MessageBoxIcon.Information);
        //}
    }
}
