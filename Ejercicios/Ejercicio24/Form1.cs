using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio21;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        Fahrenheit fa;
        Celsius ce;
        Kelvin ke;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fa = new Fahrenheit(0);
            ce = new Celsius(0);
            ke = new Kelvin(0);
            inFahrenheit.Text = fa.value.ToString();
            inCelsius.Text = ce.value.ToString();
            inKelvin.Text = ke.value.ToString();
        }

        private void inFahrenheit_TextChanged(object sender, EventArgs e)
        {
            int.TryParse( inFahrenheit.Text, out fa.value);
        }
        private void inCelsius_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(inCelsius.Text, out ce.value);
        }
        private void inKelvin_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(inKelvin.Text, out ke.value);
        }

        private void buttonConvFa_Click(object sender, EventArgs e)
        {
            textF2F.Text = fa.value.ToString();
            textF2C.Text = fa.ToCelcius().ToString();
            textF2K.Text = fa.ToKelvin().ToString();
        }

        private void buttonConvCe_Click(object sender, EventArgs e)
        {
            textC2C.Text = ce.value.ToString();
            textC2F.Text = ce.ToFahrenheit().ToString();
            textC2K.Text = ce.ToKelvin().ToString();
        }

        private void buttonConvKe_Click(object sender, EventArgs e)
        {
            textK2K.Text = ke.value.ToString();
            textK2F.Text = ke.ToFahrenheit().ToString();
            textK2C.Text = ke.ToCelcius().ToString();
        }


    }
}
