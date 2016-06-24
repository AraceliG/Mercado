﻿using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void bienvenidaLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "" && textBoxUusario.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                if (this.userNameValido(textBoxUusario.Text) && this.comprobarLogin(textBoxPassword.Text, textBoxUusario.Text))
                {
                    MessageBox.Show("Ok el usernameestabien", "Error!", MessageBoxButtons.OK);
                    //ElegirRol elegirRol = new ElegirRol();
                    //elegirRol.ShowDialog();
                } 
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error!", MessageBoxButtons.OK);
                    return;
                }

            }
        }

        private bool userNameValido(string unUserName)
        {
            return Usuario.userNameValido(unUserName);
        }

        private bool comprobarLogin(string password, string username)
        {
            return Usuario.comprobarLogin(username, password);
        }

        private void textBoxUusario_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}