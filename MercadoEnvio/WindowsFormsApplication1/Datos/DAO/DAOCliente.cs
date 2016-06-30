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
public static
        void crearCliente(Cliente c) {

            List<SqlParameter> paramList = new List<SqlParameter>();

            paramList.Add(new SqlParameter("@nombre", c.nombre));
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
            paramList.Add(new SqlParameter("@baja", 0));
            paramList.Add(new SqlParameter("@reputacion", 0));
            paramList.Add(new SqlParameter("@user_nro_intentos", 0));
            paramList.Add(new SqlParameter("@dni", c.dni));
            paramList.Add(new SqlParameter("@cod_tipo_doc", c.tipo_doc));
            paramList.Add(new SqlParameter("@apellido ", c.apellido));
            paramList.Add(new SqlParameter("@fecha_nacimiento", c.fechaNacimiento));
            paramList.Add(new SqlParameter("@fechaCreacion", c.fechaCreacion));

            
            AccesoBaseDeDatos
            .ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_altaCliente s", paramList);
           
        }
        public static bool existeUsuario(Cliente client) {

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
            }
            return (clienteList.Count() >=1);

        }

        
        public static bool existeCliente(Cliente client) {

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.DNIT.DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC",
            "T", new List<SqlParameter>());

            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.tipo_doc = (string)lector["descripcion"];
                    clienteList.Add(cliente);
                }
            }
            return (clienteList.Count() >= 1);

        }

        public static List<Cliente> devolverUsuarios()
        {

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT U.USERNAME,U.PASS,U.USERID,U.HABILITADO,U.BAJA,U.REPUTACION,U.USER_NRO_INTENTOS,C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO, C.FECHACREACION,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC", "T", new List<SqlParameter>());

            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.nombre = (string)lector["nombre"];
                    cliente.apellido = (string)lector["apellido"];
                    cliente.mail = (string)lector["email"];
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.calle = (string)lector["calle"];
                    cliente.telefono = (string)lector["telefono"];
                    cliente.fechaNacimiento = (DateTime)lector["fecha_nacimiento"];
                    cliente.tipo_doc = (string)lector["descripcion"];
                    cliente.fechaCreacion = (DateTime)lector["fechaCreacion"];
                    cliente.password = (string)lector["pass"];
                    cliente.username = (String)lector["username"];
                    cliente.habilitado = (Boolean)lector["habilitado"];
                   cliente.cantFallidos = (int)(decimal)lector["user_nro_intentos"];
                    cliente.calle = (string)lector["calle"];
                    cliente.num_calle = (int)(decimal)lector["num_calle"];
                    cliente.depto = (string)lector["depto"];
                    cliente.cod_postal = (string)lector["cod_postal"];
                    cliente.baja = (Boolean)lector["baja"];
                    cliente.piso = (int)(decimal)lector["piso"];
                    cliente.reputacion= (int)(decimal)lector["reputacion"];
                    cliente.userId = (int)(decimal)lector["userId"];

                    clienteList.Add(cliente);
                }
            }
            return clienteList;
        }


        public static List<Cliente> AplicarFiltro(ClienteBuscador filtro)
        {
            //con datos presisos funciona solamente
            //no me toma los like
            //LIKE '*' + @DESCRIPCION + '*' según busque en internet

            string sql = @"SELECT C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO, C.FECHACREACION,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC AND (C.NOMBRE LIKE '%' + @nombre + '%') AND (C.APELLIDO LIKE '%' + @apellido + '%') AND (U.EMAIL LIKE '%' + @email + '%')";

            List<Cliente> list = new List<Cliente>();

            SqlCommand cmd = new SqlCommand(sql, AccesoBaseDeDatos.GetConnection());

            if (string.IsNullOrEmpty(filtro.nombre))
                cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@nombre", filtro.nombre);

            cmd.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(filtro.apellido) ? (object)DBNull.Value : filtro.apellido);
            cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(filtro.apellido) ? (object)DBNull.Value : filtro.email);

            cmd.Parameters.AddWithValue("@dni", filtro.dni);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(obtenerCliente(reader));
            }

            return list;
        }

        private static Modelo.Cliente obtenerCliente(SqlDataReader reader)
        {
            Cliente client = new Cliente();

            client.dni = Convert.ToInt32(reader["dni"]);
            client.apellido = Convert.ToString(reader["apellido"]);
            client.nombre = Convert.ToString(reader["nombre"]);
            client.mail = Convert.ToString(reader["email"]);

            return client;
        }

    }



}
