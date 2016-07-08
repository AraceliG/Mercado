using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ABM_Rol
{
    public partial class NuevoOModificarRol : FormBaseUTN
    {
        private bool create;
        private string nombreAnteriorRol;
        private Rol rol;

        public NuevoOModificarRol()
        {
            this.create = false;
            InitializeComponent();

        }

        public NuevoOModificarRol(Rol rol)
        {
            this.create = true;
            InitializeComponent();
            textBox_nombreRol.Text = rol.nombre;
            this.nombreAnteriorRol = rol.nombre;
            this.rol = rol;
        }

        private void NuevoOModificarRol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            if (textBox_nombreRol.Text.Length == 0)
            {
                error_nombreRol.SetError(textBox_nombreRol, "debe ingresar el nombre del rol");
                vacio = true;
            }
            if (vacio) return;
            if (create)
            {
                Rol r = new Rol();
                r.nombre = textBox_nombreRol.Text;
                if (r.existeNombre())
                {
                    MessageBox.Show("ya existe ese nombre de rol, por favor elija otro", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    r.cambiarNombre(nombreAnteriorRol);
                    MessageBox.Show("El nombre del Rol ha sido modificado", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("no puede existir rol sin funcionalidad debe agregar una", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

            bool vacio = false;
            if (textBox_nombreRol.Text.Length == 0)
            {
                error_nombreRol.SetError(textBox_nombreRol, "debe ingresar el nombre del rol");
                vacio = true;
            }
            if (vacio) return;
            if (create)
            {
                if (!textBox_nombreRol.Text.Equals(nombreAnteriorRol))
                {
                    MessageBox.Show("este botón es para agregar funcionalidad al rol, para cambiar el nombre debe presionar el botón aceptar que se encuentra debajo del nombre del rol", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.Hide();
                    CrearRol form = new CrearRol(rol);
                    form.ShowDialog();
                    this.Show();
                }
            }
            else
            {

                Rol r = new Rol();
                r.nombre = textBox_nombreRol.Text;
                if (r.existeNombre())
                {
                    MessageBox.Show("ya existe ese nombre de rol, por favor elija otro", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.Hide();
                    CrearRol form = new CrearRol(r.create());
                    form.ShowDialog();
                    this.Show();

                }


            }
        }
    }
}