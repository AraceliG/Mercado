using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Modelo;
using System.Data;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOFactura
    {


        internal static void generarFactura(Factura unaFactura)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_publicacion", unaFactura.cod_publicacion));
            paramList.Add(new SqlParameter("@userId", unaFactura.userId));
            paramList.Add(new SqlParameter("@fecha", unaFactura.fecha));
            paramList.Add(new SqlParameter("@total", unaFactura.total));
            paramList.Add(new SqlParameter("@forma_pago_desc", unaFactura.forma_pago_desc));

            SqlParameter nro_factura = new SqlParameter();
            nro_factura.ParameterName = "@nro_factura";
            nro_factura.DbType = DbType.Decimal;
            nro_factura.Direction = ParameterDirection.Output;
            paramList.Add(nro_factura);

            AccesoBaseDeDatos.WriteInBase("NOTHING_IS_IMPOSSIBLE.insertarFactura", "SP", paramList);
            unaFactura.nro_factura = (decimal) nro_factura.Value;
            
        }

        internal static void generarItem(ItemFactura unItem)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nro_factura", unItem.nro_factura));
            paramList.Add(new SqlParameter("@cod_concepto", unItem.cod_concepto));
            paramList.Add(new SqlParameter("@monto", unItem.monto));
            paramList.Add(new SqlParameter("@cantidad", unItem.cantidad));

            SqlParameter nro_item = new SqlParameter();
            nro_item.ParameterName = "@nro_item";
            nro_item.DbType = DbType.Decimal;
            nro_item.Direction = ParameterDirection.Output;
            paramList.Add(nro_item);

            AccesoBaseDeDatos.WriteInBase("NOTHING_IS_IMPOSSIBLE.insertarItemFactura", "SP", paramList);
            unItem.nro_item = (decimal)nro_item.Value;
        }
    }
}
