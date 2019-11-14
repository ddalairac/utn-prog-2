using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            string nombreLey = objeto.NombreLey, nombreAlumno = "Dalairac";
            short afirmativos = objeto.ContadorAfirmativo, negativos = objeto.ContadorNegativo, abstenciones = objeto.ContadorAbstencion;
            int cantInsertada;

            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog =votacion-sp-2018; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connectionStr);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = $"INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{nombreLey}', {afirmativos}, {negativos}, {abstenciones}, '{nombreAlumno}')";

            try
            {
                sqlConnection.Open();
                cantInsertada = sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
