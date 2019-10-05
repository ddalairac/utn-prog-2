namespace Ejercicio23
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
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.buttonEuro = new System.Windows.Forms.Button();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.inEuro = new System.Windows.Forms.TextBox();
            this.inDolar = new System.Windows.Forms.TextBox();
            this.inPeso = new System.Windows.Forms.TextBox();
            this.buttonDolar = new System.Windows.Forms.Button();
            this.buttonPeso = new System.Windows.Forms.Button();
            this.inCambioDolar = new System.Windows.Forms.TextBox();
            this.inCambioPeso = new System.Windows.Forms.TextBox();
            this.outEu2Eu = new System.Windows.Forms.TextBox();
            this.outEu2Do = new System.Windows.Forms.TextBox();
            this.outEu2Pe = new System.Windows.Forms.TextBox();
            this.outDo2Pe = new System.Windows.Forms.TextBox();
            this.outDo2Do = new System.Windows.Forms.TextBox();
            this.outDo2Eu = new System.Windows.Forms.TextBox();
            this.outPe2Pe = new System.Windows.Forms.TextBox();
            this.outPe2Do = new System.Windows.Forms.TextBox();
            this.outPe2Eu = new System.Windows.Forms.TextBox();
            this.labelEuro2 = new System.Windows.Forms.Label();
            this.labelDolar2 = new System.Windows.Forms.Label();
            this.labelPeso2 = new System.Windows.Forms.Label();
            this.inCambioEuro = new System.Windows.Forms.TextBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Location = new System.Drawing.Point(97, 35);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(56, 13);
            this.labelCotizacion.TabIndex = 0;
            this.labelCotizacion.Text = "Cotizacion";
            // 
            // buttonEuro
            // 
            this.buttonEuro.Location = new System.Drawing.Point(179, 99);
            this.buttonEuro.Name = "buttonEuro";
            this.buttonEuro.Size = new System.Drawing.Size(75, 23);
            this.buttonEuro.TabIndex = 2;
            this.buttonEuro.Text = "->";
            this.buttonEuro.UseVisualStyleBackColor = true;
            this.buttonEuro.Click += new System.EventHandler(this.buttonEuro_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(12, 104);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(29, 13);
            this.labelEuro.TabIndex = 5;
            this.labelEuro.Text = "Euro";
            this.labelEuro.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Location = new System.Drawing.Point(12, 147);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(32, 13);
            this.labelDolar.TabIndex = 6;
            this.labelDolar.Text = "Dolar";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(12, 188);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(31, 13);
            this.labelPeso.TabIndex = 7;
            this.labelPeso.Text = "Peso";
            // 
            // inEuro
            // 
            this.inEuro.Location = new System.Drawing.Point(73, 101);
            this.inEuro.Name = "inEuro";
            this.inEuro.Size = new System.Drawing.Size(100, 20);
            this.inEuro.TabIndex = 8;
            this.inEuro.TextChanged += new System.EventHandler(this.inEuro_TextChanged);
            // 
            // inDolar
            // 
            this.inDolar.Location = new System.Drawing.Point(73, 144);
            this.inDolar.Name = "inDolar";
            this.inDolar.Size = new System.Drawing.Size(100, 20);
            this.inDolar.TabIndex = 9;
            this.inDolar.TextChanged += new System.EventHandler(this.inDolar_TextChanged);
            // 
            // inPeso
            // 
            this.inPeso.Location = new System.Drawing.Point(73, 185);
            this.inPeso.Name = "inPeso";
            this.inPeso.Size = new System.Drawing.Size(100, 20);
            this.inPeso.TabIndex = 10;
            this.inPeso.TextChanged += new System.EventHandler(this.inPeso_TextChanged);
            // 
            // buttonDolar
            // 
            this.buttonDolar.Location = new System.Drawing.Point(179, 142);
            this.buttonDolar.Name = "buttonDolar";
            this.buttonDolar.Size = new System.Drawing.Size(75, 23);
            this.buttonDolar.TabIndex = 11;
            this.buttonDolar.Text = "->";
            this.buttonDolar.UseVisualStyleBackColor = true;
            this.buttonDolar.Click += new System.EventHandler(this.buttonDolar_Click);
            // 
            // buttonPeso
            // 
            this.buttonPeso.Location = new System.Drawing.Point(179, 184);
            this.buttonPeso.Name = "buttonPeso";
            this.buttonPeso.Size = new System.Drawing.Size(75, 23);
            this.buttonPeso.TabIndex = 12;
            this.buttonPeso.Text = "->";
            this.buttonPeso.UseVisualStyleBackColor = true;
            this.buttonPeso.Click += new System.EventHandler(this.buttonPeso_Click);
            // 
            // inCambioDolar
            // 
            this.inCambioDolar.Location = new System.Drawing.Point(382, 37);
            this.inCambioDolar.Name = "inCambioDolar";
            this.inCambioDolar.Size = new System.Drawing.Size(100, 20);
            this.inCambioDolar.TabIndex = 14;
            this.inCambioDolar.TextChanged += new System.EventHandler(this.inCambioDolar_TextChanged);
            // 
            // inCambioPeso
            // 
            this.inCambioPeso.Location = new System.Drawing.Point(503, 37);
            this.inCambioPeso.Name = "inCambioPeso";
            this.inCambioPeso.Size = new System.Drawing.Size(100, 20);
            this.inCambioPeso.TabIndex = 15;
            this.inCambioPeso.TextChanged += new System.EventHandler(this.inCambioPeso_TextChanged);
            // 
            // outEu2Eu
            // 
            this.outEu2Eu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outEu2Eu.Enabled = false;
            this.outEu2Eu.Location = new System.Drawing.Point(260, 99);
            this.outEu2Eu.Name = "outEu2Eu";
            this.outEu2Eu.Size = new System.Drawing.Size(100, 20);
            this.outEu2Eu.TabIndex = 16;
            this.outEu2Eu.TextChanged += new System.EventHandler(this.outEu2Eu_TextChanged);
            // 
            // outEu2Do
            // 
            this.outEu2Do.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outEu2Do.Enabled = false;
            this.outEu2Do.Location = new System.Drawing.Point(382, 99);
            this.outEu2Do.Name = "outEu2Do";
            this.outEu2Do.Size = new System.Drawing.Size(100, 20);
            this.outEu2Do.TabIndex = 17;
            this.outEu2Do.TextChanged += new System.EventHandler(this.outEu2Do_TextChanged);
            // 
            // outEu2Pe
            // 
            this.outEu2Pe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outEu2Pe.Enabled = false;
            this.outEu2Pe.Location = new System.Drawing.Point(503, 99);
            this.outEu2Pe.Name = "outEu2Pe";
            this.outEu2Pe.Size = new System.Drawing.Size(100, 20);
            this.outEu2Pe.TabIndex = 18;
            this.outEu2Pe.TextChanged += new System.EventHandler(this.outEu2Pe_TextChanged);
            // 
            // outDo2Pe
            // 
            this.outDo2Pe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outDo2Pe.Enabled = false;
            this.outDo2Pe.Location = new System.Drawing.Point(503, 144);
            this.outDo2Pe.Name = "outDo2Pe";
            this.outDo2Pe.Size = new System.Drawing.Size(100, 20);
            this.outDo2Pe.TabIndex = 21;
            this.outDo2Pe.TextChanged += new System.EventHandler(this.outDo2Pe_TextChanged);
            // 
            // outDo2Do
            // 
            this.outDo2Do.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outDo2Do.Enabled = false;
            this.outDo2Do.Location = new System.Drawing.Point(382, 144);
            this.outDo2Do.Name = "outDo2Do";
            this.outDo2Do.Size = new System.Drawing.Size(100, 20);
            this.outDo2Do.TabIndex = 20;
            this.outDo2Do.TextChanged += new System.EventHandler(this.outDo2Do_TextChanged);
            // 
            // outDo2Eu
            // 
            this.outDo2Eu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outDo2Eu.Enabled = false;
            this.outDo2Eu.Location = new System.Drawing.Point(260, 144);
            this.outDo2Eu.Name = "outDo2Eu";
            this.outDo2Eu.Size = new System.Drawing.Size(100, 20);
            this.outDo2Eu.TabIndex = 19;
            this.outDo2Eu.TextChanged += new System.EventHandler(this.outDo2Eu_TextChanged);
            // 
            // outPe2Pe
            // 
            this.outPe2Pe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outPe2Pe.Enabled = false;
            this.outPe2Pe.Location = new System.Drawing.Point(503, 187);
            this.outPe2Pe.Name = "outPe2Pe";
            this.outPe2Pe.Size = new System.Drawing.Size(100, 20);
            this.outPe2Pe.TabIndex = 24;
            this.outPe2Pe.TextChanged += new System.EventHandler(this.outPe2Pe_TextChanged);
            // 
            // outPe2Do
            // 
            this.outPe2Do.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outPe2Do.Enabled = false;
            this.outPe2Do.Location = new System.Drawing.Point(382, 187);
            this.outPe2Do.Name = "outPe2Do";
            this.outPe2Do.Size = new System.Drawing.Size(100, 20);
            this.outPe2Do.TabIndex = 23;
            // 
            // outPe2Eu
            // 
            this.outPe2Eu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outPe2Eu.Enabled = false;
            this.outPe2Eu.Location = new System.Drawing.Point(260, 187);
            this.outPe2Eu.Name = "outPe2Eu";
            this.outPe2Eu.Size = new System.Drawing.Size(100, 20);
            this.outPe2Eu.TabIndex = 22;
            this.outPe2Eu.TextChanged += new System.EventHandler(this.outPe2Eu_TextChanged);
            // 
            // labelEuro2
            // 
            this.labelEuro2.AutoSize = true;
            this.labelEuro2.Location = new System.Drawing.Point(257, 72);
            this.labelEuro2.Name = "labelEuro2";
            this.labelEuro2.Size = new System.Drawing.Size(29, 13);
            this.labelEuro2.TabIndex = 25;
            this.labelEuro2.Text = "Euro";
            // 
            // labelDolar2
            // 
            this.labelDolar2.AutoSize = true;
            this.labelDolar2.Location = new System.Drawing.Point(379, 72);
            this.labelDolar2.Name = "labelDolar2";
            this.labelDolar2.Size = new System.Drawing.Size(32, 13);
            this.labelDolar2.TabIndex = 26;
            this.labelDolar2.Text = "Dolar";
            // 
            // labelPeso2
            // 
            this.labelPeso2.AutoSize = true;
            this.labelPeso2.Location = new System.Drawing.Point(500, 72);
            this.labelPeso2.Name = "labelPeso2";
            this.labelPeso2.Size = new System.Drawing.Size(31, 13);
            this.labelPeso2.TabIndex = 27;
            this.labelPeso2.Text = "Peso";
            // 
            // inCambioEuro
            // 
            this.inCambioEuro.Location = new System.Drawing.Point(260, 38);
            this.inCambioEuro.Name = "inCambioEuro";
            this.inCambioEuro.Size = new System.Drawing.Size(100, 20);
            this.inCambioEuro.TabIndex = 28;
            this.inCambioEuro.TextChanged += new System.EventHandler(this.inCambioEuro_TextChanged);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(179, 38);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 29;
            this.buttonLock.Text = "candado";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.inCambioEuro);
            this.Controls.Add(this.labelPeso2);
            this.Controls.Add(this.labelDolar2);
            this.Controls.Add(this.labelEuro2);
            this.Controls.Add(this.outPe2Pe);
            this.Controls.Add(this.outPe2Do);
            this.Controls.Add(this.outPe2Eu);
            this.Controls.Add(this.outDo2Pe);
            this.Controls.Add(this.outDo2Do);
            this.Controls.Add(this.outDo2Eu);
            this.Controls.Add(this.outEu2Pe);
            this.Controls.Add(this.outEu2Do);
            this.Controls.Add(this.outEu2Eu);
            this.Controls.Add(this.inCambioPeso);
            this.Controls.Add(this.inCambioDolar);
            this.Controls.Add(this.buttonPeso);
            this.Controls.Add(this.buttonDolar);
            this.Controls.Add(this.inPeso);
            this.Controls.Add(this.inDolar);
            this.Controls.Add(this.inEuro);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.buttonEuro);
            this.Controls.Add(this.labelCotizacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.Button buttonEuro;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox inEuro;
        private System.Windows.Forms.TextBox inDolar;
        private System.Windows.Forms.TextBox inPeso;
        private System.Windows.Forms.Button buttonDolar;
        private System.Windows.Forms.Button buttonPeso;
        private System.Windows.Forms.TextBox inCambioDolar;
        private System.Windows.Forms.TextBox inCambioPeso;
        private System.Windows.Forms.TextBox outEu2Eu;
        private System.Windows.Forms.TextBox outEu2Do;
        private System.Windows.Forms.TextBox outEu2Pe;
        private System.Windows.Forms.TextBox outDo2Pe;
        private System.Windows.Forms.TextBox outDo2Do;
        private System.Windows.Forms.TextBox outDo2Eu;
        private System.Windows.Forms.TextBox outPe2Pe;
        private System.Windows.Forms.TextBox outPe2Do;
        private System.Windows.Forms.TextBox outPe2Eu;
        private System.Windows.Forms.Label labelEuro2;
        private System.Windows.Forms.Label labelDolar2;
        private System.Windows.Forms.Label labelPeso2;
        private System.Windows.Forms.TextBox inCambioEuro;
        private System.Windows.Forms.Button buttonLock;
    }
}

