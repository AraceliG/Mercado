using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOCliente
    {

        public static Boolean existeDni(int dni)
        {
            List<Cliente> clienteList = new List<Cliente>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cli_dni", dni));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE C.USERID=U.USERID AND C.DNI=@cli_dni", "T", listaParametros);
            return createClienteListFromQuery(lector).Count >= 1;
        }


        private static List<Cliente> createClienteListFromQuery(SqlDataReader lector)
        {
            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.nombre = (String)lector["nombre"];
                    cliente.apellido = (String)lector["apellido"];
                    cliente.mail = (String)lector["email"];
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.calle = (String)lector["calle"];
                    cliente.telefono = (String)lector["telefono"];
                    cliente.fechaNacimiento = (DateTime)lector["fecha_nacimiento"];
                    cliente.descripcion = (String)lector["descripcion"];
                    cliente.fechaCreacion = (DateTime)lector["fechaCreacion"];
                    cliente.password = (String)lector["pass"];
                    cliente.username = (String)lector["username"];
                    cliente.habilitado = (Boolean)lector["habilitado"];
                    cliente.user_nro_intentos = (int)(decimal)lector["user_nro_intentos"];
                    cliente.calle = (String)lector["calle"];
                    cliente.num_calle = (int)(decimal)lector["num_calle"];
                    cliente.depto = (String)lector["depto"];
                    cliente.cod_postal = (String)lector["cod_postal"];
                    cliente.baja = (Boolean)lector["baja"];
                    cliente.piso = (int)(decimal)lector["piso"];
                    cliente.reputacion = (int)(decimal)lector["reputacion"];
                    cliente.userId = (int)(decimal)lector["userId"];
                    cliente.cod_tipo_doc = (int)(decimal)lector["cod_tipo_doc"];

                    clienteList.Add(cliente);
                }
                lector.Close();
            }
            return clienteList;
        }


        public static void crearCliente(Cliente c)
        {


            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", c.username));
            paramList.Add(new SqlParameter("@pass", c.password));
            paramList.Add(new SqlParameter("@email", c.mail));
            paramList.Add(new SqlParameter("@telefono", c.telefono));
            paramList.Add(new SqlParameter("@calle", c.calle));
            paramList.Add(new SqlParameter("@num_calle", c.num_calle));
            paramList.Add(new SqlParameter("@piso", c.piso));
            paramList.Add(new SqlParameter("@depto", c.depto));
            paramList.Add(new SqlParameter("@cod_postal", c.cod_postal));
            paramList.Add(new SqlParameter("@habilitado", 1));
            paramList.Add(new SqlParameter("@baja", false));
            paramList.Add(new SqlParameter("@reputacion", c.reputacion));
            paramList.Add(new SqlParameter("@user_nro_intentos", c.user_nro_intentos));
            paramList.Add(new SqlParameter("@dni", c.dni));
            paramList.Add(new SqlParameter("@cod_tipo_doc", 1));
            paramList.Add(new SqlParameter("@apellido ", c.apellido));
            paramList.Add(new SqlParameter("@nombre", c.nombre));
            paramList.Add(new SqlParameter("@fecha_nacimiento", c.fechaNacimiento));
            paramList.Add(new SqlParameter("@fechaCreacion", c.fechaCreacion));

            AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_altaCliente", paramList);

        }
        public static bool existeUsuario(Cliente client)
        {

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.DNI,T.DESCRIPCION,U.USERNAME  FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC", "T", new List<SqlParameter>());

            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.username = (String)lector["username"];
                    clienteList.Add(cliente);
                }
                lector.Close();
            }
            return (clienteList.Count() >= 1);

        }


        public static bool existeCliente(Cliente client)
        {

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.DNI.DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC",
            "T", new List<SqlParameter>());

            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.descripcion = (string)lector["descripcion"];
                    clienteList.Add(cliente);
                }
                lector.Close();
            }
            return (clienteList.Count() >= 1);

        }

        public static List<Cliente> devolverUsuarios()
        {


            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT T.COD_TIPO_DOC,U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO, C.FECHACREACION,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC", "T", new List<SqlParameter>());
            return createClienteListFromQuery(lector);
        }



        private static Cliente obtenerCliente(SqlDataReader reader)
        {
            Cliente client = new Cliente();

            client.dni = Convert.ToInt32(reader["dni"]);
            client.apellido = Convert.ToString(reader["apellido"]);
            client.nombre = Convert.ToString(reader["nombre"]);
            client.mail = Convert.ToString(reader["email"]);

            return client;
        }




        public static bool existeUsername(string username)
        {
            List<Cliente> clienteList = new List<Cliente>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cli_username", username));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T,NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE C.USERID=U.USERID AND U.USERNAME=@cli_username", "T", listaParametros);
            return createClienteListFromQuery(lector).Count >= 1;

        }

        public static void actualizarCliente(Cliente c)
        {
            List<SqlParameter> parametroList = new List<SqlParameter>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", c.username));
            paramList.Add(new SqlParameter("@pass", c.password));
            paramList.Add(new SqlParameter("@email", c.mail));
            paramList.Add(new SqlParameter("@telefono", c.telefono));
            paramList.Add(new SqlParameter("@calle", c.calle));
            paramList.Add(new SqlParameter("@num_calle", c.num_calle));
            paramList.Add(new SqlParameter("@piso", c.piso));
            paramList.Add(new SqlParameter("@depto", c.depto));
            paramList.Add(new SqlParameter("@cod_postal", c.cod_postal));
            paramList.Add(new SqlParameter("@dni", c.dni));
            parametroList.Add(new SqlParameter("@dni", c.dni));
            parametroList.Add(new SqlParameter("@cod_tipo_doc", 1));
            parametroList.Add(new SqlParameter("@apellido ", c.apellido));
            parametroList.Add(new SqlParameter("@nombre", c.nombre));
            parametroList.Add(new SqlParameter("@fecha_nacimiento", c.fechaNacimiento));
            parametroList.Add(new SqlParameter("@fechaCreacion", c.fechaCreacion));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.CLIENTE SET DNI=@dni,COD_TIPO_DOC=@cod_tipo_doc,APELLIDO=@apellido,NOMBRE=@nombre,FECHA_NACIMIENTO=@fecha_nacimiento,FECHACREACION=@fechaCreacion  FROM NOTHING_IS_IMPOSSIBLE.CLIENTE INNER JOIN NOTHING_IS_IMPOSSIBLE.USUARIO ON CLIENTE.USERID=USUARIO.USERID WHERE DNI=@dni ", "T", parametroList);
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USERNAME=@username,PASS=@pass,EMAIL=@email,TELEFONO=@telefono,CALLE=@calle,NUM_CALLE=@num_calle,PISO=@piso,DEPTO=@depto,COD_POSTAL=@cod_postal FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.CLIENTE  ON CLIENTE.USERID=USUARIO.USERID WHERE DNI=@dni  ", "T", paramList);

        }

        public static void bajaLogica(Cliente c)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@dni", c.dni));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.BAJA=1 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.CLIENTE  ON CLIENTE.USERID=USUARIO.USERID WHERE DNI=@dni", "T", paramList);
        }

        public static void altaLogica(Cliente c)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@dni", c.dni));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.BAJA=0 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.CLIENTE  ON CLIENTE.USERID=USUARIO.USERID WHERE DNI=@dni", "T", paramList);
        }

        public static void habilitar(Cliente c)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@dni", c.dni));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.HABILITADO=1,USUARIO.USER_NRO_INTENTOS=0 FROM NOTHING_IS_IMPOSSIBLE.USUARIO INNER JOIN NOTHING_IS_IMPOSSIBLE.CLIENTE  ON CLIENTE.USERID=USUARIO.USERID WHERE DNI=@dni", "T", paramList);
        }

        internal static bool tenesCliente(decimal userId)
        {
            List<Cliente> clienteList = new List<Cliente>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@userId", userId));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT nombre, apellido,dni FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C WHERE C.USERID=@userId", "T", listaParametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.nombre = (string)lector["nombre"];
                    cliente.apellido = (string)lector["apellido"];
                    clienteList.Add(cliente);
                }
            }
            return (clienteList.Count() >= 1);

        }

        public static Cliente getClientePorId(Decimal iduser){

            List<Cliente> clienteList = new List<Cliente>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@userId", iduser));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT USERNAME,REPUTACION,DNI,NOMBRE,APELLIDO,EMAIL, TELEFONO,CALLE,NUM_CALLE, PISO,DEPTO,COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE inner join NOTHING_IS_IMPOSSIBLE.USUARIO on CLIENTE.USERID=USUARIO.USERID WHERE CLIENTE.USERID=@userId", "T", listaParametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.nombre = (String)lector["nombre"];
                    cliente.apellido = (String)lector["apellido"];
                    cliente.mail = (String)lector["email"];
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.calle = (String)lector["calle"];
                    cliente.telefono = (String)lector["telefono"];
                    cliente.username = (String)lector["username"];
                    cliente.calle = (String)lector["calle"];
                    cliente.num_calle = (int)(decimal)lector["num_calle"];
                    cliente.depto = (String)lector["depto"];
                    cliente.cod_postal = (String)lector["cod_postal"];
                    cliente.piso = (int)(decimal)lector["piso"];
                    cliente.reputacion = (int)(decimal)lector["reputacion"];

                    clienteList.Add(cliente);
                   
                }
            }
            return clienteList[0];

    }



    }
}
