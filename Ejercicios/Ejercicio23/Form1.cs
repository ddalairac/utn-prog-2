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
        private bool lockImg;
        Dolar dolar;
        Euro euro;
        Peso peso;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lockImg = true;
            dolar = new Dolar();
            euro = new Euro(6);
            peso = new Peso();

            inDolar.Text = dolar.GetCantidad().ToString();
            inEuro.Text = euro.GetCantidad().ToString();
            inPeso.Text = peso.GetCantidad().ToString();

            inCambioDolar.Text = Dolar.cotizRespectoDolar.ToString();
            inCambioEuro.Text = Euro.cotizRespectoDolar.ToString();
            inCambioPeso.Text = Peso.cotizRespectoDolar.ToString();
        }

        private void inEuro_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(inEuro.Text, out aux);
            euro = new Euro(aux);
        }
        private void inDolar_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(inDolar.Text, out aux);
            dolar = new Dolar(aux);
        }
        private void inPeso_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(inPeso.Text, out aux);
            peso = new Peso(aux);
        }
        private void buttonEuro_Click(object sender, EventArgs e)
        {
            outEu2Eu.Text = euro.GetCantidad().ToString();
            outEu2Do.Text = euro.GetCotizacion().ToString();
            outEu2Pe.Text = ((Peso)euro).GetCantidad().ToString();
        }
        private void buttonDolar_Click(object sender, EventArgs e)
        {
            outDo2Do.Text = dolar.GetCantidad().ToString();
            //outDo2Eu.Text = dolar.ToEuro().ToString();
            //outDo2Pe.Text = dolar.ToPeso().ToString();
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

        private void inCambioDolar_TextChanged(object sender, EventArgs e)
        {

        }
        private void inCambioPeso_TextChanged(object sender, EventArgs e)
        {

        }
        private void inCambioEuro_TextChanged(object sender, EventArgs e)
        {

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
