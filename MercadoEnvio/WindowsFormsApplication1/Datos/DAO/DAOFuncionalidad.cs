using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOFuncionalidad
    {
        internal static List<Funcionalidad> getFuncionalidadesDe(decimal cod_rol)
        {
            List<Funcionalidad> funcionesDe = new List<Funcionalidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_rol", cod_rol));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("NOTHING_IS_IMPOSSIBLE.sp_funcionalidadesDe", "SP", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncion = new Funcionalidad();
                    unaFuncion.nombre = (string)lector["nombre"];
                    unaFuncion.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    funcionesDe.Add(unaFuncion);
                }
            }
            return funcionesDe;
        }

       public static List<Funcionalidad> buscarFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.FUNCIONALIDAD", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad func = new Funcionalidad();
                    func.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    func.nombre = (string)lector["nombre"];
                    funcionalidades.Add(func);
                }
            }
            return funcionalidades;
        }
    }
}
