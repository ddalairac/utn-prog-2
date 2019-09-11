using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            inDolar.Text = dolar.GetCotizacion().ToString();
            inEuro.Text = euro.GetCotizacion().ToString();
            inPeso.Text = peso.GetCotizacion().ToString();
            inCambioDolar.Text = Dolar.cotizRespectoDolar.ToString();
            inCambioEuro.Text = Euro.cotizRespectoDolar.ToString();
            inCambioPeso.Text = Peso.cotizRespectoDolar.ToString();
        }


        private bool lockImg = true;
        Dolar dolar = new Dolar();
        Euro euro = new Euro();
        Peso peso = new Peso();



        private void inEuro_TextChanged(object sender, EventArgs e)
        {

        }
        private void inDolar_TextChanged(object sender, EventArgs e)
        {

        }
        private void inPeso_TextChanged(object sender, EventArgs e)
        {

        }
        private void inCambioDolar_TextChanged(object sender, EventArgs e)
        {

        }
        private void inCambioPeso_TextChanged(object sender, EventArgs e)
        {

        }
        private void inCambioEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {

        }
        private void buttonDolar_Click(object sender, EventArgs e)
        {

        }
        private void buttonPeso_Click(object sender, EventArgs e)
        {

        }
        private void buttonLock_Click(object sender, EventArgs e)
        {
            if(lockImg == true)
            {
                inCambioEuro.ReadOnly = true;
                inCambioDolar.ReadOnly = true;
                inCambioPeso.ReadOnly = true;
                lockImg = false;
            }
            else
            {
                inCambioEuro.ReadOnly = false;
                inCambioDolar.ReadOnly = false;
                inCambioPeso.ReadOnly = false;
                lockImg = true;
            }
        }

        private void outEu2Eu_TextChanged(object sender, EventArgs e)
        {

        }
        private void outEu2Do_TextChanged(object sender, EventArgs e)
        {

        }
        private void outEu2Pe_TextChanged(object sender, EventArgs e)
        {

        }
        private void outDo2Eu_TextChanged(object sender, EventArgs e)
        {

        }
        private void outDo2Do_TextChanged(object sender, EventArgs e)
        {

        }
        private void outDo2Pe_TextChanged(object sender, EventArgs e)
        {

        }
        private void outPe2Eu_TextChanged(object sender, EventArgs e)
        {

        }
        private void outPe2Pe_TextChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {



        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        





    }
}
