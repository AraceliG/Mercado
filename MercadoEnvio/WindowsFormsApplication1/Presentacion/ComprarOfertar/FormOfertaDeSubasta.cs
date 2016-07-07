﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ComprarOfertar
{
    public partial class FormOfertaDeSubasta : FormBaseUTN
    {
        private Modelo.Publicacion publi;
        private Modelo.Usuario usuario;

        public FormOfertaDeSubasta()
        {
            InitializeComponent();
        }

        public FormOfertaDeSubasta(Publicacion publi, Usuario usuario)
        {
            
            this.publi = publi;
            this.usuario = usuario;
            InitializeComponent();
            label_ultimaOferta.Text= publi.precio.ToString();
        }

        private void FormOfertaDeSubasta_Load(object sender, EventArgs e)
        {

        }

        Int32 oferta;

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            oferta = Convert.ToInt32(txt_oferta.Text);
            if (esMayorOferta(oferta))
            { publi.actualizarPrecio(oferta);
                publi.ofertate(oferta, usuario);
            }

            else {
                MessageBox.Show("Su oferta no supera a la actual, debe ingresar un valor mayor ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool esMayorOferta(int oferta)
        {
            return this.publi.precio < oferta;
        }
    }
}