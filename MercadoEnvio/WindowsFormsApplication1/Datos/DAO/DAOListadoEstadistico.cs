using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOListadoEstadistico
    {
        public DataTable VendConMayorMontoFact(string fechaIni, string fechaFin)
        {
            string query = "SELECT * FROM " +
"  (select  top 5 U.USERID,sum(f.total) AS Importe_Total,count(U.USERID) AS CANTIDAD_Facturas  from NOTHING_IS_IMPOSSIBLE.Usuario U inner join NOTHING_IS_IMPOSSIBLE.Factura F " +
" on  F.userId=u.userId WHERE F.fecha BETWEEN CONVERT(datetime, '" + fechaIni + "', 120) " +
" and CONVERT(datetime,'" + fechaFin + "', 120) group by U.userId ORDER BY Importe_Total desc) L " +
" inner join " +
" ( select  y.userId ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido,cuit,razon_social from " +
" (select  u.userid,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido " +
    "from NOTHING_IS_IMPOSSIBLE.Usuario U FULL outer JOIN  NOTHING_IS_IMPOSSIBLE.Cliente C on U.userId=C.userId) Y FULL OUTER JOIN " +
    " NOTHING_IS_IMPOSSIBLE.Empresa E on Y.USERID=E.userId) x on x.userId=l.userId " +
" order by Importe_Total desc";


            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;

        }

        public DataTable VendConMayorCantFact(string fechaIni, string fechaFin)
        {
            string query = "SELECT * FROM" +
                " (select  top 5 U.USERID,sum(f.total) AS Importe_Total,count(U.USERID) AS CANTIDAD_Facturas " +
             "from NOTHING_IS_IMPOSSIBLE.Usuario U inner join NOTHING_IS_IMPOSSIBLE.Factura F " +
 "on  F.userId=u.userId WHERE F.fecha BETWEEN CONVERT(datetime,'" + fechaIni + "', 120)" +
                                     "and CONVERT(datetime,'" + fechaFin + "', 120)" +
 "group by U.userId ORDER BY CANTIDAD_Facturas desc) L inner join " +
 "( select  y.userId,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido,cuit,razon_social from " +
 "(select  u.userid,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido  from NOTHING_IS_IMPOSSIBLE.Usuario U FULL outer JOIN  NOTHING_IS_IMPOSSIBLE.Cliente C on U.userId=C.userId)" +
 " Y FULL OUTER JOIN NOTHING_IS_IMPOSSIBLE.Empresa E on Y.USERID=E.userId) x " +
 "on x.userId=l.userId order by CANTIDAD_Facturas desc";

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;

        }

        public DataTable cliesMayorCantProdComprados(string fechaIni, string fechaFin, string rubro)
        {
            string query = " SELECT * FROM (SELECT TOP 5 SUM(CANTIDAD) AS TOTAL_CANTIDAD_COMPRADO,T.USERID FROM " +
" (SELECT C.CANTIDAD,C.USERID FROM NOTHING_IS_IMPOSSIBLE.COMPRA C, NOTHING_IS_IMPOSSIBLE.RUBROPUBLICACION RP, NOTHING_IS_IMPOSSIBLE.RUBRO R  WHERE RP.COD_PUBLICACION=C.COD_PUBLICACION AND R.COD_RUBRO=RP.COD_RUBRO AND R.DESCRIPCION_LARGA='" + rubro + "' " +
" AND C.FECHA BETWEEN CONVERT(datetime, '" + fechaIni + "', 120) and CONVERT(datetime,'" + fechaFin + "', 120)) T " +
"GROUP BY T.USERID ORDER BY TOTAL_CANTIDAD_COMPRADO DESC) L inner join " +
" ( (select  u.userid,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido  from NOTHING_IS_IMPOSSIBLE.Usuario U FULL outer JOIN  NOTHING_IS_IMPOSSIBLE.Cliente C on U.userId=C.userId) " +
 " ) x on x.userId=l.userId order by  TOTAL_CANTIDAD_COMPRADO desc ";


            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable vendMayorCantProdNoVendidos(string fechaIni, string fechaFin, string visibilidad)
        {
            string query = " SELECT * FROM " +
" (SELECT TOP 5 * FROM (select p.userId,sum(STOCK) AS Total_STOCK from NOTHING_IS_IMPOSSIBLE.pUBLICACION P " +
" inner join NOTHING_IS_IMPOSSIBLE.VISIBILIDAD V  on  V.COD_VISIBILIDAD=P.COD_VISIBILIDAD " +
 " WHERE STOCK>0 and comision_publicar= " + DAOVisibilidad.getComisionVisibilidadPorDescripcion(visibilidad) + "" +
" and p.fecha_inicio BETWEEN CONVERT(datetime, '" + fechaIni + "', 120) and CONVERT(datetime,'" + fechaFin + "', 120) " +
" GROUP BY p.userId) pV ORDER BY PV.TOTAL_STOCK DESC) L " +
"inner join ( select  y.userId,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido,cuit,razon_social from " +
"(select  u.userid,username ,email, telefono,calle,num_calle,piso,depto,cod_postal, dni,nombre,apellido  from NOTHING_IS_IMPOSSIBLE.Usuario U FULL outer JOIN NOTHING_IS_IMPOSSIBLE.Cliente C on U.userId=C.userId) " +
 " Y FULL OUTER JOIN GD1C2016.NOTHING_IS_IMPOSSIBLE.Empresa E on Y.USERID=E.userId )" +
            " x on x.userId=l.userId order by Total_STOCK desc ";


            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }
    }
}

