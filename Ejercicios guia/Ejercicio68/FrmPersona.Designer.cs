namespace Ejercicio68
{
    partial class FrmPersona
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
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(30, 136);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(30, 44);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(30, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(30, 75);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(30, 94);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 3;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 217);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonCrear);
            this.Name = "FrmPersona";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textApellido;
    }
}

