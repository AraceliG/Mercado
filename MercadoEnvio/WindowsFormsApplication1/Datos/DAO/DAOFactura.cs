using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOFactura
    {


        internal static void generarFactura(Publicacion publi, int stock)
        {

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_publicacion", publi.cod_publicacion));
            paramList.Add(new SqlParameter("@userIdVendedor", publi.userId));
            paramList.Add(new SqlParameter("@totalFactura", publi.totalFactura()));
            paramList.Add(new SqlParameter("@numeroItemVenta", 1));
            paramList.Add(new SqlParameter("@numeroItemEnvio", 2));
            paramList.Add(new SqlParameter("@montoItemComisionPorVenta", publi.montoDeVenta()));
            paramList.Add(new SqlParameter("@montoItemComisionPorEnvio", publi.montoDeEnvio()));
            paramList.Add(new SqlParameter("@conceptoPorVenta", DAOConcepto.conceptoPorVenta()));
            paramList.Add(new SqlParameter("@conceptaPorEnvio", DAOConcepto.conceptoPorEnvio()));
            paramList.Add(new SqlParameter("@cantidad", stock));


            //no me crea nada y no tengo idea cuál es problema

            AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_facturarItems ", paramList);




        }
    }
}
