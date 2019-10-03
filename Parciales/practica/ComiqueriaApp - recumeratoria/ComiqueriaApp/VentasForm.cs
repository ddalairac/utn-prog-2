using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComprobantesLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueria;
        Producto producto;
        public VentasForm(Comiqueria comiqueria, Producto producto)
        {
            InitializeComponent();
            this.Text = "Nueva Venta";
            this.comiqueria = comiqueria;
            this.producto = producto;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = this.producto.Descripcion;
            numericUpDownCantidad.Value = 1;
            lblPrecioFinal.Text = this.MostrarPrecio(this.producto.Precio);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {

            if (this.producto.Stock < numericUpDownCantidad.Value)
            {
                MessageBox.Show("Stock superado, ingrese cantidad menor", "Stock superado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                comiqueria.Vender(this.producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = this.MostrarPrecio(this.producto.Precio * (double)numericUpDownCantidad.Value);

        }
        private string MostrarPrecio(double precio)
        {
            return $"Precio final: {precio:#,###.00}"; 
        }
    }
}
