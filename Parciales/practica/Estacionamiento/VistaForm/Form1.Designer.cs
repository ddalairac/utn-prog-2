namespace VistaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textPatente = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textPatente
            // 
            this.textPatente.Location = new System.Drawing.Point(12, 41);
            this.textPatente.Name = "textPatente";
            this.textPatente.Size = new System.Drawing.Size(148, 20);
            this.textPatente.TabIndex = 1;
            this.textPatente.TextChanged += new System.EventHandler(this.TextPatente_TextChanged);
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(12, 80);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(148, 20);
            this.textModelo.TabIndex = 2;
            this.textModelo.TextChanged += new System.EventHandler(this.TextModelo_TextChanged);
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(9, 25);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(44, 13);
            this.labelPatente.TabIndex = 3;
            this.labelPatente.Text = "Patente";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(9, 64);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 4;
            this.labelModelo.Text = "Modelo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 166);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.textPatente);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPatente;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelModelo;
    }
}

