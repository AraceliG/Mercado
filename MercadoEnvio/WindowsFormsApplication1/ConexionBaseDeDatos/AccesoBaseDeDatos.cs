using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace MercadoEnvioFRBA.ConexionBaseDatos
{
    class AccesoBaseDeDatos
    {
        //para conectar base de datos con visual
        private static SqlConnection connection = new SqlConnection();

        public static SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString =
                   @System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                // el string "ConnectionString" se obtiene del app.config
                connection.Open();
            }
            return connection;
        }

        private static SqlCommand BuildSQLCommand(string commandtext, List<SqlParameter> parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetConnection();
            sqlCommand.CommandText = commandtext;
            if (parameters != null)
            {
                foreach (SqlParameter param in parameters) { sqlCommand.Parameters.Add(param); }
            }
            return sqlCommand;
        }


        public static decimal ExecStoredProcedure(string commandText, List<SqlParameter> parameters)
        {
            try
            {
                SqlCommand sqlCommand = BuildSQLCommand(commandText, parameters);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                return (decimal)sqlCommand.Parameters["@ret"].Value;
            }
            catch { return 0; }
        }


    }
}
