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

        internal static List<Factura> cumpleConFiltros(string dni, string cuit, string numFact, string importeDesde, string importeHasta, DateTime fechaDesde, DateTime fechaHasta, bool pagoEfectivo)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            //LAS FECHAS NO SE PASAN VACIAS
            listaParametros.Add(new SqlParameter("@fechaDesde", fechaDesde));
            listaParametros.Add(new SqlParameter("@fechaHasta", fechaHasta));

            String base_query = "";
            String base_query_usuario = "";
            String base_query_factura = "";

            if (!String.IsNullOrEmpty(dni) || !String.IsNullOrEmpty(cuit))
            {
                base_query += "SELECT  nro_factura,cod_publicacion,F.userId,fecha,total,forma_pago_desc from NOTHING_IS_IMPOSSIBLE.Factura F";

            }
            else
            {
                base_query += "SELECT  nro_factura,cod_publicacion,F.userId,fecha,total,forma_pago_desc from NOTHING_IS_IMPOSSIBLE.Factura F where F.NRO_FACTURA > 0";

            }

            if (!String.IsNullOrEmpty(dni))
            {
                listaParametros.Add(new SqlParameter("@dni", Convert.ToDecimal(dni)));
                base_query_usuario += ",NOTHING_IS_IMPOSSIBLE.Cliente C where c.userId=f.userId and c.dni=@dni";
            }

            if (!String.IsNullOrEmpty(cuit))
            {
                listaParametros.Add(new SqlParameter("@cuit", cuit));
                base_query_usuario += ",NOTHING_IS_IMPOSSIBLE.Empresa E where REPLACE((E.CUIT),'-','')=@cuit and e.userId=f.userId";
            }

            //LAS FECHAS NO SE PASAN VACIAS

            base_query_factura += " and CONVERT(date, fecha,103) <= CONVERT(date,@fechaHasta,103)";
            base_query_factura += "and CONVERT(date, fecha,103) >= CONVERT(date,@fechaDesde,103)";

            if (importeDesde.Length != 0)
            {
                listaParametros.Add(new SqlParameter("@importeDesde", Convert.ToInt32(importeDesde)));
                base_query_factura += " and TOTAL >= @importeDesde ";
            }

            if (importeHasta.Length != 0)
            {
                listaParametros.Add(new SqlParameter("@importeHasta", Convert.ToInt32(importeHasta)));
                base_query_factura += " and TOTAL <= @importeHasta ";

            }

            if (numFact.Length != 0)
            {
                listaParametros.Add(new SqlParameter("@numFactura", Convert.ToInt32(numFact)));
                base_query_factura += "  and NRO_FACTURA=@numFactura  ";
            }

            if (pagoEfectivo)
            {
                base_query_factura += "  and FORMA_PAGO_DESC='Efectivo' ";
            }

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(base_query + base_query_usuario + base_query_factura, "T", listaParametros);

            List<Factura> facturas = new List<Factura>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Factura factura = new Factura();
                    factura.nro_factura = (decimal)lector["nro_factura"];
                    factura.cod_publicacion = (decimal)lector["cod_publicacion"];
                    factura.userId = (int)(decimal)lector["userId"];
                    factura.total = (int)(decimal)lector["total"];
                    factura.forma_pago_desc = (String)lector["forma_pago_desc"];
                    factura.fecha = (DateTime)lector["fecha"];

                    facturas.Add(factura);
                }
                lector.Close();
            }
            return facturas;

        }



        internal static List<Factura> getFacturas()
        {

            List<Factura> facturas = new List<Factura>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.FACTURA", "T", listaParametros);
   
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Factura factura = new Factura();
                    factura.nro_factura = (decimal)lector["nro_factura"];
                    factura.cod_publicacion = (decimal)lector["cod_publicacion"];
                    factura.userId = (int)(decimal)lector["userId"];
                    factura.total = (int)(decimal)lector["total"];
                    factura.forma_pago_desc = (String)lector["forma_pago_desc"];
                    factura.fecha = (DateTime)lector["fecha"];

                    facturas.Add(factura);
                }
                lector.Close();
            }
            return facturas;
        }
             
            
    }
}


