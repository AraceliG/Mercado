namespace MercadoEnvioFRBA.Presentacion
{
    partial class FormAltaModifVisibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaModifVisibilidad));
            this.tipo_comision_envio = new System.Windows.Forms.ComboBox();
            this.groupBox_permite_envios = new System.Windows.Forms.GroupBox();
            this.permiteEnviosNo = new System.Windows.Forms.RadioButton();
            this.permiteEnviosSi = new System.Windows.Forms.RadioButton();
            this.button_guardar = new System.Windows.Forms.Button();
            this.valor_comision_envio = new System.Windows.Forms.TextBox();
            this.label_valor_comision_envio = new System.Windows.Forms.Label();
            this.label_cod_tipo_comision_envio = new System.Windows.Forms.Label();
            this.comision_vender = new System.Windows.Forms.TextBox();
            this.label_comision_vender = new System.Windows.Forms.Label();
            this.comision_publicar = new System.Windows.Forms.TextBox();
            this.label_comision_publicar = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.cod_visibilidad = new System.Windows.Forms.TextBox();
            this.label_cod_visibilidad = new System.Windows.Forms.Label();
            this.groupBox_permite_envios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipo_comision_envio
            // 
            this.tipo_comision_envio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_comision_envio.FormattingEnabled = true;
            this.tipo_comision_envio.Location = new System.Drawing.Point(158, 118);
            this.tipo_comision_envio.Name = "tipo_comision_envio";
            this.tipo_comision_envio.Size = new System.Drawing.Size(121, 21);
            this.tipo_comision_envio.TabIndex = 32;
            // 
            // groupBox_permite_envios
            // 
            this.groupBox_permite_envios.Controls.Add(this.permiteEnviosNo);
            this.groupBox_permite_envios.Controls.Add(this.permiteEnviosSi);
            this.groupBox_permite_envios.Location = new System.Drawing.Point(532, 59);
            this.groupBox_permite_envios.Name = "groupBox_permite_envios";
            this.groupBox_permite_envios.Size = new System.Drawing.Size(95, 43);
            this.groupBox_permite_envios.TabIndex = 30;
            this.groupBox_permite_envios.TabStop = false;
            this.groupBox_permite_envios.Text = "Permite envios:";
            // 
            // permiteEnviosNo
            // 
            this.permiteEnviosNo.AutoSize = true;
            this.permiteEnviosNo.Checked = true;
            this.permiteEnviosNo.Location = new System.Drawing.Point(49, 17);
            this.permiteEnviosNo.Name = "permiteEnviosNo";
            this.permiteEnviosNo.Size = new System.Drawing.Size(39, 17);
            this.permiteEnviosNo.TabIndex = 15;
            this.permiteEnviosNo.TabStop = true;
            this.permiteEnviosNo.Text = "No";
            this.permiteEnviosNo.UseVisualStyleBackColor = true;
            // 
            // permiteEnviosSi
            // 
            this.permiteEnviosSi.AutoSize = true;
            this.permiteEnviosSi.Location = new System.Drawing.Point(9, 17);
            this.permiteEnviosSi.Name = "permiteEnviosSi";
            this.permiteEnviosSi.Size = new System.Drawing.Size(34, 17);
            this.permiteEnviosSi.TabIndex = 14;
            this.permiteEnviosSi.Text = "Si";
            this.permiteEnviosSi.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_guardar.BackgroundImage")));
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_guardar.Location = new System.Drawing.Point(552, 128);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 28);
            this.button_guardar.TabIndex = 20;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // valor_comision_envio
            // 
            this.valor_comision_envio.Location = new System.Drawing.Point(415, 118);
            this.valor_comision_envio.Name = "valor_comision_envio";
            this.valor_comision_envio.Size = new System.Drawing.Size(100, 20);
            this.valor_comision_envio.TabIndex = 29;
            this.valor_comision_envio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            this.valor_comision_envio.LostFocus += new System.EventHandler(this.validarSoloNumeros);
            // 
            // label_valor_comision_envio
            // 
            this.label_valor_comision_envio.AutoSize = true;
            this.label_valor_comision_envio.Location = new System.Drawing.Point(303, 118);
            this.label_valor_comision_envio.Name = "label_valor_comision_envio";
            this.label_valor_comision_envio.Size = new System.Drawing.Size(107, 13);
            this.label_valor_comision_envio.TabIndex = 28;
            this.label_valor_comision_envio.Text = "Valor comision envio:";
            // 
            // label_cod_tipo_comision_envio
            // 
            this.label_cod_tipo_comision_envio.AutoSize = true;
            this.label_cod_tipo_comision_envio.Location = new System.Drawing.Point(48, 118);
            this.label_cod_tipo_comision_envio.Name = "label_cod_tipo_comision_envio";
            this.label_cod_tipo_comision_envio.Size = new System.Drawing.Size(104, 13);
            this.label_cod_tipo_comision_envio.TabIndex = 27;
            this.label_cod_tipo_comision_envio.Text = "Tipo comision envio:";
            // 
            // comision_vender
            // 
            this.comision_vender.Location = new System.Drawing.Point(415, 92);
            this.comision_vender.Name = "comision_vender";
            this.comision_vender.Size = new System.Drawing.Size(100, 20);
            this.comision_vender.TabIndex = 26;
            this.comision_vender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            this.comision_vender.LostFocus += new System.EventHandler(this.validarSoloNumeros);
            // 
            // label_comision_vender
            // 
            this.label_comision_vender.AutoSize = true;
            this.label_comision_vender.Location = new System.Drawing.Point(321, 92);
            this.label_comision_vender.Name = "label_comision_vender";
            this.label_comision_vender.Size = new System.Drawing.Size(88, 13);
            this.label_comision_vender.TabIndex = 25;
            this.label_comision_vender.Text = "Comision vender:";
            // 
            // comision_publicar
            // 
            this.comision_publicar.BackColor = System.Drawing.SystemColors.Window;
            this.comision_publicar.Location = new System.Drawing.Point(415, 66);
            this.comision_publicar.Name = "comision_publicar";
            this.comision_publicar.Size = new System.Drawing.Size(100, 20);
            this.comision_publicar.TabIndex = 24;
            this.comision_publicar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            this.comision_publicar.LostFocus += new System.EventHandler(this.validarSoloNumeros);
            // 
            // label_comision_publicar
            // 
            this.label_comision_publicar.AutoSize = true;
            this.label_comision_publicar.Location = new System.Drawing.Point(317, 66);
            this.label_comision_publicar.Name = "label_comision_publicar";
            this.label_comision_publicar.Size = new System.Drawing.Size(92, 13);
            this.label_comision_publicar.TabIndex = 23;
            this.label_comision_publicar.Text = "Comision publicar:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(158, 92);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 22;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(86, 92);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 21;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // cod_visibilidad
            // 
            this.cod_visibilidad.Enabled = false;
            this.cod_visibilidad.Location = new System.Drawing.Point(158, 66);
            this.cod_visibilidad.Name = "cod_visibilidad";
            this.cod_visibilidad.Size = new System.Drawing.Size(100, 20);
            this.cod_visibilidad.TabIndex = 19;
            // 
            // label_cod_visibilidad
            // 
            this.label_cod_visibilidad.AutoSize = true;
            this.label_cod_visibilidad.Location = new System.Drawing.Point(61, 66);
            this.label_cod_visibilidad.Name = "label_cod_visibilidad";
            this.label_cod_visibilidad.Size = new System.Drawing.Size(91, 13);
            this.label_cod_visibilidad.TabIndex = 18;
            this.label_cod_visibilidad.Text = "Codigo visibilidad:";
            // 
            // FormAltaModifVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 168);
            this.Controls.Add(this.tipo_comision_envio);
            this.Controls.Add(this.groupBox_permite_envios);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.valor_comision_envio);
            this.Controls.Add(this.label_valor_comision_envio);
            this.Controls.Add(this.label_cod_tipo_comision_envio);
            this.Controls.Add(this.comision_vender);
            this.Controls.Add(this.label_comision_vender);
            this.Controls.Add(this.comision_publicar);
            this.Controls.Add(this.label_comision_publicar);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.cod_visibilidad);
            this.Controls.Add(this.label_cod_visibilidad);
            this.Name = "FormAltaModifVisibilidad";
            this.Text = "FormAltaModifVisibilidad";
            this.Load += new System.EventHandler(this.FormAltaModifVisibilidad_Load);
            this.Controls.SetChildIndex(this.label_cod_visibilidad, 0);
            this.Controls.SetChildIndex(this.cod_visibilidad, 0);
            this.Controls.SetChildIndex(this.label_descripcion, 0);
            this.Controls.SetChildIndex(this.descripcion, 0);
            this.Controls.SetChildIndex(this.label_comision_publicar, 0);
            this.Controls.SetChildIndex(this.comision_publicar, 0);
            this.Controls.SetChildIndex(this.label_comision_vender, 0);
            this.Controls.SetChildIndex(this.comision_vender, 0);
            this.Controls.SetChildIndex(this.label_cod_tipo_comision_envio, 0);
            this.Controls.SetChildIndex(this.label_valor_comision_envio, 0);
            this.Controls.SetChildIndex(this.valor_comision_envio, 0);
            this.Controls.SetChildIndex(this.button_guardar, 0);
            this.Controls.SetChildIndex(this.groupBox_permite_envios, 0);
            this.Controls.SetChildIndex(this.tipo_comision_envio, 0);
            this.groupBox_permite_envios.ResumeLayout(false);
            this.groupBox_permite_envios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipo_comision_envio;
        private System.Windows.Forms.GroupBox groupBox_permite_envios;
        private System.Windows.Forms.RadioButton permiteEnviosNo;
        private System.Windows.Forms.RadioButton permiteEnviosSi;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.TextBox valor_comision_envio;
        private System.Windows.Forms.Label label_valor_comision_envio;
        private System.Windows.Forms.Label label_cod_tipo_comision_envio;
        private System.Windows.Forms.TextBox comision_vender;
        private System.Windows.Forms.Label label_comision_vender;
        private System.Windows.Forms.TextBox comision_publicar;
        private System.Windows.Forms.Label label_comision_publicar;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox cod_visibilidad;
        private System.Windows.Forms.Label label_cod_visibilidad;
    }
}