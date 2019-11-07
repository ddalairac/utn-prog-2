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
            this.insertData();
            this.deleteData();
            this.aux = this.ConsultaTabla();

            //try
            //{
            //    this.aux = this.ConsultaTabla();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Excepcion: ",e);
            //}
            //finally
            //{
            //    conexion.Close();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = this.aux;
        }
        private void ConectarDB()
        {
            String connectionStr;
            connectionStr = "Data Source=LAB3PC02\\SQLEXPRESS; ";
            connectionStr += "Initial Catalog =AdventureWorks2012; ";
            connectionStr += "Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }
        private string ConsultaTabla()
        {
            comando.CommandText = "select * from Production.Product";
            //comando.CommandText += "WHERE ModifiedDate between '2005-01-12' and '2005-02-12' order by ModifiedDate desc; ";
            StringBuilder sb = new StringBuilder();
            try
            {
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    sb.Append($"{ oDr["Name"].ToString()} ");
                    sb.Append($" - { oDr["ProductNumber"].ToString()}, ");
                    sb.Append($" - { oDr["ModifiedDate"].ToString()} :: ");
                    sb.AppendLine($" - { oDr["ListPrice"].ToString()}");
                }
            }
            catch (Exception e)
            {   
                Console.WriteLine( "Excepcion: ", e);
            }
            finally
            {
                conexion.Close();
            }
            
            return  sb.ToString();
        }

        private bool insertData()
        {
            comando.CommandText = "INSERT INTO Production.Product ";
            comando.CommandText += "(Name, ProductNumber, ModifiedDate, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) ";
            comando.CommandText += "VALUES('abanos', 123, '2019-05-05', 500, 200, 0.00, 0.00, 1, '2019-06-05'); ";
            try
            {
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: ", e);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        private bool deleteData()
        {
            comando.CommandText = "DELETE FROM Production.Product WHERE Name='abanos';";
            try
            {
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: ", e);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

    }
}
