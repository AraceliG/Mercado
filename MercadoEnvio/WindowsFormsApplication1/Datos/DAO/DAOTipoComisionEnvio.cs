using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOTipoComisionEnvio
    {
        internal static List<TipoComisionEnvio> getTipos()
        {
            List<TipoComisionEnvio> tipos = new List<TipoComisionEnvio>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.TipoComisionEnvio", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    tipos.Add( new TipoComisionEnvio( (string)lector["cod_tipo_comision"] , (string)lector["descripcion"]) );
                }
                lector.Close();
            }
            return tipos;
        }
    }
}
