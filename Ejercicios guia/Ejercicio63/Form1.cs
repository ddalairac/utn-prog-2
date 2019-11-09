using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetIntervalo t = new SetIntervalo(1000);
            t.evento += AsignarHora;
            System.Threading.Thread hilo = new System.Threading.Thread(t.Run);
            hilo.Start();
        }

        private void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                TempDelegado d = new TempDelegado(AsignarHora);
                this.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }
   
    }
}
