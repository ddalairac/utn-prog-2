namespace FormParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.numRotacionPlaneta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.numLunas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combTipoPlaneta = new System.Windows.Forms.ComboBox();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSateliteDe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPlaneta = new System.Windows.Forms.Button();
            this.btnAddSatelite = new System.Windows.Forms.Button();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.listPlanetas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo de completar rotacion";
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(165, 49);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(120, 20);
            this.txtOrbitaPlaneta.TabIndex = 2;
            this.txtOrbitaPlaneta.TextChanged += new System.EventHandler(this.TxtOrbitaPlaneta_TextChanged);
            // 
            // numRotacionPlaneta
            // 
            this.numRotacionPlaneta.Location = new System.Drawing.Point(165, 77);
            this.numRotacionPlaneta.Name = "numRotacionPlaneta";
            this.numRotacionPlaneta.Size = new System.Drawing.Size(120, 20);
            this.numRotacionPlaneta.TabIndex = 3;
            this.numRotacionPlaneta.ValueChanged += new System.EventHandler(this.NumRotacionPlaneta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre planeta";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(165, 21);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(120, 20);
            this.txtNombrePlaneta.TabIndex = 1;
            this.txtNombrePlaneta.TextChanged += new System.EventHandler(this.TxtNombrePlaneta_TextChanged);
            // 
            // numLunas
            // 
            this.numLunas.Location = new System.Drawing.Point(165, 106);
            this.numLunas.Name = "numLunas";
            this.numLunas.Size = new System.Drawing.Size(120, 20);
            this.numLunas.TabIndex = 4;
            this.numLunas.ValueChanged += new System.EventHandler(this.NumLunas_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de planeta";
            // 
            // combTipoPlaneta
            // 
            this.combTipoPlaneta.FormattingEnabled = true;
            this.combTipoPlaneta.Location = new System.Drawing.Point(165, 136);
            this.combTipoPlaneta.Name = "combTipoPlaneta";
            this.combTipoPlaneta.Size = new System.Drawing.Size(121, 21);
            this.combTipoPlaneta.TabIndex = 5;
            this.combTipoPlaneta.SelectedIndexChanged += new System.EventHandler(this.CombTipoPlaneta_SelectedIndexChanged);
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(454, 110);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(120, 20);
            this.numRotacionSatelite.TabIndex = 10;
            this.numRotacionSatelite.ValueChanged += new System.EventHandler(this.NumRotacionSatelite_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tiempo de completar rotacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Planeta";
            // 
            // txtSateliteDe
            // 
            this.txtSateliteDe.Location = new System.Drawing.Point(454, 25);
            this.txtSateliteDe.Name = "txtSateliteDe";
            this.txtSateliteDe.Size = new System.Drawing.Size(120, 20);
            this.txtSateliteDe.TabIndex = 7;
            this.txtSateliteDe.TextChanged += new System.EventHandler(this.TxtSateliteDe_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre satelite";
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(454, 81);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(120, 20);
            this.numOrbitaSatelite.TabIndex = 9;
            this.numOrbitaSatelite.ValueChanged += new System.EventHandler(this.NumOrbitaSatelite_ValueChanged);
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(454, 53);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(120, 20);
            this.txtNombreSatelite.TabIndex = 8;
            this.txtNombreSatelite.TextChanged += new System.EventHandler(this.TxtNombreSatelite_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tiempo de completar la orbita";
            // 
            // btnAddPlaneta
            // 
            this.btnAddPlaneta.Location = new System.Drawing.Point(15, 173);
            this.btnAddPlaneta.Name = "btnAddPlaneta";
            this.btnAddPlaneta.Size = new System.Drawing.Size(270, 35);
            this.btnAddPlaneta.TabIndex = 6;
            this.btnAddPlaneta.Text = "Agregar planeta";
            this.btnAddPlaneta.UseVisualStyleBackColor = true;
            this.btnAddPlaneta.Click += new System.EventHandler(this.BtnAddPlaneta_Click);
            // 
            // btnAddSatelite
            // 
            this.btnAddSatelite.Location = new System.Drawing.Point(304, 173);
            this.btnAddSatelite.Name = "btnAddSatelite";
            this.btnAddSatelite.Size = new System.Drawing.Size(270, 35);
            this.btnAddSatelite.TabIndex = 11;
            this.btnAddSatelite.Text = "Agregar satelite";
            this.btnAddSatelite.UseVisualStyleBackColor = true;
            this.btnAddSatelite.Click += new System.EventHandler(this.BtnAddSatelite_Click);
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(16, 214);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(558, 35);
            this.btnMostrarInfo.TabIndex = 12;
            this.btnMostrarInfo.Text = "Mostrar informacion";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.BtnMostrarInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(16, 255);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(558, 35);
            this.btnMoverAstros.TabIndex = 13;
            this.btnMoverAstros.Text = "Mover astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.BtnMoverAstros_Click);
            // 
            // listPlanetas
            // 
            this.listPlanetas.FormattingEnabled = true;
            this.listPlanetas.Location = new System.Drawing.Point(590, 24);
            this.listPlanetas.Name = "listPlanetas";
            this.listPlanetas.Size = new System.Drawing.Size(120, 264);
            this.listPlanetas.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 308);
            this.Controls.Add(this.listPlanetas);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.btnAddSatelite);
            this.Controls.Add(this.btnAddPlaneta);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSateliteDe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combTipoPlaneta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numLunas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRotacionPlaneta);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.NumericUpDown numRotacionPlaneta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.NumericUpDown numLunas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combTipoPlaneta;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSateliteDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPlaneta;
        private System.Windows.Forms.Button btnAddSatelite;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.ListBox listPlanetas;
    }
}

