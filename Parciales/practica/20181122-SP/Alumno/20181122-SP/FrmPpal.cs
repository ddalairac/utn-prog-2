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
using Archivos;
using System.Threading;
using Archivos;

namespace _20181122_SP
{
    public delegate void PatDelegado(Patente patente);
    public partial class FrmPpal : Form
    {
        public event PatDelegado vistaPatente;
        Queue<Patente> cola;
        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }
        public void ProximaPatente(Patente patente)
        {

        }
        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            List<Patente> lp = new List<Patente>();
            Xml<List<Patente>> xml = new Xml<List<Patente>>();
            xml.Leer("patentes.xml", out lp);
            this.cola.Clear();
            this.cola = new Queue<Patente>(lp);

            while (this.cola.Count > 0)
            {
                Patente p = this.cola.Dequeue();
                MessageBox.Show(p.CodigoPatente, "Pat XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto Texto = new Texto();
            string str;
            Texto.Leer("patentes.txt", out str);
            string[] strPatentes = str.Split('\n');
            this.cola.Clear();
            foreach (string p in strPatentes)
            {
                try
                {
                    this.cola.Enqueue(PatenteStringExtension.ValidarPatente(p.Replace("\r", String.Empty)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            while (this.cola.Count > 0)
            {
                Patente p = this.cola.Dequeue();
                MessageBox.Show(p.CodigoPatente, "Pat TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            List<Patente> lp = new List<Patente>();
            Sql sql = new Sql();
            sql.Leer("dbo.Patentes", out lp);
            this.cola.Clear();
            this.cola = new Queue<Patente>(lp);

            while (this.cola.Count > 0)
            {
                Patente p = this.cola.Dequeue();
                MessageBox.Show(p.CodigoPatente, "Pat SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.hilos)
            {
                if (item != null && item.IsAlive) item.Abort();
            }
        }
    }
}
