using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOUsuario
    {

        public static void getUsuario(string user, string pass, Usuario us){

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userName", user));
            paramList.Add(new SqlParameter("@pass", pass));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Usuario WHERE username=@userName AND pass=@pass", "T", paramList);
            if (lector.HasRows)
            {
                lector.Read();
                us.username = user;
                us.userId = (decimal)lector["userId"];
                us.pass = pass;
                lector.Close();
            }
    
    }
        // Method
        public static bool userNameValido(string userName)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userName", userName));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Usuario WHERE username=@userName", "T", paramList);
            if (lector.HasRows)
            {
                return true;
            }
            return false;
        }

        // Method
        public static bool comprobarLogin(string userName, string pass)
        {
            decimal resultado_sp;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@username", userName));
            paramList.Add(new SqlParameter("@pass", pass));

            SqlParameter outputIdParam = new SqlParameter("@ret", SqlDbType.Int)
            { 
                Direction = ParameterDirection.Output 
            };

            paramList.Add(outputIdParam);

            resultado_sp = (int) AccesoBaseDeDatos.ExecStoredProcedure("NOTHING_IS_IMPOSSIBLE.sp_login", paramList);

            if (resultado_sp == 1)
            {
                return true;
            }
            return false;
        }

        internal static void getUsuario(string userName, Modelo.Usuario usuario)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userName", userName));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Usuario WHERE username=@userName", "T", paramList);            
            if (lector.HasRows)
            {
                lector.Read();
                usuario.username = userName;
                usuario.userId = (decimal)lector["userId"];
                lector.Close();
            }
        }

        public static bool contraseñaCorrecta(Usuario usuario)
        {  
            List<Usuario> clienteList = new List<Usuario>();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@password", usuario.pass));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT U.USERNAME,U.PASS FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.PASS=@password", "T", new List<SqlParameter>());
           
            
            return createUsuarioListFromQuery(lector).Count >= 1;
          
        }

        private static List<Usuario> createUsuarioListFromQuery(SqlDataReader lector)
        {
             List<Usuario> usuarios = new List<Usuario>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Usuario user = new Usuario();
                    user.username = (String)lector["username"];
                    user.pass = (String)lector["pass"];
                    user.userId = (int)(decimal)lector["userId"];
                    user.user_nro_intentos = (int)(decimal)lector["user_nro_intentos"];

                    usuarios.Add(user);
                }
                lector.Close();
            }
            return usuarios;
        }
        
        public static bool contraseñaCorrecta(string user, string pass)
        {
            
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@password",pass));
            listaParametros.Add(new SqlParameter("@username", user));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.USERNAME=@username AND U.PASS=@password", "T", listaParametros);
            return createUsuarioListFromQuery(lector).Count >= 1;
        }

        public  static bool estaHabilitado(Usuario u)
        {
            
            List<SqlParameter> listaParametros = new List<SqlParameter>();
           // listaParametros.Add(new SqlParameter("@us_intentos", u.user_nro_intentos));
            listaParametros.Add(new SqlParameter("@username", u.username));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.USERNAME=@username AND U.USER_NRO_INTENTOS < 3 ", "T", listaParametros);
            return createUsuarioListFromQuery(lector).Count >= 1;
            
        }

        public  static void reiniciarFallidos(Usuario usuario)

          {
               List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@nombre", usuario.username));
                    AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.USER_NRO_INTENTOS=0 WHERE USUARIO.USERNAME=@nombre", "T", paramList);
          }

        internal static void actualizarFallidos(Usuario usuario)
          {    Int32 cant=DAOUsuario.cantidadDefallidos(usuario);
              List<SqlParameter> paramList = new List<SqlParameter>();
              paramList.Add(new SqlParameter("@us_intentos", cant+1));
              paramList.Add(new SqlParameter("@nombre", usuario.username));

              AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.USER_NRO_INTENTOS=@us_intentos WHERE USUARIO.USERNAME=@nombre", "T", paramList);
          }

        public static bool intentosFallidosCompletos(Usuario u)
          {   
              List<SqlParameter> listaParametros = new List<SqlParameter>();
              listaParametros.Add(new SqlParameter("@username", u.username));
              SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.USERNAME=@username AND U.USER_NRO_INTENTOS > 3 ", "T", listaParametros);
              return createUsuarioListFromQuery(lector).Count >= 1;
          }

        public static Int32 cantidadDefallidos(Usuario u) 
        {
          List<Usuario> usuarios = new List<Usuario>();
          List<SqlParameter> listaParametros = new List<SqlParameter>();
          listaParametros.Add(new SqlParameter("@username", u.username));
          SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO U WHERE U.USERNAME=@username", "T", listaParametros);
          usuarios = createUsuarioListFromQuery(lector);
          return usuarios[0].user_nro_intentos;
  
        }

        public static void cambiarContraseña(string passNuevo, Usuario user)
        {
          List<SqlParameter> paramList = new List<SqlParameter>();
          paramList.Add(new SqlParameter("@pass", passNuevo));
          paramList.Add(new SqlParameter("@nombre", user.username));

          AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.PASS=@pass WHERE USUARIO.USERNAME=@nombre", "T", paramList);
        }


  internal static void cambiarReputacionDe(decimal userIdVendedor, decimal nuevaReputacion)
  {

      List<SqlParameter> paramList = new List<SqlParameter>();
      paramList.Add(new SqlParameter("@userVendedor", userIdVendedor));
      paramList.Add(new SqlParameter("@nuevaReputacion", nuevaReputacion));

      AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO SET USUARIO.REPUTACION=@nuevaReputacion WHERE USUARIO.USERID=@userVendedor", "T", paramList);
  }
    }
}
