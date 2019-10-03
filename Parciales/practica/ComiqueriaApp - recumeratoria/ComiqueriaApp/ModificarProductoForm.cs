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
    public partial class ModificarProductoForm : Form
    {
        private Producto producto;
        double precio;
        public ModificarProductoForm(Producto producto)
        {
            InitializeComponent();
            this.Text = "Modificar Producto";
            this.producto = producto;
        }

        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = this.producto.Descripcion;
            txtPrecioActual.Text = this.producto.Precio.ToString();
            txtPrecioActual.Enabled = false;
            txtNuevoPrecio.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtNuevoPrecio.Text, out precio))
            {
                this.producto.Precio = precio;
            }
            else
            {
                //MessageBox.Show("Error en precio, debe ingresar un numero valido", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                this.lblError.Text = "Error.Debe ingresar unprecio válido.";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Text = "";
        }
    }
}
