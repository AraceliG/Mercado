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
                lector.Close();
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
                lector.Close();
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

        public static Rol crearRol(Rol r)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@rol_nombre",r.nombre));

            AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.ROL (ROL.NOMBRE,ROL.BAJA,ROL.HABILITADO) " +
                                                " VALUES (@rol_nombre,0,1)", "T", parameterList);

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@rol_nombre",r.nombre));

            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT R.COD_ROL,R.NOMBRE,R.BAJA FROM NOTHING_IS_IMPOSSIBLE.ROL R WHERE R.NOMBRE=@rol_nombre", "T", param);
            if (lector.HasRows)
            {
                while (lector.Read())
                {   Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre = (string)lector["nombre"];
                    unRol.baja = (bool)lector["baja"];
                    roles.Add(unRol);
                }
                lector.Close();
            }
            return roles[0];
        }

          /*
           * foreach (Funcionalidad f  in r.funcionalidades)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@cod_funcionalidad", f.cod_funcionalidad));
                parametros.Add(new SqlParameter("@rol_nombre", r.nombre));
                AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD (COD_FUNCIONALIDAD,COD_ROL) " +
                                                " VALUES (@cod_funcionalidad,(SELECT COD_ROL FROM NOTHING_IS_IMPOSSIBLE.ROL WHERE NOMBRE=@rol_nombre)", "T", parametros); 
           */ 

        public static bool existeNombreRol(string nombreRol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre",nombreRol));
            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.ROL R WHERE R.NOMBRE=@nombre", "T", parametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre = (string)lector["nombre"];
                    unRol.baja = (bool)lector["baja"];
                    roles.Add(unRol);
                }
                lector.Close();
            }
            return roles.Count>=1;
        }

        public static void actualizarRol(Rol rol, string nombreAnteriorRol, List<Funcionalidad> funcAnt)
        {

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nom_ant", nombreAnteriorRol));
            paramList.Add(new SqlParameter("@nombre_rol", rol.nombre));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.ROL SET ROL.NOMBRE=@nombre_rol WHERE ROL.NOMBRE=@nom_ant", "T", paramList);

            foreach (Funcionalidad f in funcAnt)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));
                parametros.Add(new SqlParameter("@cod_funcionalidad", f.cod_funcionalidad));
                parametros.Add(new SqlParameter("@rol_nombre", rol.nombre));
                AccesoBaseDeDatos.WriteInBase("DELETE FROM NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD WHERE COD_ROL=@cod_rol", "T", parametros);

            }
            
            foreach (Funcionalidad f  in rol.funcionalidades)
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@cod_funcionalidad", f.cod_funcionalidad));
                param.Add(new SqlParameter("@rol_nombre", rol.nombre));
                AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD (COD_FUNCIONALIDAD,COD_ROL)  VALUES (@cod_funcionalidad,(SELECT COD_ROL FROM NOTHING_IS_IMPOSSIBLE.ROL WHERE NOMBRE=@rol_nombre))", "T", param); 

            }
        }

        public static List<Funcionalidad> obtenerFuncionalidades(string nombreAnteriorRol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre_rol", nombreAnteriorRol));
            List<Funcionalidad> func = new List<Funcionalidad>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT F.COD_FUNCIONALIDAD,F.NOMBRE FROM NOTHING_IS_IMPOSSIBLE.FUNCIONALIDAD F ,NOTHING_IS_IMPOSSIBLE.ROL R , NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD RF WHERE R.NOMBRE=@nombre_rol AND RF.COD_FUNCIONALIDAD=F.COD_FUNCIONALIDAD ", "T", parametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    funcionalidad.nombre = (string)lector["nombre"];
                    func.Add(funcionalidad);
                }
                lector.Close();
            }
            return func;
        }

        internal static void cambiarNombre(Rol rol, string nombreViejoRol)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nom_ant", nombreViejoRol));
            paramList.Add(new SqlParameter("@nombre_rol", rol.nombre));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.ROL SET ROL.NOMBRE=@nombre_rol WHERE ROL.NOMBRE=@nom_ant", "T", paramList);
            
        }
    }
}
