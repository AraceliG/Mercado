using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using System.Configuration;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Datos;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class FormularioCliente : FormUsuario
    {
        public Cliente cliente { get; set; }
        //public Cliente cliente 
        //ahora entiendo la existencia de la propiedad create, es por la modificacion
        private bool create;

        public FormularioCliente()
        {
           create = true;
            InitializeComponent();
        }

       public FormularioCliente(Cliente cliente)
        {
            create = false;
            this.cliente = cliente;
            
            InitializeComponent();

            textBox_apellido.Text = cliente.apellido;
            textBox_calle.Text = cliente.calle;
            textBox_nroDoc.Text = cliente.dni.ToString();
            textBox_usuario.Text = cliente.nombre;
            textBox_mail.Text = cliente.mail;
            textBox_psw.Text = cliente.password;
            text_telefono.Text = cliente.telefono;
            textBox_nro.Text = cliente.num_calle.ToString();
            textBox_piso.Text = cliente.piso.ToString();
            comboBox_tipoDoc.SelectedItem = cliente.tipo_doc;
            textBox_depto.Text = cliente.depto;
            textBox_cod_postal.Text = cliente.cod_postal;
            textBox_nombre.Text = cliente.nombre;
            textBox_nroDoc.ReadOnly = true;

        }
        


        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTipoDocumentos()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //agrego
                    comboBox_tipoDoc.Items.Add(reader.GetString(0));
                }

                comboBox_tipoDoc.SelectedIndex = 0;
            }

            //libero
            reader.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_tipoDoc.Items.Count <= 0)
            {
                cargarTipoDocumentos();
            }
        }

        private void button_fecha_Click(object sender, EventArgs e)
        {
            Calendario frmCal = new Calendario();
            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() < time)
                {
                    textBox_fecha.Text = frmCal.getFecha();
                }
                else
                {
                    MessageBox.Show("No es una fecha valida.", "Fecha De Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            frmCal.Dispose();  
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (create)
            {

                bool vacio = false;
                if (textBox_calle.Text.Length == 0)
                {
                    errorProvider_calle.SetError(textBox_calle, "Por favor ingrese su dirección");
                    vacio = true;
                }
                else
                {
                    errorProvider_calle.Clear();
                }
                if (textBox_nro.Text.Length == 0)
                {
                    nume_calle.SetError(textBox_nro, "Por favor ingrese número de domicilio");
                    vacio = true;
                }
                else { nume_calle.Clear(); }
                if (textBox_fecha.Text.Length == 0)
                {
                    errorProvider_fechaNac.SetError(textBox_fecha, "Por favor ingrese fecha de nacimiento");
                    vacio = true;
                }
                else { errorProvider_fechaNac.Clear(); }
                //es el de fecha creacion textbox1
                if (textBox1.Text.Length == 0)
                {
                    errorProvider_fechaCreacion.SetError(textBox1, "Por favor ingrese fecha de nacimiento");
                    vacio = true;
                }
                else { errorProvider_fechaCreacion.Clear(); }
                if (textBox_nombre.Text.Length == 0)
                {
                    errorProvider_nombre.SetError(textBox_nombre, "Por favor ingrese nombre");
                    vacio = true;
                }
                else { errorProvider_nombre.Clear(); }

                if (textBox_apellido.Text.Length == 0)
                {
                    errorProvider_ape.SetError(textBox_apellido, "Por favor ingrese apellido");
                    vacio = true;
                }
                else { errorProvider_ape.Clear(); }

                if (comboBox_tipoDoc.Text.Length == 0)
                {
                    errorProvider_tipo_doc.SetError(comboBox_tipoDoc, "Por favor ingrese tipo de documento");
                    vacio = true;
                }
                else { errorProvider_tipo_doc.Clear(); }

                if (textBox_nroDoc.Text.Length == 0)
                {
                    errorProvider_nro_doc.SetError(textBox_nroDoc, "Por favor ingrese dni");
                    vacio = true;
                }
                else { errorProvider_nro_doc.Clear(); }
                if (textBox_usuario.Text.Length == 0)
                {
                    errorProvider_usuario.SetError(textBox_usuario, "Por favor ingrese nombre de usuario de su cuenta");
                    vacio = true;
                }
                else { errorProvider_usuario.Clear(); }
                if (textBox_psw.Text.Length == 0)
                {
                    errorProvider_psw.SetError(textBox_psw, "Por favor ingrese contraseña");
                    vacio = true;
                }
                else { errorProvider_psw.Clear(); }
                if (textBox_mail.Text.Length == 0)
                {
                    errorProvider_mail.SetError(textBox_mail, "Por favor ingrese mail");
                    vacio = true;
                }
                else { errorProvider_mail.Clear(); }


                if (vacio) return;

                if (DAOCliente.existeDni(Convert.ToInt32(textBox_nroDoc.Text)))
                {
                    MessageBox.Show("Ya existe un usuario con ese tipo y número de dni.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (DAOCliente.existeUsername(textBox_usuario.Text))
                    {
                        MessageBox.Show("Existe una cuenta con ese nombre de usuario, por favor ingrese uno diferente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        this.crearCliente();
                        MessageBox.Show("se creo exitosamente al cliente!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }

            else {

                cliente.apellido = textBox_apellido.Text;
                cliente.nombre = textBox_nombre.Text;
                cliente.dni = Int32.Parse(textBox_nroDoc.Text);
   //no dejar  fecha de nacimiento vacio
                cliente.fechaNacimiento = Convert.ToDateTime(textBox_fecha.Text);
                cliente.mail = textBox_mail.Text;
                cliente.calle = textBox_calle.Text;
                cliente.telefono = text_telefono.Text;
                cliente.fechaCreacion = Convert.ToDateTime(textBox1.Text);
                cliente.password = textBox_psw.Text;
                cliente.username = textBox_usuario.Text;
                cliente.calle = textBox_calle.Text;
                cliente.num_calle = Convert.ToInt32(textBox_nro.Text);
                cliente.depto = textBox_depto.Text;
                cliente.cod_postal = textBox_cod_postal.Text;
                if (textBox_piso.Text.Length == 0)
                {
                    cliente.piso = 0;
                }
                else
                {
                    cliente.piso = Convert.ToInt32(textBox_piso.Text);
                }
                cliente.reputacion = 0;
                cliente.user_nro_intentos = 0;
                cliente.tipo_doc = comboBox_tipoDoc.SelectedItem.ToString();
                this.cliente = cliente;
                DAOCliente.actualizarCliente(cliente);
                this.Close();
            }
        }

        private void crearCliente()
        { 
            Cliente cliente = new Cliente();
             cliente.apellido = textBox_apellido.Text;
            cliente.nombre = textBox_nombre.Text;
            cliente.dni = Int32.Parse(textBox_nroDoc.Text);
          cliente.fechaNacimiento = Convert.ToDateTime(textBox_fecha.Text);
            cliente.mail = textBox_mail.Text;
            cliente.calle = textBox_calle.Text;
            cliente.telefono = text_telefono.Text;
           cliente.fechaCreacion = Convert.ToDateTime(textBox1.Text);
            cliente.password = textBox_psw.Text;
            cliente.username = textBox_usuario.Text;
            cliente.calle = textBox_calle.Text;
          cliente.num_calle = Convert.ToInt32(textBox_nro.Text);
            cliente.depto = textBox_depto.Text;
            cliente.cod_postal = textBox_cod_postal.Text;
            if(textBox_piso.Text.Length == 0){
                cliente.piso=0;}
                else{
                    cliente.piso = Convert.ToInt32(textBox_piso.Text);
                }
            cliente.reputacion = 0;
            cliente.user_nro_intentos = 0;
            cliente.tipo_doc = comboBox_tipoDoc.SelectedItem.ToString();
            DAOCliente.crearCliente(cliente);
            
        }

        private void textBox_psw_TextChanged_1(object sender, EventArgs e)
        {

        }



                
            
            }
        }
