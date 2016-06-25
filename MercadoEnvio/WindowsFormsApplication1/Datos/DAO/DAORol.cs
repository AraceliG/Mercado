using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAORol
    {
        internal static List<Rol> getRolesDe(decimal userId)
        {
            List<Rol> rolesDe = new List<Rol>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userId", userId));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("NOTHING_IS_IMPOSSIBLE.sp_rolesDe", "SP", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.nombre = (string)lector["nombre"];
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    rolesDe.Add(unRol);
                }
            }
            return rolesDe;
        }

        internal static bool funcionalidadValidaPara(decimal cod_rol, string nombreFuncionalidad)
        {
            decimal resultado_sp;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_rol", cod_rol));
            paramList.Add(new SqlParameter("@nombre", nombreFuncionalidad));

            SqlParameter outputIdParam = new SqlParameter("@ret", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            paramList.Add(outputIdParam);

            resultado_sp = (int)AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.funcionalidadValidaParaRol", paramList);

            if (resultado_sp == 1)
            {
                return true;
            }
            return false;
        }
    }
}
