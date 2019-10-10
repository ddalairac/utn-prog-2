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

namespace FormParcial
{
    public partial class Form1 : Form
    {
        private List<Astro> planetas;
        private SistemaSolar sistemaSolar;
        public Form1()
        {
            this.Text = "Dalairac Diego Anibal";
            InitializeComponent();
            this.sistemaSolar = new SistemaSolar();
            //this.planetas = new List<Astro>();
            this.planetas = this.sistemaSolar.Planetas;
            btnAddPlaneta.Enabled = false;
            btnAddSatelite.Enabled = false;
            combTipoPlaneta.DataSource = Enum.GetValues(typeof(Tipo));
            this.listPlanetas.DataSource = new BindingSource(this.sistemaSolar.ListarPlsnetas(), null);
        }

        #region Validaciones
        private void ValidarCamposPlaneta()
        {
            if (txtNombrePlaneta.Text != ""
                 && txtOrbitaPlaneta.Text != ""
                 && numRotacionPlaneta.Value > 0
                 && numLunas.Value > 0
                 && combTipoPlaneta.Text != "")
            {
                int aux;
                if(int.TryParse(txtOrbitaPlaneta.Text, out aux))
                {
                    btnAddPlaneta.Enabled = true;
                } else
                {
                    btnAddPlaneta.Enabled = false;
                    MessageBox.Show("Error, debe ingresar un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnAddPlaneta.Enabled = false;
            }
        }
        private void ValidarCamposSatelite()
        {
            if (txtNombreSatelite.Text != ""
                && txtSateliteDe.Text != ""
                && numOrbitaSatelite.Value > 0
                && numRotacionSatelite.Value > 0)
            {
                btnAddSatelite.Enabled = true;
            }
        }

        #endregion
        #region CamposPlanetas

        private void TxtNombrePlaneta_TextChanged(object sender, EventArgs e)
        {
            this.ValidarCamposPlaneta();
        }

        private void TxtOrbitaPlaneta_TextChanged(object sender, EventArgs e)
        {

            this.ValidarCamposPlaneta();
        }

        private void NumRotacionPlaneta_ValueChanged(object sender, EventArgs e)
        {

            this.ValidarCamposPlaneta();
        }

        private void NumLunas_ValueChanged(object sender, EventArgs e)
        {
            this.ValidarCamposPlaneta();

        }

        private void CombTipoPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.ValidarCamposPlaneta();
        }

        #endregion
        #region CamposSatelite

        

        private void TxtSateliteDe_TextChanged(object sender, EventArgs e)
        {
            this.ValidarCamposSatelite();
        }

        private void TxtNombreSatelite_TextChanged(object sender, EventArgs e)
        {
            this.ValidarCamposSatelite();

        }

        private void NumOrbitaSatelite_ValueChanged(object sender, EventArgs e)
        {
            this.ValidarCamposSatelite();

        }

        private void NumRotacionSatelite_ValueChanged(object sender, EventArgs e)
        {
            this.ValidarCamposSatelite();

        }
        #endregion
        #region Botones

        private void BtnAddPlaneta_Click(object sender, EventArgs e)
        {

            Planeta p = new Planeta(int.Parse(txtOrbitaPlaneta.Text),(int)numRotacionPlaneta.Value, txtNombrePlaneta.Text);
            this.planetas.Add(p);
            this.sistemaSolar.Planetas = this.planetas;
            this.listPlanetas.DataSource = new BindingSource(this.sistemaSolar.ListarPlsnetas(), null);

        }

        private void BtnAddSatelite_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.sistemaSolar.MostrarInformacionAstros(),"Astros", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
