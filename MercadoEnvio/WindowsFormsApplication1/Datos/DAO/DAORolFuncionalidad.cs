using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAORolFuncionalidad
    {

        internal static bool existeRolFuncionalidad(Rol rol, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@rol_id", rol.cod_rol));
            ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad.cod_funcionalidad));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_ROL FROM NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD WHERE COD_ROL=@rol_id AND COD_FUNCIONALIDAD=@funcionalidad_id", "T", ListaParametros);

            return lector.HasRows;
        }


        internal static void agregateA(Rol rol, Funcionalidad funcionalidad)
        {
             List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@rol_id", rol.cod_rol));
                ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad.cod_funcionalidad));

                AccesoBaseDeDatos.WriteInBase("insert into NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD (COD_ROL, COD_FUNCIONALIDAD) VALUES(@rol_id, @funcionalidad_id)", "T", ListaParametros);
        }

        internal static void eliminateDe(Rol rol, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@cod_funcionalidad",funcionalidad.cod_funcionalidad ));

            ListaParametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));

             AccesoBaseDeDatos.WriteInBase("DELETE FROM NOTHING_IS_IMPOSSIBLE.ROLFUNCIONALIDAD WHERE COD_ROL=@cod_rol AND COD_FUNCIONALIDAD=@cod_funcionalidad", "T", ListaParametros);
        }
    }
}
    