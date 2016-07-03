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
                base_query += " AND UPPER(E.RAZON_SOCIAL) LIKE UPPER('%" + razon_social + "%') ";
            }

            if (!String.IsNullOrEmpty(cuit))
            {
                base_query += " AND REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('%" + cuit + "%')";
            }

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(base_query, "T", new List<SqlParameter>());
            return createEmpresaListFromQuery(lector);
        }
        public static List<Empresa> devolverUsuariosEmpresas(){

           
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

       

        private static List<Empresa> createEmpresaListFromQuery(SqlDataReader lector)
        {
            List<Empresa> empresaList = new List<Empresa>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa empresa = new Empresa();
                    empresa.razon_social = (string)lector["razon_social"];
                    empresa.ciudad = lector["ciudad"] != DBNull.Value ? (String)lector["telefono"] : "";
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

        public static bool existeUsername(string username)
        {
            List<Empresa> clienteList = new List<Empresa>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cli_username", username));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID AND U.USERNAME=@cli_username", "T", listaParametros);
            return createEmpresaListFromQuery(lector).Count >= 1;

        }

        public static bool existeEmpresa(string cuit) {

            List<Empresa> clienteList = new List<Empresa>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID AND REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('" + cuit + "')", "T", listaParametros);
            return createEmpresaListFromQuery(lector).Count >= 1;
        }

        public static bool existeRazonSocial(string razonSocial) {
            List<Empresa> clienteList = new List<Empresa>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@emp_razonSocial", razonSocial));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.EMPRESA E,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE E.USERID=U.USERID AND E.RAZON_SOCIAL=@emp_razonSocial", "T", listaParametros);
            return createEmpresaListFromQuery(lector).Count >= 1;

        
        }

        internal static void crearEmpresa(Empresa e)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", e.username));
            paramList.Add(new SqlParameter("@pass", e.password));
            paramList.Add(new SqlParameter("@email", e.mail));
            paramList.Add(new SqlParameter("@telefono", e.telefono));
            paramList.Add(new SqlParameter("@calle",e.calle));
            paramList.Add(new SqlParameter("@num_calle",e.num_calle));
            paramList.Add(new SqlParameter("@piso",e.piso));
            paramList.Add(new SqlParameter("@depto",e.depto));
            paramList.Add(new SqlParameter("@cod_postal",e.cod_postal));
            paramList.Add(new SqlParameter("@habilitado",1));
            paramList.Add(new SqlParameter("@baja",false));
            paramList.Add(new SqlParameter("@reputacion",e.reputacion));
            paramList.Add(new SqlParameter("@user_nro_intentos",e.user_nro_intentos));
            paramList.Add(new SqlParameter("@cuit", e.cuit));
            paramList.Add(new SqlParameter("@razon_social ", e.razon_social));
            paramList.Add(new SqlParameter("@nombre_contaco", e.nombre_contacto));
            paramList.Add(new SqlParameter("@cod_rubro_principal",1));
            paramList.Add(new SqlParameter("@ciudad", e.ciudad));

            AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_altaEmpresa", paramList);
        }

        public static void bajaLogica(Empresa e)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cuit", e.cuit));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.BAJA=1 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.EMPRESA  ON EMPRESA.USERID=USUARIO.USERID WHERE REPLACE(UPPER(EMPRESA.CUIT),'-','') LIKE UPPER('"+e.cuit.Replace("-","")+"')", "T", paramList);
        
        }

        public static void actualizarCliente(Empresa e)
        {
            List<SqlParameter> parametroList = new List<SqlParameter>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", e.username));
            paramList.Add(new SqlParameter("@pass", e.password));
            paramList.Add(new SqlParameter("@email", e.mail));
            paramList.Add(new SqlParameter("@telefono", e.telefono));
            paramList.Add(new SqlParameter("@calle", e.calle));
            paramList.Add(new SqlParameter("@num_calle", e.num_calle));
            paramList.Add(new SqlParameter("@piso", e.piso));
            paramList.Add(new SqlParameter("@depto", e.depto));
            paramList.Add(new SqlParameter("@cod_postal", e.cod_postal));
            paramList.Add(new SqlParameter("@cuit", e.cuit));
            parametroList.Add(new SqlParameter("@cuit", e.cuit));
            parametroList.Add(new SqlParameter("@razon_social",e.razon_social ));
            parametroList.Add(new SqlParameter("@nombre_contacto ", e.nombre_contacto));
            parametroList.Add(new SqlParameter("@ciudad", e.ciudad));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.EMPRESA SET CUIT=@cuit,RAZON_SOCIAL=@razon_social,NOMBRE_CONTACO=@nombre_contacto,CIUDAD=@ciudad FROM NOTHING_IS_IMPOSSIBLE.EMPRESA INNER JOIN NOTHING_IS_IMPOSSIBLE.USUARIO ON EMPRESA.USERID=USUARIO.USERID WHERE REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('%" + e.cuit + "%') ", "T", parametroList);
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USERNAME=@username,PASS=@pass,EMAIL=@email,TELEFONO=@telefono,CALLE=@calle,NUM_CALLE=@num_calle,PISO=@piso,DEPTO=@depto,COD_POSTAL=@cod_postal FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.EMPRESA  ON EMPRESA.USERID=USUARIO.USERID WHERE REPLACE(UPPER(E.CUIT),'-','') LIKE UPPER('%" + e.cuit + "%')  ", "T", paramList);
            
        }

        public static void altaLogica(Empresa e)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cuit", e.cuit));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.BAJA=0 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.EMPRESA  ON EMPRESA.USERID=USUARIO.USERID WHERE REPLACE(UPPER(EMPRESA.CUIT),'-','') LIKE UPPER('" + e.cuit.Replace("-", "") + "')", "T", paramList);

        }

        public  static void habilitar(Empresa emp)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cuit", emp.cuit));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.HABILITADO=1,USUARIO.USER_NRO_INTENTOS=0 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.EMPRESA ON EMPRESA.USERID=USUARIO.USERID WHERE REPLACE(UPPER(EMPRESA.CUIT),'-','') LIKE UPPER('" + emp.cuit.Replace("-", "") + "')", "T", paramList);
        }

        internal static void cargarRubros()
        {
            throw new NotImplementedException();
        }
    }
}
