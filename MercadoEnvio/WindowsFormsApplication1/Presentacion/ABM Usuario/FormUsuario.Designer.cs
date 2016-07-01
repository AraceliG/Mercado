namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_psw = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_nro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_piso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_depto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_cod_postal = new System.Windows.Forms.TextBox();
            this.errorProvider_usuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_psw = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_mail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_fechaCreacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_calle = new System.Windows.Forms.ErrorProvider(this.components);
            this.nume_calle = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nombre de Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(196, 72);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(165, 24);
            this.textBox_usuario.TabIndex = 79;
            this.textBox_usuario.TextChanged += new System.EventHandler(this.textBox_usuario_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 18);
            this.label13.TabIndex = 80;
            this.label13.Text = "Contraseña:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_psw
            // 
            this.textBox_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_psw.Location = new System.Drawing.Point(196, 114);
            this.textBox_psw.Name = "textBox_psw";
            this.textBox_psw.Size = new System.Drawing.Size(165, 24);
            this.textBox_psw.TabIndex = 81;
            this.textBox_psw.UseSystemPasswordChar = true;
            this.textBox_psw.TextChanged += new System.EventHandler(this.textBox_psw_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 18);
            this.label15.TabIndex = 85;
            this.label15.Text = "Fecha de Creación:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 24);
            this.textBox1.TabIndex = 86;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 88;
            this.label5.Text = "Mail:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(196, 199);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(165, 24);
            this.textBox_mail.TabIndex = 89;
            this.textBox_mail.TextChanged += new System.EventHandler(this.textBox_mail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Teléfono:";
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(196, 234);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(165, 20);
            this.text_telefono.TabIndex = 91;
            this.text_telefono.TextChanged += new System.EventHandler(this.text_telefono_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 18);
            this.label8.TabIndex = 92;
            this.label8.Text = "Calle:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_calle
            // 
            this.textBox_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_calle.Location = new System.Drawing.Point(196, 263);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(165, 24);
            this.textBox_calle.TabIndex = 93;
            this.textBox_calle.TextChanged += new System.EventHandler(this.textBox_calle_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 94;
            this.label9.Text = "Nro:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nro
            // 
            this.textBox_nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nro.Location = new System.Drawing.Point(196, 298);
            this.textBox_nro.Name = "textBox_nro";
            this.textBox_nro.Size = new System.Drawing.Size(165, 24);
            this.textBox_nro.TabIndex = 95;
            this.textBox_nro.TextChanged += new System.EventHandler(this.textBox_nro_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 96;
            this.label10.Text = "Piso:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_piso
            // 
            this.textBox_piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_piso.Location = new System.Drawing.Point(196, 337);
            this.textBox_piso.Name = "textBox_piso";
            this.textBox_piso.Size = new System.Drawing.Size(165, 24);
            this.textBox_piso.TabIndex = 97;
            this.textBox_piso.TextChanged += new System.EventHandler(this.textBox_piso_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 18);
            this.label11.TabIndex = 98;
            this.label11.Text = "Depto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_depto
            // 
            this.textBox_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_depto.Location = new System.Drawing.Point(196, 372);
            this.textBox_depto.Name = "textBox_depto";
            this.textBox_depto.Size = new System.Drawing.Size(165, 24);
            this.textBox_depto.TabIndex = 99;
            this.textBox_depto.TextChanged += new System.EventHandler(this.textBox_depto_TextChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 18);
            this.label14.TabIndex = 100;
            this.label14.Text = "Código postal:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_cod_postal
            // 
            this.textBox_cod_postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cod_postal.Location = new System.Drawing.Point(196, 415);
            this.textBox_cod_postal.Name = "textBox_cod_postal";
            this.textBox_cod_postal.Size = new System.Drawing.Size(165, 24);
            this.textBox_cod_postal.TabIndex = 101;
            this.textBox_cod_postal.TextChanged += new System.EventHandler(this.textBox_cod_postal_TextChanged);
            // 
            // errorProvider_usuario
            // 
            this.errorProvider_usuario.ContainerControl = this;
            // 
            // errorProvider_psw
            // 
            this.errorProvider_psw.ContainerControl = this;
            // 
            // errorProvider_mail
            // 
            this.errorProvider_mail.ContainerControl = this;
            // 
            // errorProvider_fechaCreacion
            // 
            this.errorProvider_fechaCreacion.ContainerControl = this;
            // 
            // errorProvider_calle
            // 
            this.errorProvider_calle.ContainerControl = this;
            // 
            // nume_calle
            // 
            this.nume_calle.ContainerControl = this;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 469);
            this.Controls.Add(this.textBox_cod_postal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_depto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_piso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_nro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_calle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_psw);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label6);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox_usuario, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.textBox_psw, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox_mail, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.text_telefono, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textBox_calle, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.textBox_nro, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBox_piso, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textBox_depto, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.textBox_cod_postal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox_usuario;
        public System.Windows.Forms.TextBox textBox_psw;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox_mail;
        public System.Windows.Forms.TextBox text_telefono;
        public System.Windows.Forms.TextBox textBox_calle;
        public System.Windows.Forms.TextBox textBox_nro;
        public System.Windows.Forms.TextBox textBox_piso;
        public System.Windows.Forms.TextBox textBox_depto;
        public System.Windows.Forms.TextBox textBox_cod_postal;
        public System.Windows.Forms.ErrorProvider errorProvider_usuario;
        public System.Windows.Forms.ErrorProvider errorProvider_psw;
        public System.Windows.Forms.ErrorProvider errorProvider_mail;
        public System.Windows.Forms.ErrorProvider errorProvider_fechaCreacion;
        public System.Windows.Forms.ErrorProvider errorProvider_calle;
        public System.Windows.Forms.ErrorProvider nume_calle;

    }
}