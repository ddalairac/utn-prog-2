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

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculadora de Diego Dalairac del curso 2C";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Crea 2 instancias de la clase Numero en los atributos num1 y num2.
        /// Llama al metodo Limpiar de la clase FormCalculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label de la pantalla.
        /// Habilita los botones btnConvertirADecimal y btnConvertirABinario.
        /// </summary>
        public void Limpiar()
        {
            textNumero1.Text = "";
            textNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Recibe dos números y un operador para luego llamar al método Operar de Calculadora. El valor retornado es el resultado del cálculo
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado del Calculo</returns>
        public static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        /// <summary>
        /// Setea los valores ingresados en textNumero1 y textNumero2 en las instancias de la clase Numero num1 y num 2
        /// Llama al método operar de la clase FormCalculadora y carga el retorno del mismo en el label lblResultado.
        /// Habilita el botón btnConvertirABinario.
        /// Deshabilita el botón btnConvertirADecimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(textNumero1.Text, textNumero2.Text, cmbOperador.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Cierra la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Llama al método DecimalBinario de la clase Numero y carga el retorno del mismo en el label lblResultado.
        /// Si el método retorna un valor válido, se deshabilita el botón btnConvertirADecimal.
        /// Deshabilita el botón btnConvertirABinario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            btnConvertirADecimal.Enabled = lblResultado.Text != "Valor invalido" ? true : false;
            btnConvertirABinario.Enabled = false;
        }
        /// <summary>
        /// Llama al método BinarioDecimal de la clase Numero y carga el retorno del mismo en el label lblResultado.
        /// Si el métoto retorna un valor válido, se deshabilita el botón btnConvertirABinario.
        /// Deshabilita el botón btnConvertirADecimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = lblResultado.Text != "Valor invalido" ? true : false;
        }

        /// <summary>
        /// Llama al método limpiar de la clase FormCalculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}
