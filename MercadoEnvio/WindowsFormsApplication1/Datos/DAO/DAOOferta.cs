using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOOferta
    {
        internal static void crearOferta(Publicacion publicacion, Usuario usuario, int oferta)
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
