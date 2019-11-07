using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        string aux;


        public Form1()
        {
            InitializeComponent();
            this.ConectarDB();
            this.aux = this.ConsultaTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = this.aux;
        }
        private void ConectarDB()
        {
            String connectionStr;
            connectionStr = "Data Source=LAB3PC05\\SQLEXPRESS; ";
            connectionStr += "Initial Catalog =AdventureWorksLT2012; ";
            connectionStr += "Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }
        private string ConsultaTabla()
        {
            comando.CommandText = "SELECT Title,FirstName,LastName,ModifiedDate FROM SalesLT.Customer  ";
            comando.CommandText += "WHERE ModifiedDate between '2005-01-12' and '2005-02-12' order by ModifiedDate desc; ";
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();

            StringBuilder sb = new StringBuilder();
            while (oDr.Read())
            {
                sb.Append($"{ oDr["Title"].ToString()} ");
                sb.Append($"{ oDr["LastName"].ToString()}, ");
                sb.Append($"{ oDr["FirstName"].ToString()} :: ");
                sb.AppendLine($"{ oDr["ModifiedDate"].ToString()}");
            }
            return  sb.ToString();
        }


    }
}
