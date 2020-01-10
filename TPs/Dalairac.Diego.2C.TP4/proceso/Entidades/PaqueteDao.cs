using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoMensaje(string msj);
    public static class PaqueteDao
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static PaqueteDao()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog =correo-sp-2017; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        /// <summary>
        /// Guarda el contenido del paquete en la DB (tabla 'correo-sp-2017')
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            try
            {
                comando.CommandText = $"INSERT INTO dbo.Paquetes " +
                    $"(direccionEntrega, trackingID, alumno ) " +
                    $"VALUES ('{p.DireccionEntrega}', '{p.TrackingID}', 'Dalairac Diego')";

                conexion.Open();
                int cant = comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new InsertarEnDBExcepcion("Error al guardar en la base de datos",e);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

