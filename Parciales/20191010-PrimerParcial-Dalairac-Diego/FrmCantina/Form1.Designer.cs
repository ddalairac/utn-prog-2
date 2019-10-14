namespace FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.radioCerveza = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barra = new ControlCantina.Barra();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnAgregar);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.comboTipo);
            this.groupBox.Controls.Add(this.numContenido);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.numCapacidad);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtMarca);
            this.groupBox.Controls.Add(this.labelMarca);
            this.groupBox.Controls.Add(this.radioAgua);
            this.groupBox.Controls.Add(this.radioCerveza);
            this.groupBox.Location = new System.Drawing.Point(12, 386);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(551, 147);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(347, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Botella tipo";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(347, 38);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(219, 91);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(100, 20);
            this.numContenido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contenido";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(109, 91);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(100, 20);
            this.numCapacidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capacidad";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(109, 40);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(106, 23);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca";
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(16, 55);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 1;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // radioCerveza
            // 
            this.radioCerveza.AutoSize = true;
            this.radioCerveza.Location = new System.Drawing.Point(16, 32);
            this.radioCerveza.Name = "radioCerveza";
            this.radioCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioCerveza.TabIndex = 0;
            this.radioCerveza.TabStop = true;
            this.radioCerveza.Text = "Cerveza";
            this.radioCerveza.UseVisualStyleBackColor = true;
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(12, 12);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(551, 368);
            this.barra.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 543);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioAgua;
        private System.Windows.Forms.RadioButton radioCerveza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlCantina.Barra barra;
    }
}

