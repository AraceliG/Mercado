using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOCompra
    {
        internal static void documentarCompra(Publicacion publicacion, int stock, Usuario user)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            parameterList.Add(new SqlParameter("@userId", user.userId));
            parameterList.Add(new SqlParameter("@cantidad", stock));

            AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.COMPRA (COD_PUBLICACION, USERID,CANTIDAD) " +
                                                " VALUES (@cod_publi, @userId, @cantidad)", "T", parameterList);
        }
    }
}
