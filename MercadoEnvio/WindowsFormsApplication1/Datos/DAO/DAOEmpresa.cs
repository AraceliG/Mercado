using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOEmpresa
    {

        public static List<Empresa> buscarPorFiltros(string cuit, string razon_social, string email)
        {
            List<Empresa> lc = new List<Empresa>();

            if (String.IsNullOrEmpty(cuit) && String.IsNullOrEmpty(razon_social) && String.IsNullOrEmpty(email))
            {

                String query = String.Format("SELECT U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,E.CUIT,E.RAZON_SOCIAL,E.NOMBRE_CONTACO,E.CIUDAD,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID");
                SqlDataReader lectorCompleto = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
                return createEmpresaListFromQuery(lectorCompleto);
            }


            String base_query = "SELECT U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,E.CUIT,E.RAZON_SOCIAL,E.NOMBRE_CONTACO,E.CIUDAD,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID ";
            if (!String.IsNullOrEmpty(email))
            {
                base_query += " AND UPPER(U.EMAIL) LIKE UPPER('%" + email + "%')";
            }

            if (!String.IsNullOrEmpty(razon_social))
            {
                base_query += " AND UPPER (E.RAZON_SOCIAL) LIKE UPPER('%" + razon_social + "%') ";
            }

            if (!String.IsNullOrEmpty(cuit))
            {
                base_query += " AND REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('%" + cuit + "%')";
            }

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(base_query, "T", new List<SqlParameter>());
            return createEmpresaListFromQuery(lector);
        }
        public static List<Empresa> devolverUsuariosEmpresas(){

          /*  
           * SqlCommand cm = new SqlCommand();
            cm.Connection = AccesoBaseDeDatos.GetConnection();
            cm.CommandType = CommandType.Text;
            cm.CommandText = consulta(razonSocial,email,cuit);
            cm.ExecuteNonQuery();

            DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cm);
           da.Fill(dt);
           return dt;
  
            */


            //AND REPLACE(E.CUIT,'-','')= '" +cuit + " para eliminar guiones
           
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,E.CUIT,E.RAZON_SOCIAL,E.NOMBRE_CONTACO,E.CIUDAD,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID", "T", new List<SqlParameter>());
            return createEmpresaListFromQuery(lector);
            
        
        }

private static string consulta(String razonSocial,String mail, String cuit)
{
    string consulta = consulta = "SELECT E.USERID,U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,E.CUIT,E.RAZON_SOCIAL,E.NOMBRE_CONTACO,E.CIUDAD,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID ";
    if (razonSocial == "" && mail == "" && cuit == "")
    {
        return consulta;
        
    }
    else
    {

        if (razonSocial != "")
        {
            consulta += " AND UPPER REPLACE((E.RAZON_SOCIAL),'Nº','')) LIKE UPPER('%" + razonSocial + "%') ";
        }
        if (mail != "")
        {
            consulta += " AND REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('%" + cuit + "%')";
        }
        if (cuit != "")
        {
            consulta += " AND UPPER(U.EMAIL) LIKE UPPER('%" + mail + "%')";
        }
    }

    return consulta;
}

        //private static String consulta() { 
       

        private static List<Empresa> createEmpresaListFromQuery(SqlDataReader lector)
        {
            List<Empresa> empresaList = new List<Empresa>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa empresa = new Empresa();
                    empresa.razon_social = (string)lector["razon_social"];
                    empresa.ciudad = lector["ciudad"] != DBNull.Value ? (String)lector["cli_telefono"] : "";
                    //A LA EMPRESA NO LE PUSIMOS FECHA DE CREACION
                    //empresa.fechaCreacion = (DateTime)lector["fechaCreacion"];
                    empresa.password = (string)lector["pass"];
                    empresa.username = (String)lector["username"];
                    empresa.habilitado = (Boolean)lector["habilitado"];
                    empresa.cantFallidos = (int)(decimal)lector["user_nro_intentos"];
                    empresa.calle = (string)lector["calle"];
                    empresa.num_calle = (int)(decimal)lector["num_calle"];
                    empresa.depto = (string)lector["depto"];
                    empresa.cod_postal = (string)lector["cod_postal"];
                    empresa.baja = (Boolean)lector["baja"];
                    empresa.piso = (int)(decimal)lector["piso"];
                    empresa.reputacion = (int)(decimal)lector["reputacion"];
                    empresa.userId = (int)(decimal)lector["userId"];
                    empresa.mail=(String)lector["email"];
                    empresa.telefono = (string)lector["telefono"];
                    empresa.cuit = (String)lector["cuit"];
                    empresaList.Add(empresa);
                }
            }
            return empresaList;
        }

    }
}
