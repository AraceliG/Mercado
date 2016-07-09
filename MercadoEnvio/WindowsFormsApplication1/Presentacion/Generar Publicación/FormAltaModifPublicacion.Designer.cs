namespace MercadoEnvioFRBA.Presentacion
{
    partial class FormAltaModifPublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaModifPublicacion));
            this.groupBox_ofrece_envios = new System.Windows.Forms.GroupBox();
            this.ofrece_enviosNo = new System.Windows.Forms.RadioButton();
            this.ofrece_enviosSi = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoPublicacion = new System.Windows.Forms.GroupBox();
            this.tipo_publicacionSubasta = new System.Windows.Forms.RadioButton();
            this.tipo_publicacionCompra = new System.Windows.Forms.RadioButton();
            this.label_fecha_vencimiernto = new System.Windows.Forms.Label();
            this.label_fecha_inicio = new System.Windows.Forms.Label();
            this.fecha_vencimiernto = new System.Windows.Forms.DateTimePicker();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label_costo = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label_precio = new System.Windows.Forms.Label();
            this.groupBox_aceptaPreguntas = new System.Windows.Forms.GroupBox();
            this.acepta_preguntasNo = new System.Windows.Forms.RadioButton();
            this.acepta_preguntasSi = new System.Windows.Forms.RadioButton();
            this.label_cod_publicacion = new System.Windows.Forms.Label();
            this.cod_publicacion = new System.Windows.Forms.TextBox();
            this.label_visibilidad = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.visibilidad = new System.Windows.Forms.ComboBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBox_ofrece_envios.SuspendLayout();
            this.groupBoxTipoPublicacion.SuspendLayout();
            this.groupBox_aceptaPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ofrece_envios
            // 
            this.groupBox_ofrece_envios.Controls.Add(this.ofrece_enviosNo);
            this.groupBox_ofrece_envios.Controls.Add(this.ofrece_enviosSi);
            this.groupBox_ofrece_envios.Location = new System.Drawing.Point(294, 198);
            this.groupBox_ofrece_envios.Name = "groupBox_ofrece_envios";
            this.groupBox_ofrece_envios.Size = new System.Drawing.Size(147, 43);
            this.groupBox_ofrece_envios.TabIndex = 37;
            this.groupBox_ofrece_envios.TabStop = false;
            this.groupBox_ofrece_envios.Text = "Ofrece envios:";
            // 
            // ofrece_enviosNo
            // 
            this.ofrece_enviosNo.AutoSize = true;
            this.ofrece_enviosNo.Checked = true;
            this.ofrece_enviosNo.Location = new System.Drawing.Point(105, 17);
            this.ofrece_enviosNo.Name = "ofrece_enviosNo";
            this.ofrece_enviosNo.Size = new System.Drawing.Size(39, 17);
            this.ofrece_enviosNo.TabIndex = 15;
            this.ofrece_enviosNo.TabStop = true;
            this.ofrece_enviosNo.Text = "No";
            this.ofrece_enviosNo.UseVisualStyleBackColor = true;
            // 
            // ofrece_enviosSi
            // 
            this.ofrece_enviosSi.AutoSize = true;
            this.ofrece_enviosSi.Location = new System.Drawing.Point(65, 17);
            this.ofrece_enviosSi.Name = "ofrece_enviosSi";
            this.ofrece_enviosSi.Size = new System.Drawing.Size(34, 17);
            this.ofrece_enviosSi.TabIndex = 14;
            this.ofrece_enviosSi.Text = "Si";
            this.ofrece_enviosSi.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoPublicacion
            // 
            this.groupBoxTipoPublicacion.Controls.Add(this.tipo_publicacionSubasta);
            this.groupBoxTipoPublicacion.Controls.Add(this.tipo_publicacionCompra);
            this.groupBoxTipoPublicacion.Location = new System.Drawing.Point(293, 110);
            this.groupBoxTipoPublicacion.Name = "groupBoxTipoPublicacion";
            this.groupBoxTipoPublicacion.Size = new System.Drawing.Size(148, 43);
            this.groupBoxTipoPublicacion.TabIndex = 36;
            this.groupBoxTipoPublicacion.TabStop = false;
            this.groupBoxTipoPublicacion.Text = "Tipo publicacion:";
            // 
            // tipo_publicacionSubasta
            // 
            this.tipo_publicacionSubasta.AutoSize = true;
            this.tipo_publicacionSubasta.Location = new System.Drawing.Point(80, 17);
            this.tipo_publicacionSubasta.Name = "tipo_publicacionSubasta";
            this.tipo_publicacionSubasta.Size = new System.Drawing.Size(64, 17);
            this.tipo_publicacionSubasta.TabIndex = 15;
            this.tipo_publicacionSubasta.Text = "Subasta";
            this.tipo_publicacionSubasta.UseVisualStyleBackColor = true;
            // 
            // tipo_publicacionCompra
            // 
            this.tipo_publicacionCompra.AutoSize = true;
            this.tipo_publicacionCompra.Checked = true;
            this.tipo_publicacionCompra.Location = new System.Drawing.Point(14, 17);
            this.tipo_publicacionCompra.Name = "tipo_publicacionCompra";
            this.tipo_publicacionCompra.Size = new System.Drawing.Size(61, 17);
            this.tipo_publicacionCompra.TabIndex = 14;
            this.tipo_publicacionCompra.TabStop = true;
            this.tipo_publicacionCompra.Text = "Compra";
            this.tipo_publicacionCompra.UseVisualStyleBackColor = true;
            // 
            // label_fecha_vencimiernto
            // 
            this.label_fecha_vencimiernto.AutoSize = true;
            this.label_fecha_vencimiernto.Location = new System.Drawing.Point(22, 241);
            this.label_fecha_vencimiernto.Name = "label_fecha_vencimiernto";
            this.label_fecha_vencimiernto.Size = new System.Drawing.Size(103, 13);
            this.label_fecha_vencimiernto.TabIndex = 3;
            this.label_fecha_vencimiernto.Text = "Fecha vencimiernto:";
            // 
            // label_fecha_inicio
            // 
            this.label_fecha_inicio.AutoSize = true;
            this.label_fecha_inicio.Location = new System.Drawing.Point(58, 216);
            this.label_fecha_inicio.Name = "label_fecha_inicio";
            this.label_fecha_inicio.Size = new System.Drawing.Size(67, 13);
            this.label_fecha_inicio.TabIndex = 2;
            this.label_fecha_inicio.Text = "Fecha inicio:";
            // 
            // fecha_vencimiernto
            // 
            this.fecha_vencimiernto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiernto.Location = new System.Drawing.Point(128, 238);
            this.fecha_vencimiernto.Name = "fecha_vencimiernto";
            this.fecha_vencimiernto.Size = new System.Drawing.Size(121, 20);
            this.fecha_vencimiernto.TabIndex = 29;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_inicio.Location = new System.Drawing.Point(128, 213);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(121, 20);
            this.fecha_inicio.TabIndex = 28;
            // 
            // label_costo
            // 
            this.label_costo.AutoSize = true;
            this.label_costo.Location = new System.Drawing.Point(89, 166);
            this.label_costo.Name = "label_costo";
            this.label_costo.Size = new System.Drawing.Size(37, 13);
            this.label_costo.TabIndex = 10;
            this.label_costo.Text = "Costo:";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(88, 140);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(38, 13);
            this.label_stock.TabIndex = 9;
            this.label_stock.Text = "Stock:";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(129, 162);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(120, 20);
            this.costo.TabIndex = 11;
            this.costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(129, 136);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(120, 20);
            this.stock.TabIndex = 6;
            this.stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(129, 110);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 20);
            this.precio.TabIndex = 5;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(87, 113);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(39, 13);
            this.label_precio.TabIndex = 4;
            this.label_precio.Text = "precio:";
            // 
            // groupBox_aceptaPreguntas
            // 
            this.groupBox_aceptaPreguntas.Controls.Add(this.acepta_preguntasNo);
            this.groupBox_aceptaPreguntas.Controls.Add(this.acepta_preguntasSi);
            this.groupBox_aceptaPreguntas.Location = new System.Drawing.Point(294, 154);
            this.groupBox_aceptaPreguntas.Name = "groupBox_aceptaPreguntas";
            this.groupBox_aceptaPreguntas.Size = new System.Drawing.Size(147, 43);
            this.groupBox_aceptaPreguntas.TabIndex = 32;
            this.groupBox_aceptaPreguntas.TabStop = false;
            this.groupBox_aceptaPreguntas.Text = "Acepta preguntas:";
            // 
            // acepta_preguntasNo
            // 
            this.acepta_preguntasNo.AutoSize = true;
            this.acepta_preguntasNo.BackColor = System.Drawing.Color.White;
            this.acepta_preguntasNo.Checked = true;
            this.acepta_preguntasNo.Location = new System.Drawing.Point(104, 17);
            this.acepta_preguntasNo.Name = "acepta_preguntasNo";
            this.acepta_preguntasNo.Size = new System.Drawing.Size(39, 17);
            this.acepta_preguntasNo.TabIndex = 15;
            this.acepta_preguntasNo.TabStop = true;
            this.acepta_preguntasNo.Text = "No";
            this.acepta_preguntasNo.UseVisualStyleBackColor = false;
            // 
            // acepta_preguntasSi
            // 
            this.acepta_preguntasSi.AutoSize = true;
            this.acepta_preguntasSi.BackColor = System.Drawing.Color.White;
            this.acepta_preguntasSi.Location = new System.Drawing.Point(65, 17);
            this.acepta_preguntasSi.Name = "acepta_preguntasSi";
            this.acepta_preguntasSi.Size = new System.Drawing.Size(34, 17);
            this.acepta_preguntasSi.TabIndex = 14;
            this.acepta_preguntasSi.Text = "Si";
            this.acepta_preguntasSi.UseVisualStyleBackColor = false;
            // 
            // label_cod_publicacion
            // 
            this.label_cod_publicacion.AutoSize = true;
            this.label_cod_publicacion.Location = new System.Drawing.Point(27, 61);
            this.label_cod_publicacion.Name = "label_cod_publicacion";
            this.label_cod_publicacion.Size = new System.Drawing.Size(100, 13);
            this.label_cod_publicacion.TabIndex = 0;
            this.label_cod_publicacion.Text = "Codigo publicacion:";
            // 
            // cod_publicacion
            // 
            this.cod_publicacion.Enabled = false;
            this.cod_publicacion.Location = new System.Drawing.Point(129, 58);
            this.cod_publicacion.Name = "cod_publicacion";
            this.cod_publicacion.Size = new System.Drawing.Size(120, 20);
            this.cod_publicacion.TabIndex = 1;
            // 
            // label_visibilidad
            // 
            this.label_visibilidad.AutoSize = true;
            this.label_visibilidad.Location = new System.Drawing.Point(69, 192);
            this.label_visibilidad.Name = "label_visibilidad";
            this.label_visibilidad.Size = new System.Drawing.Size(56, 13);
            this.label_visibilidad.TabIndex = 20;
            this.label_visibilidad.Text = "Visibilidad:";
            this.label_visibilidad.Click += new System.EventHandler(this.label_visibilidad_Click);
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(271, 61);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(43, 13);
            this.label_estado.TabIndex = 22;
            this.label_estado.Text = "Estado:";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(60, 87);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 24;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(129, 84);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(312, 20);
            this.descripcion.TabIndex = 25;
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(320, 58);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 38;
            // 
            // visibilidad
            // 
            this.visibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visibilidad.FormattingEnabled = true;
            this.visibilidad.Location = new System.Drawing.Point(128, 188);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(121, 21);
            this.visibilidad.TabIndex = 39;
            this.visibilidad.SelectedValueChanged += new System.EventHandler(this.visibilidad_SelectedValueChanged);
            // 
            // button_guardar
            // 
            this.button_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_guardar.BackgroundImage")));
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_guardar.Location = new System.Drawing.Point(366, 247);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 28);
            this.button_guardar.TabIndex = 40;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // FormAltaModifPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 298);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.fecha_vencimiernto);
            this.Controls.Add(this.label_fecha_vencimiernto);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label_fecha_inicio);
            this.Controls.Add(this.label_costo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.visibilidad);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label_visibilidad);
            this.Controls.Add(this.groupBox_ofrece_envios);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.groupBox_aceptaPreguntas);
            this.Controls.Add(this.groupBoxTipoPublicacion);
            this.Controls.Add(this.cod_publicacion);
            this.Controls.Add(this.label_cod_publicacion);
            this.Name = "FormAltaModifPublicacion";
            this.Text = "FormsAltaModifPublicacion";
            this.Load += new System.EventHandler(this.FormAltaModifPublicacion_Load);
            this.Controls.SetChildIndex(this.label_cod_publicacion, 0);
            this.Controls.SetChildIndex(this.cod_publicacion, 0);
            this.Controls.SetChildIndex(this.groupBoxTipoPublicacion, 0);
            this.Controls.SetChildIndex(this.groupBox_aceptaPreguntas, 0);
            this.Controls.SetChildIndex(this.label_estado, 0);
            this.Controls.SetChildIndex(this.groupBox_ofrece_envios, 0);
            this.Controls.SetChildIndex(this.label_visibilidad, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.label_precio, 0);
            this.Controls.SetChildIndex(this.visibilidad, 0);
            this.Controls.SetChildIndex(this.precio, 0);
            this.Controls.SetChildIndex(this.label_descripcion, 0);
            this.Controls.SetChildIndex(this.label_stock, 0);
            this.Controls.SetChildIndex(this.stock, 0);
            this.Controls.SetChildIndex(this.descripcion, 0);
            this.Controls.SetChildIndex(this.label_costo, 0);
            this.Controls.SetChildIndex(this.label_fecha_inicio, 0);
            this.Controls.SetChildIndex(this.fecha_inicio, 0);
            this.Controls.SetChildIndex(this.costo, 0);
            this.Controls.SetChildIndex(this.label_fecha_vencimiernto, 0);
            this.Controls.SetChildIndex(this.fecha_vencimiernto, 0);
            this.Controls.SetChildIndex(this.button_guardar, 0);
            this.groupBox_ofrece_envios.ResumeLayout(false);
            this.groupBox_ofrece_envios.PerformLayout();
            this.groupBoxTipoPublicacion.ResumeLayout(false);
            this.groupBoxTipoPublicacion.PerformLayout();
            this.groupBox_aceptaPreguntas.ResumeLayout(false);
            this.groupBox_aceptaPreguntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ofrece_envios;
        private System.Windows.Forms.RadioButton ofrece_enviosNo;
        private System.Windows.Forms.RadioButton ofrece_enviosSi;
        private System.Windows.Forms.GroupBox groupBoxTipoPublicacion;
        private System.Windows.Forms.RadioButton tipo_publicacionSubasta;
        private System.Windows.Forms.RadioButton tipo_publicacionCompra;
        private System.Windows.Forms.Label label_fecha_vencimiernto;
        private System.Windows.Forms.Label label_fecha_inicio;
        private System.Windows.Forms.DateTimePicker fecha_vencimiernto;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label_costo;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.GroupBox groupBox_aceptaPreguntas;
        private System.Windows.Forms.RadioButton acepta_preguntasNo;
        private System.Windows.Forms.RadioButton acepta_preguntasSi;
        private System.Windows.Forms.Label label_cod_publicacion;
        private System.Windows.Forms.TextBox cod_publicacion;
        private System.Windows.Forms.Label label_visibilidad;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.ComboBox visibilidad;
        private System.Windows.Forms.Button button_guardar;

    }
}