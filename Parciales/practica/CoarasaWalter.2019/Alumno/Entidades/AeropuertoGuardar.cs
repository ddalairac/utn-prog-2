using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AeropuertoGuardar
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static string connectionStr = @"Data Source=.\SQLEXPRESS; " +
            @"Initial Catalog =final-20190711; " +
            @"Integrated Security = True";



        public static bool GuardarSql(this Avion avion, string tabla, int horas)
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            DateTime time = DateTime.Now;

            try
            {

                conexion.Open();
                comando.CommandText = $"INSERT INTO {tabla} (entrada, alumno) " +
                $"VALUES ('{time.ToString()} - horas vuelo: {horas}', 'Dalairac Diego')";
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardaren DB", e);
            }
            finally
            {
                conexion.Close();
            }
        }
        public static bool GuardarTxt(this Avion avion, string archivo, int horas)
        {
            DateTime time = DateTime.Now;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo), true))
                {
                    sw.WriteLine($"{time.ToString()} - horas vuelo: {horas}");
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar archivo de texto", e);
            }

        }
    }

}
