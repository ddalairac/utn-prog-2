using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<List<Patente>>
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public Sql()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; " +
                            @"Initial Catalog =patentes-sp-2018; " +
                            @"Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        public bool Guardar(string tabla, List<Patente> datos)
        {
            try
            {

                conexion.Open();
                foreach (Patente p in datos)
                {
                    comando.CommandText = $"INSERT INTO {tabla} (patente, tipo) " +
                    $"VALUES ('{p.CodigoPatente}', '{p.TipoCodigo}')";
                    comando.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar en DB", e);
            }
            finally
            {
                conexion.Close();
            }
        }
            public bool Leer(string tabla, out List<Patente> datos)
        {
            try
            {

                List<Patente> lp = new List<Patente>();
                Patente.Tipo tipo;
                string srtTipo;
                comando.CommandText = $"SELECT * FROM {tabla};";
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    srtTipo = oDr["tipo"].ToString();
                    tipo = (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo), srtTipo);
                    lp.Add(new Patente(oDr["patente"].ToString(), tipo));
                }
                datos = lp;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer en DB", e);
            }
        }
    }
}

