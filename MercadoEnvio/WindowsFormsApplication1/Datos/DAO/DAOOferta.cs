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
        internal static void crearOferta(Publicacion publicacion, Usuario usuario, int oferta, String fecha)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            parameterList.Add(new SqlParameter("@userId", usuario.userId));
            parameterList.Add(new SqlParameter("@monto", oferta));
            parameterList.Add(new SqlParameter("@fecha",Convert.ToDateTime(fecha)));

            AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.OFERTA (COD_PUBLICACION, USERID,MONTO,FECHA,GANADORA) " +
                                                " VALUES (@cod_publi, @userId, @monto,@fecha,0)", "T", parameterList); 
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
                lector.Close();
            }

            return ofertaList;
        }

        internal static Oferta buscarGanadora(decimal cod_publicacion)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publicacion", cod_publicacion));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader( 
                                                @"	SELECT * FROM [NOTHING_IS_IMPOSSIBLE].[Oferta]
	                                                where [cod_publicacion] = @cod_publicacion and 
		                                                monto = (select max(monto) FROM [NOTHING_IS_IMPOSSIBLE].[Oferta]
				                                                where [cod_publicacion] = @cod_publicacion)", "T", listaParametros);
            Oferta oferta = new Oferta();
            if (lector.HasRows)
            {
                lector.Read();
                oferta.cod_publicacion = (decimal)lector["cod_publicacion"];
                oferta.userId = (decimal)lector["userId"];
                oferta.fecha = (DateTime)lector["fecha"];
                oferta.monto = (decimal)lector["monto"];
                oferta.ganadora = (bool)lector["ganadora"];
                lector.Close();
            }
            else
            {
                oferta = null;
            }

            return oferta;
        }

        internal static void ponerGanadora(Oferta oferta)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publicacion", oferta.cod_publicacion));
            parameterList.Add(new SqlParameter("@userId", oferta.userId));
            parameterList.Add(new SqlParameter("@fecha", oferta.fecha));
            parameterList.Add(new SqlParameter("@monto", oferta.monto));



            AccesoBaseDeDatos.WriteInBase(@"UPDATE NOTHING_IS_IMPOSSIBLE.Oferta SET ganadora= 1 
                                        WHERE COD_PUBLICACION=@cod_publicacion and userId = @userId and fecha = @fecha and monto = @monto", "T", parameterList);

        }
    }
}
