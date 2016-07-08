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
            parameterList.Add(new SqlParameter("@userId", usuario.userId));
            parameterList.Add(new SqlParameter("@monto", oferta));

            AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.OFERTA (COD_PUBLICACION, USERID,MONTO) " +
                                                " VALUES (@cod_publi, @userId, @monto)", "T", parameterList); 
        }
    }
}
