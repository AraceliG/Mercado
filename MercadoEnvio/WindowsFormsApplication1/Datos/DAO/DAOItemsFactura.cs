using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOItemsFactura
    {

        public static List<ItemFactura> getItemsDefactura(Factura factura)
        {

            List<ItemFactura> items = new List<ItemFactura>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT descripcion, nro_factura,nro_item,monto,cantidad FROM NOTHING_IS_IMPOSSIBLE.Concepto C,NOTHING_IS_IMPOSSIBLE.ItemFactura ITF where C.cod_concepto=ITF.cod_concepto ", "T", listaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    ItemFactura item = new ItemFactura();
                    item.nro_factura = (decimal)lector["nro_factura"];
                    item.cantidad = (decimal)lector["cantidad"];
                    item.nro_item = (decimal)lector["nro_item"];
                    item.monto = (decimal)lector["monto"];
                    item.descripcion = (String)lector["descripcion"];

                    items.Add(item);
                } lector.Close();
            }
            return items;
        }

    }
}