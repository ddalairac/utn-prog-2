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
using Patentes;

namespace _20181122_SP
{
    public delegate void PatDelegado(Patente patente);
    public partial class FrmPpal : Form
    {
        public event MostrarPatente verPatente;
        Queue<Patente> cola;
        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }  
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            verPatente += vistaPatente1.MostrarPatente;
            verPatente += vistaPatente2.MostrarPatente;
            //vistaPatente1
            MostrarAlerta.AlertaEve += this.Alerta;
        }
        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.hilos)
            {
                if (item != null && item.IsAlive) item.Abort();
            }
            this.hilos.Clear();
        }
        public void ProximaPatente(Patente patente)
        {
            Thread t = new Thread(new ParameterizedThreadStart(verPatente.Invoke));
            this.hilos.Add(t);
            t.Start(patente);
        }
        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();

            while (this.cola.Count > 0)
            {
                Patente p = this.cola.Dequeue();
                this.ProximaPatente(p);
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        #region Botones_de_carga 

        private void btnXml_Click(object sender, EventArgs e)
        {
            List<Patente> lp = new List<Patente>();
            Xml<List<Patente>> xml = new Xml<List<Patente>>();
            xml.Leer("patentes.xml", out lp);
            this.cola.Clear();
            this.cola = new Queue<Patente>(lp);
            this.IniciarSimulacion();
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
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            List<Patente> lp = new List<Patente>();
            Sql sql = new Sql();
            sql.Leer("dbo.Patentes", out lp);
            this.cola.Clear();
            this.cola = new Queue<Patente>(lp);
            this.IniciarSimulacion();
        }

        #endregion

        public void Alerta(string texto)
        {
            if (this.InvokeRequired)
            {
                AlertaDel d = new AlertaDel(this.Alerta);
                this.Invoke(d, new object[] { texto });
                //return (int) this.Invoke(d, new object[] { texto, numero }); 
            }
            else
            {
                MessageBox.Show(texto, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
