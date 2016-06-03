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


    }
}
