namespace Ejercicio40_form
{
    partial class FrmMenu
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
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.buttonFacTotal = new System.Windows.Forms.Button();
            this.buttonFacLocal = new System.Windows.Forms.Button();
            this.buttonFacProvincial = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerar.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(212, 50);
            this.buttonGenerar.TabIndex = 0;
            this.buttonGenerar.Text = "Generar Llamada";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // buttonFacTotal
            // 
            this.buttonFacTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacTotal.Location = new System.Drawing.Point(12, 68);
            this.buttonFacTotal.Name = "buttonFacTotal";
            this.buttonFacTotal.Size = new System.Drawing.Size(212, 50);
            this.buttonFacTotal.TabIndex = 1;
            this.buttonFacTotal.Text = "Facturacion Total";
            this.buttonFacTotal.UseVisualStyleBackColor = true;
            this.buttonFacTotal.Click += new System.EventHandler(this.buttonFacTotal_Click);
            // 
            // buttonFacLocal
            // 
            this.buttonFacLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacLocal.Location = new System.Drawing.Point(12, 124);
            this.buttonFacLocal.Name = "buttonFacLocal";
            this.buttonFacLocal.Size = new System.Drawing.Size(212, 50);
            this.buttonFacLocal.TabIndex = 2;
            this.buttonFacLocal.Text = "Facturacion Local";
            this.buttonFacLocal.UseVisualStyleBackColor = true;
            this.buttonFacLocal.Click += new System.EventHandler(this.buttonFacLocal_Click);
            // 
            // buttonFacProvincial
            // 
            this.buttonFacProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacProvincial.Location = new System.Drawing.Point(12, 180);
            this.buttonFacProvincial.Name = "buttonFacProvincial";
            this.buttonFacProvincial.Size = new System.Drawing.Size(212, 50);
            this.buttonFacProvincial.TabIndex = 3;
            this.buttonFacProvincial.Text = "Facturacion Provincial";
            this.buttonFacProvincial.UseVisualStyleBackColor = true;
            this.buttonFacProvincial.Click += new System.EventHandler(this.buttonFacProvincial_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(12, 236);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(212, 50);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 298);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFacProvincial);
            this.Controls.Add(this.buttonFacLocal);
            this.Controls.Add(this.buttonFacTotal);
            this.Controls.Add(this.buttonGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Button buttonFacTotal;
        private System.Windows.Forms.Button buttonFacLocal;
        private System.Windows.Forms.Button buttonFacProvincial;
        private System.Windows.Forms.Button buttonSalir;
    }
}

