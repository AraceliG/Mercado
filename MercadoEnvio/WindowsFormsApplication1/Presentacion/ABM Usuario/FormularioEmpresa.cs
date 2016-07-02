﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class FormularioEmpresa : FormUsuario
    {
        public FormularioEmpresa()
        {
            InitializeComponent();
        }

        private void FormularioEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
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
            if (text_cuit.Text.Length == 0)
            {
                error_cuit.SetError(text_cuit, "Por favor ingrese cuit");
                vacio = true;
            }
            else { error_cuit.Clear(); }
            if (textBox_razon_social.Text.Length == 0)
            {
                error_razon_social.SetError(textBox_razon_social, "Por favor ingrese mail");
                vacio = true;
            }
            else { errorProvider_mail.Clear(); }

            if (vacio) return;

            if (DAOEmpresa.existeEmpresa(text_cuit.Text))
            {
                MessageBox.Show("Ya existe empresa con ese cuit.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (DAOEmpresa.existeRazonSocial(textBox_razon_social.Text)){
                    MessageBox.Show("Ya existe empresa con esa razón social.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
                else{

                if (DAOEmpresa.existeUsername(textBox_usuario.Text))
                {
                    MessageBox.Show("Existe una cuenta con ese nombre de usuario, por favor ingrese uno diferente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    this.crearEmpresa();
                    MessageBox.Show("se creo exitosamente la empresa!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        }

        private void crearEmpresa()
        {
            Empresa empresa = new Empresa();
            empresa.ciudad = textBox_ciudad.Text;
            empresa.razon_social = textBox_razon_social.Text;
            empresa.mail = textBox_mail.Text;
            empresa.calle = textBox_calle.Text;
            empresa.telefono = text_telefono.Text;
            empresa.password = textBox_psw.Text;
            empresa.username = textBox_usuario.Text;
            empresa.calle = textBox_calle.Text;
            empresa.num_calle = Convert.ToInt32(textBox_nro.Text);
            empresa.depto = textBox_depto.Text;
            empresa.cod_postal = textBox_cod_postal.Text;
            if (textBox_piso.Text.Length == 0)
            {
                empresa.piso = 0;
            }
            else
            {
                empresa.piso = Convert.ToInt32(textBox_piso.Text);
            }
            empresa.reputacion = 0;
            empresa.user_nro_intentos = 0;
            empresa.cuit = text_cuit.Text;
            empresa.nombre_contacto = textBox_nombre_de_contacto.Text;
            DAOEmpresa.crearEmpresa(empresa);

        }

        private void text_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_nro_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void textBox_nro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_nro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void text_cuit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
