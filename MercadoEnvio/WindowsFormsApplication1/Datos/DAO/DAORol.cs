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

        public static List<Rol> buscarRoles()
        {
            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT R.COD_ROL,R.NOMBRE,R.BAJA FROM NOTHING_IS_IMPOSSIBLE.ROL R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {   Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre = (string)lector["nombre"];
                    unRol.baja = (bool)lector["baja"];
                    roles.Add(unRol);
                }
            }
            return roles;
        }

        public static void altaLogica(Rol rol)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_rol", rol.cod_rol));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.ROL SET ROL.BAJA=0  WHERE ROL.COD_ROL=@cod_rol", "T", paramList);
           
        }

        public static void bajaLogica(Rol rol)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_rol", rol.cod_rol));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.ROL SET ROL.BAJA=1  WHERE ROL.COD_ROL=@cod_rol", "T", paramList);

        }
    }
}
