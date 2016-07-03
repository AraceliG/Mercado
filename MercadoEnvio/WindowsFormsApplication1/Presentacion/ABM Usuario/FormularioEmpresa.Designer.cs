namespace MercadoEnvioFRBA.ABM_Usuario
{
    partial class FormularioEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox_razon_social = new System.Windows.Forms.TextBox();
            this.textBox_nombre_de_contacto = new System.Windows.Forms.TextBox();
            this.textBox_contacto = new System.Windows.Forms.TextBox();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.error_cuit = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_razon_social = new System.Windows.Forms.ErrorProvider(this.components);
            this.text_cuit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_cuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_razon_social)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nro
            // 
            this.textBox_nro.TextChanged += new System.EventHandler(this.textBox_nro_TextChanged_1);
            this.textBox_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nro_KeyPress_1);
            // 
            // textBox_cod_postal
            // 
            this.textBox_cod_postal.Location = new System.Drawing.Point(196, 412);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "CUIT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "Razón Social:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Nombre de Contacto:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 116;
            this.label4.Text = "Rubro Principal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 117;
            this.label12.Text = "Ciudad:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(199, 630);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(131, 49);
            this.buttonLogin.TabIndex = 118;
            this.buttonLogin.Text = "Guardar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBox_razon_social
            // 
            this.textBox_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_razon_social.Location = new System.Drawing.Point(199, 479);
            this.textBox_razon_social.Name = "textBox_razon_social";
            this.textBox_razon_social.Size = new System.Drawing.Size(165, 24);
            this.textBox_razon_social.TabIndex = 120;
            // 
            // textBox_nombre_de_contacto
            // 
            this.textBox_nombre_de_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre_de_contacto.Location = new System.Drawing.Point(199, 509);
            this.textBox_nombre_de_contacto.Name = "textBox_nombre_de_contacto";
            this.textBox_nombre_de_contacto.Size = new System.Drawing.Size(165, 24);
            this.textBox_nombre_de_contacto.TabIndex = 121;
            // 
            // textBox_contacto
            // 
            this.textBox_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contacto.Location = new System.Drawing.Point(199, 548);
            this.textBox_contacto.Name = "textBox_contacto";
            this.textBox_contacto.Size = new System.Drawing.Size(165, 24);
            this.textBox_contacto.TabIndex = 122;
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ciudad.Location = new System.Drawing.Point(199, 587);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(165, 24);
            this.textBox_ciudad.TabIndex = 123;
            // 
            // error_cuit
            // 
            this.error_cuit.ContainerControl = this;
            // 
            // error_razon_social
            // 
            this.error_razon_social.ContainerControl = this;
            // 
            // text_cuit
            // 
            this.text_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cuit.Location = new System.Drawing.Point(199, 446);
            this.text_cuit.Name = "text_cuit";
            this.text_cuit.Size = new System.Drawing.Size(165, 24);
            this.text_cuit.TabIndex = 124;
            this.text_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_cuit_KeyPress_1);
            // 
            // FormularioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 691);
            this.Controls.Add(this.text_cuit);
            this.Controls.Add(this.textBox_ciudad);
            this.Controls.Add(this.textBox_contacto);
            this.Controls.Add(this.textBox_nombre_de_contacto);
            this.Controls.Add(this.textBox_razon_social);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormularioEmpresa";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FormularioEmpresa_Load);
            this.Controls.SetChildIndex(this.textBox_usuario, 0);
            this.Controls.SetChildIndex(this.textBox_psw, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox_mail, 0);
            this.Controls.SetChildIndex(this.text_telefono, 0);
            this.Controls.SetChildIndex(this.textBox_calle, 0);
            this.Controls.SetChildIndex(this.textBox_nro, 0);
            this.Controls.SetChildIndex(this.textBox_piso, 0);
            this.Controls.SetChildIndex(this.textBox_depto, 0);
            this.Controls.SetChildIndex(this.textBox_cod_postal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.buttonLogin, 0);
            this.Controls.SetChildIndex(this.textBox_razon_social, 0);
            this.Controls.SetChildIndex(this.textBox_nombre_de_contacto, 0);
            this.Controls.SetChildIndex(this.textBox_contacto, 0);
            this.Controls.SetChildIndex(this.textBox_ciudad, 0);
            this.Controls.SetChildIndex(this.text_cuit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_cuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_razon_social)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBox_razon_social;
        private System.Windows.Forms.TextBox textBox_nombre_de_contacto;
        private System.Windows.Forms.TextBox textBox_contacto;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.ErrorProvider error_cuit;
        private System.Windows.Forms.ErrorProvider error_razon_social;
        private System.Windows.Forms.TextBox text_cuit;
    }
}