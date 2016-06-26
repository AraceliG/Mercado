using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Datos.DAO;
using System.Configuration;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos
{
    class UsuarioBD
    {

        int userId { set; get; }

        public static List<RolBD> ObtenerRoles(string usuario)
        {
            List<RolBD> lista = new List<RolBD>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COD_ROL,NOMBRE FROM NOTHING_IS_IMPOSSIBLE.ROL R WHERE  R.COD_ROL=(SELECT COD_ROL FROM NOTHING_IS_IMPOSSIBLE.ROLUSUARIO RU WHERE RU.USERID=(SELECT USERID FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.USERNAME= '" + usuario + "'))";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RolBD rol = new RolBD();

                rol.cod_rol = reader.GetInt32(0);
                rol.nombre = reader.GetString(1);

                lista.Add(rol);
            }

            return lista;
        }
    }
}
