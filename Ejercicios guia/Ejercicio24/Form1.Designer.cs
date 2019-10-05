namespace Ejercicio24
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
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.inFahrenheit = new System.Windows.Forms.TextBox();
            this.inKelvin = new System.Windows.Forms.TextBox();
            this.inCelsius = new System.Windows.Forms.TextBox();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelKelvin = new System.Windows.Forms.Label();
            this.buttonConvFa = new System.Windows.Forms.Button();
            this.buttonConvKe = new System.Windows.Forms.Button();
            this.buttonConvCe = new System.Windows.Forms.Button();
            this.textC2F = new System.Windows.Forms.TextBox();
            this.textK2F = new System.Windows.Forms.TextBox();
            this.textF2F = new System.Windows.Forms.TextBox();
            this.textC2C = new System.Windows.Forms.TextBox();
            this.textK2C = new System.Windows.Forms.TextBox();
            this.textF2C = new System.Windows.Forms.TextBox();
            this.textC2K = new System.Windows.Forms.TextBox();
            this.textK2K = new System.Windows.Forms.TextBox();
            this.textF2K = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(42, 58);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.labelFahrenheit.TabIndex = 0;
            this.labelFahrenheit.Text = "Fahrenheit";
            // 
            // inFahrenheit
            // 
            this.inFahrenheit.Location = new System.Drawing.Point(104, 58);
            this.inFahrenheit.Name = "inFahrenheit";
            this.inFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.inFahrenheit.TabIndex = 1;
            this.inFahrenheit.TextChanged += new System.EventHandler(this.inFahrenheit_TextChanged);
            // 
            // inKelvin
            // 
            this.inKelvin.Location = new System.Drawing.Point(104, 110);
            this.inKelvin.Name = "inKelvin";
            this.inKelvin.Size = new System.Drawing.Size(100, 20);
            this.inKelvin.TabIndex = 5;
            this.inKelvin.TextChanged += new System.EventHandler(this.inKelvin_TextChanged);
            // 
            // inCelsius
            // 
            this.inCelsius.Location = new System.Drawing.Point(104, 84);
            this.inCelsius.Name = "inCelsius";
            this.inCelsius.Size = new System.Drawing.Size(100, 20);
            this.inCelsius.TabIndex = 3;
            this.inCelsius.TextChanged += new System.EventHandler(this.inCelsius_TextChanged);
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(42, 87);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(40, 13);
            this.labelCelsius.TabIndex = 4;
            this.labelCelsius.Text = "Celsius";
            // 
            // labelKelvin
            // 
            this.labelKelvin.AutoSize = true;
            this.labelKelvin.Location = new System.Drawing.Point(42, 117);
            this.labelKelvin.Name = "labelKelvin";
            this.labelKelvin.Size = new System.Drawing.Size(36, 13);
            this.labelKelvin.TabIndex = 5;
            this.labelKelvin.Text = "Kelvin";
            // 
            // buttonConvFa
            // 
            this.buttonConvFa.Location = new System.Drawing.Point(210, 55);
            this.buttonConvFa.Name = "buttonConvFa";
            this.buttonConvFa.Size = new System.Drawing.Size(75, 23);
            this.buttonConvFa.TabIndex = 2;
            this.buttonConvFa.Text = "->";
            this.buttonConvFa.UseVisualStyleBackColor = true;
            this.buttonConvFa.Click += new System.EventHandler(this.buttonConvFa_Click);
            // 
            // buttonConvKe
            // 
            this.buttonConvKe.Location = new System.Drawing.Point(210, 108);
            this.buttonConvKe.Name = "buttonConvKe";
            this.buttonConvKe.Size = new System.Drawing.Size(75, 23);
            this.buttonConvKe.TabIndex = 6;
            this.buttonConvKe.Text = "->";
            this.buttonConvKe.UseVisualStyleBackColor = true;
            this.buttonConvKe.Click += new System.EventHandler(this.buttonConvKe_Click);
            // 
            // buttonConvCe
            // 
            this.buttonConvCe.Location = new System.Drawing.Point(210, 82);
            this.buttonConvCe.Name = "buttonConvCe";
            this.buttonConvCe.Size = new System.Drawing.Size(75, 23);
            this.buttonConvCe.TabIndex = 4;
            this.buttonConvCe.Text = "->";
            this.buttonConvCe.UseVisualStyleBackColor = true;
            this.buttonConvCe.Click += new System.EventHandler(this.buttonConvCe_Click);
            // 
            // textC2F
            // 
            this.textC2F.Enabled = false;
            this.textC2F.Location = new System.Drawing.Point(291, 84);
            this.textC2F.Name = "textC2F";
            this.textC2F.Size = new System.Drawing.Size(100, 20);
            this.textC2F.TabIndex = 11;
            // 
            // textK2F
            // 
            this.textK2F.Enabled = false;
            this.textK2F.Location = new System.Drawing.Point(291, 110);
            this.textK2F.Name = "textK2F";
            this.textK2F.Size = new System.Drawing.Size(100, 20);
            this.textK2F.TabIndex = 10;
            // 
            // textF2F
            // 
            this.textF2F.Enabled = false;
            this.textF2F.Location = new System.Drawing.Point(291, 58);
            this.textF2F.Name = "textF2F";
            this.textF2F.Size = new System.Drawing.Size(100, 20);
            this.textF2F.TabIndex = 9;
            // 
            // textC2C
            // 
            this.textC2C.Enabled = false;
            this.textC2C.Location = new System.Drawing.Point(397, 84);
            this.textC2C.Name = "textC2C";
            this.textC2C.Size = new System.Drawing.Size(100, 20);
            this.textC2C.TabIndex = 14;
            // 
            // textK2C
            // 
            this.textK2C.Enabled = false;
            this.textK2C.Location = new System.Drawing.Point(397, 110);
            this.textK2C.Name = "textK2C";
            this.textK2C.Size = new System.Drawing.Size(100, 20);
            this.textK2C.TabIndex = 13;
            // 
            // textF2C
            // 
            this.textF2C.Enabled = false;
            this.textF2C.Location = new System.Drawing.Point(397, 58);
            this.textF2C.Name = "textF2C";
            this.textF2C.Size = new System.Drawing.Size(100, 20);
            this.textF2C.TabIndex = 12;
            // 
            // textC2K
            // 
            this.textC2K.Enabled = false;
            this.textC2K.Location = new System.Drawing.Point(503, 84);
            this.textC2K.Name = "textC2K";
            this.textC2K.Size = new System.Drawing.Size(100, 20);
            this.textC2K.TabIndex = 17;
            // 
            // textK2K
            // 
            this.textK2K.Enabled = false;
            this.textK2K.Location = new System.Drawing.Point(503, 110);
            this.textK2K.Name = "textK2K";
            this.textK2K.Size = new System.Drawing.Size(100, 20);
            this.textK2K.TabIndex = 16;
            // 
            // textF2K
            // 
            this.textF2K.Enabled = false;
            this.textF2K.Location = new System.Drawing.Point(503, 58);
            this.textF2K.Name = "textF2K";
            this.textF2K.Size = new System.Drawing.Size(100, 20);
            this.textF2K.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textC2K);
            this.Controls.Add(this.textK2K);
            this.Controls.Add(this.textF2K);
            this.Controls.Add(this.textC2C);
            this.Controls.Add(this.textK2C);
            this.Controls.Add(this.textF2C);
            this.Controls.Add(this.textC2F);
            this.Controls.Add(this.textK2F);
            this.Controls.Add(this.textF2F);
            this.Controls.Add(this.buttonConvCe);
            this.Controls.Add(this.buttonConvKe);
            this.Controls.Add(this.buttonConvFa);
            this.Controls.Add(this.labelKelvin);
            this.Controls.Add(this.labelCelsius);
            this.Controls.Add(this.inCelsius);
            this.Controls.Add(this.inKelvin);
            this.Controls.Add(this.inFahrenheit);
            this.Controls.Add(this.labelFahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFahrenheit;
        private System.Windows.Forms.TextBox inFahrenheit;
        private System.Windows.Forms.TextBox inKelvin;
        private System.Windows.Forms.TextBox inCelsius;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.Label labelKelvin;
        private System.Windows.Forms.Button buttonConvFa;
        private System.Windows.Forms.Button buttonConvKe;
        private System.Windows.Forms.Button buttonConvCe;
        private System.Windows.Forms.TextBox textC2F;
        private System.Windows.Forms.TextBox textK2F;
        private System.Windows.Forms.TextBox textF2F;
        private System.Windows.Forms.TextBox textC2C;
        private System.Windows.Forms.TextBox textK2C;
        private System.Windows.Forms.TextBox textF2C;
        private System.Windows.Forms.TextBox textC2K;
        private System.Windows.Forms.TextBox textK2K;
        private System.Windows.Forms.TextBox textF2K;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

