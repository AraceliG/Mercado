using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOConcepto
    {

        internal static Decimal conceptoPorVenta()
        {
            List<Concepto> conceptos = new List<Concepto>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.COD_CONCEPTO,C.DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.CONCEPTO C WHERE C.DESCRIPCION='Comision vender'", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Concepto concepto = new Concepto();
                    concepto.cod_concepto = (Decimal)lector["cod_concepto"];
                    concepto.descripcion = (String)lector["descripcion"];
                    conceptos.Add(concepto);
                }
            }
            return conceptos[0].cod_concepto;
        }

        internal static Decimal conceptoPorEnvio()
        {
            List<Concepto> conceptos = new List<Concepto>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.COD_CONCEPTO,C.DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.CONCEPTO C WHERE C.DESCRIPCION='Gastos Envio'", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Concepto concepto = new Concepto();
                    concepto.cod_concepto = (Decimal)lector["cod_concepto"];
                    concepto.descripcion = (String)lector["descripcion"];
                    conceptos.Add(concepto);
                }
            }
            return conceptos[0].cod_concepto;
           
        }
    }
}
