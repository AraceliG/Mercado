namespace MercadoEnvioFRBA.ABM_Usuario
{
    partial class FormularioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCliente));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tipoDoc = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.button_fecha = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.errorProvider_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ape = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nro_doc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_tipo_doc = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_nroDoc = new System.Windows.Forms.TextBox();
            this.errorProvider_fechaNac = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nro_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_tipo_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaNac)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_psw
            // 
            this.textBox_psw.TextChanged += new System.EventHandler(this.textBox_psw_TextChanged_1);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 113;
            this.label12.Text = "Nro de Documento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "Tipo de Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_tipoDoc
            // 
            this.comboBox_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipoDoc.FormattingEnabled = true;
            this.comboBox_tipoDoc.Location = new System.Drawing.Point(199, 447);
            this.comboBox_tipoDoc.Name = "comboBox_tipoDoc";
            this.comboBox_tipoDoc.Size = new System.Drawing.Size(165, 26);
            this.comboBox_tipoDoc.TabIndex = 116;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 34);
            this.button2.TabIndex = 117;
            this.button2.Text = "Cargar Tipos Documentos Disponibles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 118;
            this.label4.Text = "Apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 120;
            this.label7.Text = "Fecha de Nacimiento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(199, 490);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(165, 24);
            this.textBox_apellido.TabIndex = 121;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(199, 522);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(165, 24);
            this.textBox_nombre.TabIndex = 122;
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fecha.Location = new System.Drawing.Point(199, 555);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.ReadOnly = true;
            this.textBox_fecha.Size = new System.Drawing.Size(165, 24);
            this.textBox_fecha.TabIndex = 123;
            this.textBox_fecha.TextChanged += new System.EventHandler(this.textBox_fecha_TextChanged);
            // 
            // button_fecha
            // 
            this.button_fecha.Location = new System.Drawing.Point(380, 553);
            this.button_fecha.Name = "button_fecha";
            this.button_fecha.Size = new System.Drawing.Size(75, 23);
            this.button_fecha.TabIndex = 124;
            this.button_fecha.Text = "Seleccionar";
            this.button_fecha.UseVisualStyleBackColor = true;
            this.button_fecha.Click += new System.EventHandler(this.button_fecha_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(199, 642);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(131, 49);
            this.buttonLogin.TabIndex = 125;
            this.buttonLogin.Text = "Guardar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // errorProvider_nombre
            // 
            this.errorProvider_nombre.ContainerControl = this;
            // 
            // errorProvider_ape
            // 
            this.errorProvider_ape.ContainerControl = this;
            // 
            // errorProvider_nro_doc
            // 
            this.errorProvider_nro_doc.ContainerControl = this;
            // 
            // errorProvider_tipo_doc
            // 
            this.errorProvider_tipo_doc.ContainerControl = this;
            // 
            // textBox_nroDoc
            // 
            this.textBox_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nroDoc.Location = new System.Drawing.Point(196, 598);
            this.textBox_nroDoc.Name = "textBox_nroDoc";
            this.textBox_nroDoc.Size = new System.Drawing.Size(165, 24);
            this.textBox_nroDoc.TabIndex = 126;
            // 
            // errorProvider_fechaNac
            // 
            this.errorProvider_fechaNac.ContainerControl = this;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 703);
            this.Controls.Add(this.textBox_nroDoc);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button_fecha);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_tipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Name = "FormularioCliente";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
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
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox_tipoDoc, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox_apellido, 0);
            this.Controls.SetChildIndex(this.textBox_nombre, 0);
            this.Controls.SetChildIndex(this.textBox_fecha, 0);
            this.Controls.SetChildIndex(this.button_fecha, 0);
            this.Controls.SetChildIndex(this.buttonLogin, 0);
            this.Controls.SetChildIndex(this.textBox_nroDoc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_psw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_calle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nume_calle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nro_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_tipo_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fechaNac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tipoDoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Button button_fecha;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ErrorProvider errorProvider_nombre;
        private System.Windows.Forms.ErrorProvider errorProvider_ape;
        private System.Windows.Forms.ErrorProvider errorProvider_nro_doc;
        private System.Windows.Forms.ErrorProvider errorProvider_tipo_doc;
        private System.Windows.Forms.TextBox textBox_nroDoc;
        private System.Windows.Forms.ErrorProvider errorProvider_fechaNac;
    }
}