namespace MercadoEnvioFRBA.Presentacion
{
    partial class FormABMVisibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMVisibilidad));
            this.grpBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.tipo_comision_envio = new System.Windows.Forms.ComboBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.groupBox_permite_envios = new System.Windows.Forms.GroupBox();
            this.permiteEnviosNo = new System.Windows.Forms.RadioButton();
            this.permiteEnviosAmbos = new System.Windows.Forms.RadioButton();
            this.permiteEnviosSi = new System.Windows.Forms.RadioButton();
            this.button_listar = new System.Windows.Forms.Button();
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
            this.dataGridViewVisibiliadesFiltradas = new System.Windows.Forms.DataGridView();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.grpBoxFiltrosBusqueda.SuspendLayout();
            this.groupBox_permite_envios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisibiliadesFiltradas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxFiltrosBusqueda
            // 
            this.grpBoxFiltrosBusqueda.Controls.Add(this.tipo_comision_envio);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.button_limpiar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBox_permite_envios);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.button_listar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.valor_comision_envio);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_valor_comision_envio);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_cod_tipo_comision_envio);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.comision_vender);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_comision_vender);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.comision_publicar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_comision_publicar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.descripcion);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_descripcion);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.cod_visibilidad);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.label_cod_visibilidad);
            this.grpBoxFiltrosBusqueda.Location = new System.Drawing.Point(25, 65);
            this.grpBoxFiltrosBusqueda.Name = "grpBoxFiltrosBusqueda";
            this.grpBoxFiltrosBusqueda.Size = new System.Drawing.Size(711, 131);
            this.grpBoxFiltrosBusqueda.TabIndex = 1;
            this.grpBoxFiltrosBusqueda.TabStop = false;
            this.grpBoxFiltrosBusqueda.Text = "Filtros busqueda:";
            this.grpBoxFiltrosBusqueda.Enter += new System.EventHandler(this.grpBoxFiltrosBusqueda_Enter);
            // 
            // tipo_comision_envio
            // 
            this.tipo_comision_envio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_comision_envio.FormattingEnabled = true;
            this.tipo_comision_envio.Location = new System.Drawing.Point(132, 79);
            this.tipo_comision_envio.Name = "tipo_comision_envio";
            this.tipo_comision_envio.Size = new System.Drawing.Size(121, 21);
            this.tipo_comision_envio.TabIndex = 17;
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_limpiar.BackgroundImage")));
            this.button_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_limpiar.Location = new System.Drawing.Point(587, 79);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 28);
            this.button_limpiar.TabIndex = 16;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // groupBox_permite_envios
            // 
            this.groupBox_permite_envios.Controls.Add(this.permiteEnviosNo);
            this.groupBox_permite_envios.Controls.Add(this.permiteEnviosAmbos);
            this.groupBox_permite_envios.Controls.Add(this.permiteEnviosSi);
            this.groupBox_permite_envios.Location = new System.Drawing.Point(506, 20);
            this.groupBox_permite_envios.Name = "groupBox_permite_envios";
            this.groupBox_permite_envios.Size = new System.Drawing.Size(163, 43);
            this.groupBox_permite_envios.TabIndex = 15;
            this.groupBox_permite_envios.TabStop = false;
            this.groupBox_permite_envios.Text = "Permite envios:";
            // 
            // permiteEnviosNo
            // 
            this.permiteEnviosNo.AutoSize = true;
            this.permiteEnviosNo.Location = new System.Drawing.Point(115, 17);
            this.permiteEnviosNo.Name = "permiteEnviosNo";
            this.permiteEnviosNo.Size = new System.Drawing.Size(39, 17);
            this.permiteEnviosNo.TabIndex = 15;
            this.permiteEnviosNo.Text = "No";
            this.permiteEnviosNo.UseVisualStyleBackColor = true;
            // 
            // permiteEnviosAmbos
            // 
            this.permiteEnviosAmbos.AutoSize = true;
            this.permiteEnviosAmbos.Checked = true;
            this.permiteEnviosAmbos.Location = new System.Drawing.Point(12, 17);
            this.permiteEnviosAmbos.Name = "permiteEnviosAmbos";
            this.permiteEnviosAmbos.Size = new System.Drawing.Size(57, 17);
            this.permiteEnviosAmbos.TabIndex = 0;
            this.permiteEnviosAmbos.TabStop = true;
            this.permiteEnviosAmbos.Text = "Ambos";
            this.permiteEnviosAmbos.UseVisualStyleBackColor = true;
            // 
            // permiteEnviosSi
            // 
            this.permiteEnviosSi.AutoSize = true;
            this.permiteEnviosSi.Location = new System.Drawing.Point(75, 17);
            this.permiteEnviosSi.Name = "permiteEnviosSi";
            this.permiteEnviosSi.Size = new System.Drawing.Size(34, 17);
            this.permiteEnviosSi.TabIndex = 14;
            this.permiteEnviosSi.Text = "Si";
            this.permiteEnviosSi.UseVisualStyleBackColor = true;
            // 
            // button_listar
            // 
            this.button_listar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_listar.BackgroundImage")));
            this.button_listar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_listar.Location = new System.Drawing.Point(506, 79);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(75, 28);
            this.button_listar.TabIndex = 2;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // valor_comision_envio
            // 
            this.valor_comision_envio.Location = new System.Drawing.Point(389, 79);
            this.valor_comision_envio.Name = "valor_comision_envio";
            this.valor_comision_envio.Size = new System.Drawing.Size(100, 20);
            this.valor_comision_envio.TabIndex = 13;
            // 
            // label_valor_comision_envio
            // 
            this.label_valor_comision_envio.AutoSize = true;
            this.label_valor_comision_envio.Location = new System.Drawing.Point(277, 79);
            this.label_valor_comision_envio.Name = "label_valor_comision_envio";
            this.label_valor_comision_envio.Size = new System.Drawing.Size(107, 13);
            this.label_valor_comision_envio.TabIndex = 12;
            this.label_valor_comision_envio.Text = "Valor comision envio:";
            // 
            // label_cod_tipo_comision_envio
            // 
            this.label_cod_tipo_comision_envio.AutoSize = true;
            this.label_cod_tipo_comision_envio.Location = new System.Drawing.Point(22, 79);
            this.label_cod_tipo_comision_envio.Name = "label_cod_tipo_comision_envio";
            this.label_cod_tipo_comision_envio.Size = new System.Drawing.Size(104, 13);
            this.label_cod_tipo_comision_envio.TabIndex = 10;
            this.label_cod_tipo_comision_envio.Text = "Tipo comision envio:";
            // 
            // comision_vender
            // 
            this.comision_vender.Location = new System.Drawing.Point(389, 53);
            this.comision_vender.Name = "comision_vender";
            this.comision_vender.Size = new System.Drawing.Size(100, 20);
            this.comision_vender.TabIndex = 7;
            // 
            // label_comision_vender
            // 
            this.label_comision_vender.AutoSize = true;
            this.label_comision_vender.Location = new System.Drawing.Point(295, 53);
            this.label_comision_vender.Name = "label_comision_vender";
            this.label_comision_vender.Size = new System.Drawing.Size(88, 13);
            this.label_comision_vender.TabIndex = 6;
            this.label_comision_vender.Text = "Comision vender:";
            // 
            // comision_publicar
            // 
            this.comision_publicar.Location = new System.Drawing.Point(389, 27);
            this.comision_publicar.Name = "comision_publicar";
            this.comision_publicar.Size = new System.Drawing.Size(100, 20);
            this.comision_publicar.TabIndex = 5;
            // 
            // label_comision_publicar
            // 
            this.label_comision_publicar.AutoSize = true;
            this.label_comision_publicar.Location = new System.Drawing.Point(291, 27);
            this.label_comision_publicar.Name = "label_comision_publicar";
            this.label_comision_publicar.Size = new System.Drawing.Size(92, 13);
            this.label_comision_publicar.TabIndex = 4;
            this.label_comision_publicar.Text = "Comision publicar:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(132, 53);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 3;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(60, 53);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 2;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // cod_visibilidad
            // 
            this.cod_visibilidad.Location = new System.Drawing.Point(132, 27);
            this.cod_visibilidad.Name = "cod_visibilidad";
            this.cod_visibilidad.Size = new System.Drawing.Size(100, 20);
            this.cod_visibilidad.TabIndex = 1;
            // 
            // label_cod_visibilidad
            // 
            this.label_cod_visibilidad.AutoSize = true;
            this.label_cod_visibilidad.Location = new System.Drawing.Point(35, 27);
            this.label_cod_visibilidad.Name = "label_cod_visibilidad";
            this.label_cod_visibilidad.Size = new System.Drawing.Size(91, 13);
            this.label_cod_visibilidad.TabIndex = 0;
            this.label_cod_visibilidad.Text = "Codigo visibilidad:";
            // 
            // dataGridViewVisibiliadesFiltradas
            // 
            this.dataGridViewVisibiliadesFiltradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisibiliadesFiltradas.Location = new System.Drawing.Point(25, 201);
            this.dataGridViewVisibiliadesFiltradas.Name = "dataGridViewVisibiliadesFiltradas";
            this.dataGridViewVisibiliadesFiltradas.Size = new System.Drawing.Size(711, 168);
            this.dataGridViewVisibiliadesFiltradas.TabIndex = 3;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.BackgroundImage")));
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrar.Location = new System.Drawing.Point(661, 375);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 28);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificar.BackgroundImage")));
            this.buttonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificar.Location = new System.Drawing.Point(580, 375);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 28);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // FormABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 434);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewVisibiliadesFiltradas);
            this.Controls.Add(this.grpBoxFiltrosBusqueda);
            this.Name = "FormABMVisibilidad";
            this.Text = "ABM Visibilidad";
            this.Load += new System.EventHandler(this.FormABMVisibilidad_Load);
            this.Controls.SetChildIndex(this.grpBoxFiltrosBusqueda, 0);
            this.Controls.SetChildIndex(this.dataGridViewVisibiliadesFiltradas, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.grpBoxFiltrosBusqueda.ResumeLayout(false);
            this.grpBoxFiltrosBusqueda.PerformLayout();
            this.groupBox_permite_envios.ResumeLayout(false);
            this.groupBox_permite_envios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisibiliadesFiltradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxFiltrosBusqueda;
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
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.DataGridView dataGridViewVisibiliadesFiltradas;
        private System.Windows.Forms.GroupBox groupBox_permite_envios;
        private System.Windows.Forms.RadioButton permiteEnviosNo;
        private System.Windows.Forms.RadioButton permiteEnviosAmbos;
        private System.Windows.Forms.RadioButton permiteEnviosSi;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.ComboBox tipo_comision_envio;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonModificar;
    }
}