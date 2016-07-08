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

        internal static List<Oferta> lasOfertasDeCliente(Usuario usuario)
        {
            List<Oferta> ofertaList = new List<Oferta>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@userId", usuario.userId));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.OFERTA O WHERE O.USERID=@userId", "T", listaParametros);
          
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Oferta oferta = new Oferta();
                    oferta.cod_publicacion= (int)(decimal)lector["cod_publicacion"];
                    oferta.userId=(int)(decimal)lector["userId"];
                    oferta.fecha=(DateTime)lector["fecha"];
                    oferta.monto=(int)(decimal)lector["monto"];
                    oferta.ganadora = (bool)lector["ganadora"];

                    ofertaList.Add(oferta);
                }
            }

            return ofertaList;
        }
    }
}
