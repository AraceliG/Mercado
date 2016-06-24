using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOUsuario
    {
        // Method
        public static bool userNameValido(string userName)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userName", userName));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Usuario WHERE username=@userName", "TD", paramList);
            if (lector.HasRows)
            {
                return true;
            }
            return false;
        }

        // Method
        public static bool comprobarLogin(string userName, string pass)
        {



            decimal resultado_sp;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", userName));
            paramList.Add(new SqlParameter("@pass", pass));

            SqlParameter outputIdParam = new SqlParameter("@ret", SqlDbType.Int)
            { 
                Direction = ParameterDirection.Output 
            };

            paramList.Add(outputIdParam);

            resultado_sp = (int) AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_login", paramList);

            if (resultado_sp == 1)
            {
                return true;
            }
            return false;
        }
    }
}
