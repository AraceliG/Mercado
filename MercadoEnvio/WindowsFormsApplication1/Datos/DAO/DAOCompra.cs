using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOCompra
    {




        internal static void documentarCompra(Publicacion publicacion, int stock, Usuario user, String fecha)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            parameterList.Add(new SqlParameter("@userId", user.userId));
            parameterList.Add(new SqlParameter("@cantidad", stock));
            parameterList.Add(new SqlParameter("@fecha",Convert.ToDateTime(fecha)));

            AccesoBaseDeDatos.WriteInBase("INSERT INTO NOTHING_IS_IMPOSSIBLE.COMPRA (COD_PUBLICACION, USERID,CANTIDAD,FECHA) " +
                                                " VALUES (@cod_publi, @userId, @cantidad,@fecha)", "T", parameterList);
        }

        internal static List<Compra> lasComprasDeCliente(Usuario usuario)
        {
            List<Compra> compraList = new List<Compra>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@userId", usuario.userId));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.COMPRA C WHERE C.USERID=@userId", "T", listaParametros);
          
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Compra compra = new Compra();
                    compra.cod_publicacion= (int)(decimal)lector["cod_publicacion"];
                    compra.userId=(int)(decimal)lector["userId"];
                    compra.fecha=(DateTime)lector["fecha"];
                    compra.cantidad=(int)(decimal)lector["cantidad"];
                    compra.cant_estrellas = lector["cant_estrellas"]== DBNull.Value ? 0 : (int)(decimal)lector["cant_estrellas"];
                    compra.txt_libre_calif = lector["txt_libre_calif"] == DBNull.Value ? null : (string)lector["txt_libre_calif"];
                        //(String)lector["txt_libre_calif"];

                    compraList.Add(compra);
                }
            }

            return compraList;

            
        }

        internal static List<Compra> comprasSinCalificar( Usuario user)
        {
            List<Compra> compraList = new List<Compra>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@userId", user.userId));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.COMPRA C WHERE C.USERID=@userId and (C.CANT_ESTRELLAS IS NULL)", "T", listaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Compra compra = new Compra();
                    compra.cod_publicacion = (int)(decimal)lector["cod_publicacion"];
                    compra.userId = (int)(decimal)lector["userId"]; 
                    compra.cantidad = (int)(decimal)lector["cantidad"];
                    compra.fecha = (DateTime)lector["fecha"];
                    compra.cant_estrellas = lector["cant_estrellas"] == DBNull.Value ? 0 : (int)(decimal)lector["cant_estrellas"];
                    compra.txt_libre_calif = lector["txt_libre_calif"] == DBNull.Value ? null : (string)lector["txt_libre_calif"];

                    compraList.Add(compra);
                }
            }

            return compraList;
        }
    }
}
