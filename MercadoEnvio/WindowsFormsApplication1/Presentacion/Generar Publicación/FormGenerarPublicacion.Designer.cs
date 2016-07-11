namespace MercadoEnvioFRBA.Presentacion
{
    partial class FormGenerarPublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarPublicacion));
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.dataGridViewPublicacionesFiltradas = new System.Windows.Forms.DataGridView();
            this.grpBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.groupBox_ofrece_envios = new System.Windows.Forms.GroupBox();
            this.ofrece_enviosNo = new System.Windows.Forms.RadioButton();
            this.ofrece_enviosAmbos = new System.Windows.Forms.RadioButton();
            this.ofrece_enviosSi = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoPublicacion = new System.Windows.Forms.GroupBox();
            this.tipo_publicacionSubasta = new System.Windows.Forms.RadioButton();
            this.tipo_publicacionAmbos = new System.Windows.Forms.RadioButton();
            this.tipo_publicacionCompra = new System.Windows.Forms.RadioButton();
            this.groupBoxDeFechas = new System.Windows.Forms.GroupBox();
            this.fecha_vencimiernto = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.Label();
            this.groupBox_fecha_hasta = new System.Windows.Forms.GroupBox();
            this.fecha_vencimiernto_hasta = new System.Windows.Forms.DateTimePicker();
            this.fecha_inicio_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox_fecha_desde = new System.Windows.Forms.GroupBox();
            this.fecha_vencimiernto_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_inicio_desde = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDeMagnitud = new System.Windows.Forms.GroupBox();
            this.costo = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.groupBoxHasta = new System.Windows.Forms.GroupBox();
            this.costo_hasta = new System.Windows.Forms.TextBox();
            this.stock_hasta = new System.Windows.Forms.TextBox();
            this.precio_hasta = new System.Windows.Forms.TextBox();
            this.groupBoxDesde = new System.Windows.Forms.GroupBox();
            this.costo_desde = new System.Windows.Forms.TextBox();
            this.stock_desde = new System.Windows.Forms.TextBox();
            this.precio_desde = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.Label();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_listar = new System.Windows.Forms.Button();
            this.groupBoxDeTexto = new System.Windows.Forms.GroupBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label_estado = new System.Windows.Forms.Label();
            this.visibilidad = new System.Windows.Forms.TextBox();
            this.label_visibilidad = new System.Windows.Forms.Label();
            this.cod_publicacion = new System.Windows.Forms.TextBox();
            this.label_cod_publicacion = new System.Windows.Forms.Label();
            this.groupBox_aceptaPreguntas = new System.Windows.Forms.GroupBox();
            this.acepta_preguntasNo = new System.Windows.Forms.RadioButton();
            this.acepta_preguntasAmbos = new System.Windows.Forms.RadioButton();
            this.acepta_preguntasSi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicacionesFiltradas)).BeginInit();
            this.grpBoxFiltrosBusqueda.SuspendLayout();
            this.groupBox_ofrece_envios.SuspendLayout();
            this.groupBoxTipoPublicacion.SuspendLayout();
            this.groupBoxDeFechas.SuspendLayout();
            this.groupBox_fecha_hasta.SuspendLayout();
            this.groupBox_fecha_desde.SuspendLayout();
            this.groupBoxDeMagnitud.SuspendLayout();
            this.groupBoxHasta.SuspendLayout();
            this.groupBoxDesde.SuspendLayout();
            this.groupBoxDeTexto.SuspendLayout();
            this.groupBox_aceptaPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.BackgroundImage")));
            this.buttonNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNuevo.Location = new System.Drawing.Point(582, 412);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 28);
            this.buttonNuevo.TabIndex = 11;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificar.BackgroundImage")));
            this.buttonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificar.Location = new System.Drawing.Point(663, 412);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 28);
            this.buttonModificar.TabIndex = 10;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.BackgroundImage")));
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrar.Location = new System.Drawing.Point(744, 412);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 28);
            this.buttonBorrar.TabIndex = 9;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // dataGridViewPublicacionesFiltradas
            // 
            this.dataGridViewPublicacionesFiltradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublicacionesFiltradas.Location = new System.Drawing.Point(12, 256);
            this.dataGridViewPublicacionesFiltradas.Name = "dataGridViewPublicacionesFiltradas";
            this.dataGridViewPublicacionesFiltradas.ReadOnly = true;
            this.dataGridViewPublicacionesFiltradas.Size = new System.Drawing.Size(808, 150);
            this.dataGridViewPublicacionesFiltradas.TabIndex = 8;
            // 
            // grpBoxFiltrosBusqueda
            // 
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBox_ofrece_envios);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBoxTipoPublicacion);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBoxDeFechas);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBoxDeMagnitud);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.button_limpiar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.button_listar);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBoxDeTexto);
            this.grpBoxFiltrosBusqueda.Controls.Add(this.groupBox_aceptaPreguntas);
            this.grpBoxFiltrosBusqueda.Location = new System.Drawing.Point(12, 47);
            this.grpBoxFiltrosBusqueda.Name = "grpBoxFiltrosBusqueda";
            this.grpBoxFiltrosBusqueda.Size = new System.Drawing.Size(808, 203);
            this.grpBoxFiltrosBusqueda.TabIndex = 7;
            this.grpBoxFiltrosBusqueda.TabStop = false;
            this.grpBoxFiltrosBusqueda.Text = "Filtros busqueda:";
            // 
            // groupBox_ofrece_envios
            // 
            this.groupBox_ofrece_envios.Controls.Add(this.ofrece_enviosNo);
            this.groupBox_ofrece_envios.Controls.Add(this.ofrece_enviosAmbos);
            this.groupBox_ofrece_envios.Controls.Add(this.ofrece_enviosSi);
            this.groupBox_ofrece_envios.Location = new System.Drawing.Point(402, 150);
            this.groupBox_ofrece_envios.Name = "groupBox_ofrece_envios";
            this.groupBox_ofrece_envios.Size = new System.Drawing.Size(160, 43);
            this.groupBox_ofrece_envios.TabIndex = 31;
            this.groupBox_ofrece_envios.TabStop = false;
            this.groupBox_ofrece_envios.Text = "Ofrece envios:";
            // 
            // ofrece_enviosNo
            // 
            this.ofrece_enviosNo.AutoSize = true;
            this.ofrece_enviosNo.Location = new System.Drawing.Point(115, 17);
            this.ofrece_enviosNo.Name = "ofrece_enviosNo";
            this.ofrece_enviosNo.Size = new System.Drawing.Size(39, 17);
            this.ofrece_enviosNo.TabIndex = 15;
            this.ofrece_enviosNo.Text = "No";
            this.ofrece_enviosNo.UseVisualStyleBackColor = true;
            // 
            // ofrece_enviosAmbos
            // 
            this.ofrece_enviosAmbos.AutoSize = true;
            this.ofrece_enviosAmbos.Checked = true;
            this.ofrece_enviosAmbos.Location = new System.Drawing.Point(12, 17);
            this.ofrece_enviosAmbos.Name = "ofrece_enviosAmbos";
            this.ofrece_enviosAmbos.Size = new System.Drawing.Size(57, 17);
            this.ofrece_enviosAmbos.TabIndex = 0;
            this.ofrece_enviosAmbos.TabStop = true;
            this.ofrece_enviosAmbos.Text = "Ambos";
            this.ofrece_enviosAmbos.UseVisualStyleBackColor = true;
            // 
            // ofrece_enviosSi
            // 
            this.ofrece_enviosSi.AutoSize = true;
            this.ofrece_enviosSi.Location = new System.Drawing.Point(75, 17);
            this.ofrece_enviosSi.Name = "ofrece_enviosSi";
            this.ofrece_enviosSi.Size = new System.Drawing.Size(34, 17);
            this.ofrece_enviosSi.TabIndex = 14;
            this.ofrece_enviosSi.Text = "Si";
            this.ofrece_enviosSi.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoPublicacion
            // 
            this.groupBoxTipoPublicacion.Controls.Add(this.tipo_publicacionSubasta);
            this.groupBoxTipoPublicacion.Controls.Add(this.tipo_publicacionAmbos);
            this.groupBoxTipoPublicacion.Controls.Add(this.tipo_publicacionCompra);
            this.groupBoxTipoPublicacion.Location = new System.Drawing.Point(23, 150);
            this.groupBoxTipoPublicacion.Name = "groupBoxTipoPublicacion";
            this.groupBoxTipoPublicacion.Size = new System.Drawing.Size(211, 43);
            this.groupBoxTipoPublicacion.TabIndex = 30;
            this.groupBoxTipoPublicacion.TabStop = false;
            this.groupBoxTipoPublicacion.Text = "Tipo publicacion:";
            // 
            // tipo_publicacionSubasta
            // 
            this.tipo_publicacionSubasta.AutoSize = true;
            this.tipo_publicacionSubasta.Location = new System.Drawing.Point(141, 17);
            this.tipo_publicacionSubasta.Name = "tipo_publicacionSubasta";
            this.tipo_publicacionSubasta.Size = new System.Drawing.Size(64, 17);
            this.tipo_publicacionSubasta.TabIndex = 15;
            this.tipo_publicacionSubasta.Text = "Subasta";
            this.tipo_publicacionSubasta.UseVisualStyleBackColor = true;
            // 
            // tipo_publicacionAmbos
            // 
            this.tipo_publicacionAmbos.AutoSize = true;
            this.tipo_publicacionAmbos.Checked = true;
            this.tipo_publicacionAmbos.Location = new System.Drawing.Point(12, 17);
            this.tipo_publicacionAmbos.Name = "tipo_publicacionAmbos";
            this.tipo_publicacionAmbos.Size = new System.Drawing.Size(57, 17);
            this.tipo_publicacionAmbos.TabIndex = 0;
            this.tipo_publicacionAmbos.TabStop = true;
            this.tipo_publicacionAmbos.Text = "Ambos";
            this.tipo_publicacionAmbos.UseVisualStyleBackColor = true;
            // 
            // tipo_publicacionCompra
            // 
            this.tipo_publicacionCompra.AutoSize = true;
            this.tipo_publicacionCompra.Location = new System.Drawing.Point(75, 17);
            this.tipo_publicacionCompra.Name = "tipo_publicacionCompra";
            this.tipo_publicacionCompra.Size = new System.Drawing.Size(61, 17);
            this.tipo_publicacionCompra.TabIndex = 14;
            this.tipo_publicacionCompra.Text = "Compra";
            this.tipo_publicacionCompra.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeFechas
            // 
            this.groupBoxDeFechas.Controls.Add(this.fecha_vencimiernto);
            this.groupBoxDeFechas.Controls.Add(this.fecha_inicio);
            this.groupBoxDeFechas.Controls.Add(this.groupBox_fecha_hasta);
            this.groupBoxDeFechas.Controls.Add(this.groupBox_fecha_desde);
            this.groupBoxDeFechas.Location = new System.Drawing.Point(465, 19);
            this.groupBoxDeFechas.Name = "groupBoxDeFechas";
            this.groupBoxDeFechas.Size = new System.Drawing.Size(326, 96);
            this.groupBoxDeFechas.TabIndex = 29;
            this.groupBoxDeFechas.TabStop = false;
            this.groupBoxDeFechas.Text = "De fechas:";
            // 
            // fecha_vencimiernto
            // 
            this.fecha_vencimiernto.AutoSize = true;
            this.fecha_vencimiernto.Location = new System.Drawing.Point(7, 62);
            this.fecha_vencimiernto.Name = "fecha_vencimiernto";
            this.fecha_vencimiernto.Size = new System.Drawing.Size(103, 13);
            this.fecha_vencimiernto.TabIndex = 3;
            this.fecha_vencimiernto.Text = "Fecha vencimiernto:";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.AutoSize = true;
            this.fecha_inicio.Location = new System.Drawing.Point(43, 39);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(67, 13);
            this.fecha_inicio.TabIndex = 2;
            this.fecha_inicio.Text = "Fecha inicio:";
            // 
            // groupBox_fecha_hasta
            // 
            this.groupBox_fecha_hasta.Controls.Add(this.fecha_vencimiernto_hasta);
            this.groupBox_fecha_hasta.Controls.Add(this.fecha_inicio_hasta);
            this.groupBox_fecha_hasta.Location = new System.Drawing.Point(218, 19);
            this.groupBox_fecha_hasta.Name = "groupBox_fecha_hasta";
            this.groupBox_fecha_hasta.Size = new System.Drawing.Size(100, 70);
            this.groupBox_fecha_hasta.TabIndex = 1;
            this.groupBox_fecha_hasta.TabStop = false;
            this.groupBox_fecha_hasta.Text = "Hasta";
            // 
            // fecha_vencimiernto_hasta
            // 
            this.fecha_vencimiernto_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiernto_hasta.Location = new System.Drawing.Point(10, 40);
            this.fecha_vencimiernto_hasta.Name = "fecha_vencimiernto_hasta";
            this.fecha_vencimiernto_hasta.Size = new System.Drawing.Size(82, 20);
            this.fecha_vencimiernto_hasta.TabIndex = 29;
            // 
            // fecha_inicio_hasta
            // 
            this.fecha_inicio_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_inicio_hasta.Location = new System.Drawing.Point(10, 16);
            this.fecha_inicio_hasta.Name = "fecha_inicio_hasta";
            this.fecha_inicio_hasta.Size = new System.Drawing.Size(82, 20);
            this.fecha_inicio_hasta.TabIndex = 29;
            // 
            // groupBox_fecha_desde
            // 
            this.groupBox_fecha_desde.Controls.Add(this.fecha_vencimiernto_desde);
            this.groupBox_fecha_desde.Controls.Add(this.fecha_inicio_desde);
            this.groupBox_fecha_desde.Location = new System.Drawing.Point(113, 19);
            this.groupBox_fecha_desde.Name = "groupBox_fecha_desde";
            this.groupBox_fecha_desde.Size = new System.Drawing.Size(100, 70);
            this.groupBox_fecha_desde.TabIndex = 0;
            this.groupBox_fecha_desde.TabStop = false;
            this.groupBox_fecha_desde.Text = "Desde";
            // 
            // fecha_vencimiernto_desde
            // 
            this.fecha_vencimiernto_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiernto_desde.Location = new System.Drawing.Point(10, 40);
            this.fecha_vencimiernto_desde.Name = "fecha_vencimiernto_desde";
            this.fecha_vencimiernto_desde.Size = new System.Drawing.Size(82, 20);
            this.fecha_vencimiernto_desde.TabIndex = 29;
            // 
            // fecha_inicio_desde
            // 
            this.fecha_inicio_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_inicio_desde.Location = new System.Drawing.Point(10, 16);
            this.fecha_inicio_desde.Name = "fecha_inicio_desde";
            this.fecha_inicio_desde.Size = new System.Drawing.Size(82, 20);
            this.fecha_inicio_desde.TabIndex = 28;
            this.fecha_inicio_desde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBoxDeMagnitud
            // 
            this.groupBoxDeMagnitud.Controls.Add(this.costo);
            this.groupBoxDeMagnitud.Controls.Add(this.stock);
            this.groupBoxDeMagnitud.Controls.Add(this.groupBoxHasta);
            this.groupBoxDeMagnitud.Controls.Add(this.groupBoxDesde);
            this.groupBoxDeMagnitud.Controls.Add(this.precio);
            this.groupBoxDeMagnitud.Location = new System.Drawing.Point(250, 20);
            this.groupBoxDeMagnitud.Name = "groupBoxDeMagnitud";
            this.groupBoxDeMagnitud.Size = new System.Drawing.Size(210, 124);
            this.groupBoxDeMagnitud.TabIndex = 27;
            this.groupBoxDeMagnitud.TabStop = false;
            this.groupBoxDeMagnitud.Text = "De magnitud: ";
            // 
            // costo
            // 
            this.costo.AutoSize = true;
            this.costo.Location = new System.Drawing.Point(13, 96);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(37, 13);
            this.costo.TabIndex = 10;
            this.costo.Text = "Costo:";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(13, 71);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(38, 13);
            this.stock.TabIndex = 9;
            this.stock.Text = "Stock:";
            // 
            // groupBoxHasta
            // 
            this.groupBoxHasta.Controls.Add(this.costo_hasta);
            this.groupBoxHasta.Controls.Add(this.stock_hasta);
            this.groupBoxHasta.Controls.Add(this.precio_hasta);
            this.groupBoxHasta.Location = new System.Drawing.Point(131, 19);
            this.groupBoxHasta.Name = "groupBoxHasta";
            this.groupBoxHasta.Size = new System.Drawing.Size(72, 98);
            this.groupBoxHasta.TabIndex = 8;
            this.groupBoxHasta.TabStop = false;
            this.groupBoxHasta.Text = "Hasta";
            // 
            // costo_hasta
            // 
            this.costo_hasta.Location = new System.Drawing.Point(6, 73);
            this.costo_hasta.Name = "costo_hasta";
            this.costo_hasta.Size = new System.Drawing.Size(60, 20);
            this.costo_hasta.TabIndex = 7;
            // 
            // stock_hasta
            // 
            this.stock_hasta.Location = new System.Drawing.Point(6, 49);
            this.stock_hasta.Name = "stock_hasta";
            this.stock_hasta.Size = new System.Drawing.Size(60, 20);
            this.stock_hasta.TabIndex = 6;
            this.stock_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // precio_hasta
            // 
            this.precio_hasta.Location = new System.Drawing.Point(6, 25);
            this.precio_hasta.Name = "precio_hasta";
            this.precio_hasta.Size = new System.Drawing.Size(60, 20);
            this.precio_hasta.TabIndex = 5;
            // 
            // groupBoxDesde
            // 
            this.groupBoxDesde.Controls.Add(this.costo_desde);
            this.groupBoxDesde.Controls.Add(this.stock_desde);
            this.groupBoxDesde.Controls.Add(this.precio_desde);
            this.groupBoxDesde.Location = new System.Drawing.Point(53, 19);
            this.groupBoxDesde.Name = "groupBoxDesde";
            this.groupBoxDesde.Size = new System.Drawing.Size(72, 98);
            this.groupBoxDesde.TabIndex = 7;
            this.groupBoxDesde.TabStop = false;
            this.groupBoxDesde.Text = "Desde";
            // 
            // costo_desde
            // 
            this.costo_desde.Location = new System.Drawing.Point(6, 73);
            this.costo_desde.Name = "costo_desde";
            this.costo_desde.Size = new System.Drawing.Size(60, 20);
            this.costo_desde.TabIndex = 11;
            // 
            // stock_desde
            // 
            this.stock_desde.Location = new System.Drawing.Point(6, 49);
            this.stock_desde.Name = "stock_desde";
            this.stock_desde.Size = new System.Drawing.Size(60, 20);
            this.stock_desde.TabIndex = 6;
            this.stock_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // precio_desde
            // 
            this.precio_desde.Location = new System.Drawing.Point(6, 25);
            this.precio_desde.Name = "precio_desde";
            this.precio_desde.Size = new System.Drawing.Size(60, 20);
            this.precio_desde.TabIndex = 5;
            this.precio_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros_KeyPress);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(10, 47);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(39, 13);
            this.precio.TabIndex = 4;
            this.precio.Text = "precio:";
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_limpiar.BackgroundImage")));
            this.button_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_limpiar.Location = new System.Drawing.Point(727, 167);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 28);
            this.button_limpiar.TabIndex = 16;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_listar
            // 
            this.button_listar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_listar.BackgroundImage")));
            this.button_listar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_listar.Location = new System.Drawing.Point(646, 167);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(75, 28);
            this.button_listar.TabIndex = 2;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // groupBoxDeTexto
            // 
            this.groupBoxDeTexto.Controls.Add(this.descripcion);
            this.groupBoxDeTexto.Controls.Add(this.label_descripcion);
            this.groupBoxDeTexto.Controls.Add(this.estado);
            this.groupBoxDeTexto.Controls.Add(this.label_estado);
            this.groupBoxDeTexto.Controls.Add(this.visibilidad);
            this.groupBoxDeTexto.Controls.Add(this.label_visibilidad);
            this.groupBoxDeTexto.Controls.Add(this.cod_publicacion);
            this.groupBoxDeTexto.Controls.Add(this.label_cod_publicacion);
            this.groupBoxDeTexto.Location = new System.Drawing.Point(23, 20);
            this.groupBoxDeTexto.Name = "groupBoxDeTexto";
            this.groupBoxDeTexto.Size = new System.Drawing.Size(221, 124);
            this.groupBoxDeTexto.TabIndex = 26;
            this.groupBoxDeTexto.TabStop = false;
            this.groupBoxDeTexto.Text = "De texto:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(115, 91);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 25;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(46, 94);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 24;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(115, 67);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 20);
            this.estado.TabIndex = 23;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(70, 70);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(43, 13);
            this.label_estado.TabIndex = 22;
            this.label_estado.Text = "Estado:";
            // 
            // visibilidad
            // 
            this.visibilidad.Location = new System.Drawing.Point(115, 43);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(100, 20);
            this.visibilidad.TabIndex = 21;
            // 
            // label_visibilidad
            // 
            this.label_visibilidad.AutoSize = true;
            this.label_visibilidad.Location = new System.Drawing.Point(56, 46);
            this.label_visibilidad.Name = "label_visibilidad";
            this.label_visibilidad.Size = new System.Drawing.Size(56, 13);
            this.label_visibilidad.TabIndex = 20;
            this.label_visibilidad.Text = "Visibilidad:";
            // 
            // cod_publicacion
            // 
            this.cod_publicacion.Location = new System.Drawing.Point(115, 19);
            this.cod_publicacion.Name = "cod_publicacion";
            this.cod_publicacion.Size = new System.Drawing.Size(100, 20);
            this.cod_publicacion.TabIndex = 1;
            // 
            // label_cod_publicacion
            // 
            this.label_cod_publicacion.AutoSize = true;
            this.label_cod_publicacion.Location = new System.Drawing.Point(13, 22);
            this.label_cod_publicacion.Name = "label_cod_publicacion";
            this.label_cod_publicacion.Size = new System.Drawing.Size(100, 13);
            this.label_cod_publicacion.TabIndex = 0;
            this.label_cod_publicacion.Text = "Codigo publicacion:";
            // 
            // groupBox_aceptaPreguntas
            // 
            this.groupBox_aceptaPreguntas.Controls.Add(this.acepta_preguntasNo);
            this.groupBox_aceptaPreguntas.Controls.Add(this.acepta_preguntasAmbos);
            this.groupBox_aceptaPreguntas.Controls.Add(this.acepta_preguntasSi);
            this.groupBox_aceptaPreguntas.Location = new System.Drawing.Point(240, 150);
            this.groupBox_aceptaPreguntas.Name = "groupBox_aceptaPreguntas";
            this.groupBox_aceptaPreguntas.Size = new System.Drawing.Size(156, 43);
            this.groupBox_aceptaPreguntas.TabIndex = 15;
            this.groupBox_aceptaPreguntas.TabStop = false;
            this.groupBox_aceptaPreguntas.Text = "Acepta preguntas:";
            // 
            // acepta_preguntasNo
            // 
            this.acepta_preguntasNo.AutoSize = true;
            this.acepta_preguntasNo.BackColor = System.Drawing.Color.White;
            this.acepta_preguntasNo.Location = new System.Drawing.Point(114, 17);
            this.acepta_preguntasNo.Name = "acepta_preguntasNo";
            this.acepta_preguntasNo.Size = new System.Drawing.Size(39, 17);
            this.acepta_preguntasNo.TabIndex = 15;
            this.acepta_preguntasNo.Text = "No";
            this.acepta_preguntasNo.UseVisualStyleBackColor = false;
            // 
            // acepta_preguntasAmbos
            // 
            this.acepta_preguntasAmbos.AutoSize = true;
            this.acepta_preguntasAmbos.BackColor = System.Drawing.Color.White;
            this.acepta_preguntasAmbos.Checked = true;
            this.acepta_preguntasAmbos.Location = new System.Drawing.Point(12, 17);
            this.acepta_preguntasAmbos.Name = "acepta_preguntasAmbos";
            this.acepta_preguntasAmbos.Size = new System.Drawing.Size(57, 17);
            this.acepta_preguntasAmbos.TabIndex = 0;
            this.acepta_preguntasAmbos.TabStop = true;
            this.acepta_preguntasAmbos.Text = "Ambos";
            this.acepta_preguntasAmbos.UseVisualStyleBackColor = false;
            // 
            // acepta_preguntasSi
            // 
            this.acepta_preguntasSi.AutoSize = true;
            this.acepta_preguntasSi.BackColor = System.Drawing.Color.White;
            this.acepta_preguntasSi.Location = new System.Drawing.Point(75, 17);
            this.acepta_preguntasSi.Name = "acepta_preguntasSi";
            this.acepta_preguntasSi.Size = new System.Drawing.Size(34, 17);
            this.acepta_preguntasSi.TabIndex = 14;
            this.acepta_preguntasSi.Text = "Si";
            this.acepta_preguntasSi.UseVisualStyleBackColor = false;
            // 
            // FormGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 448);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewPublicacionesFiltradas);
            this.Controls.Add(this.grpBoxFiltrosBusqueda);
            this.Name = "FormGenerarPublicacion";
            this.Text = "Generar Publicidad";
            this.Load += new System.EventHandler(this.FormGenerarPublicacion_Load);
            this.Shown += new System.EventHandler(this.button_limpiar_Click);
            this.Validated += new System.EventHandler(this.button_limpiar_Click);
            this.Controls.SetChildIndex(this.grpBoxFiltrosBusqueda, 0);
            this.Controls.SetChildIndex(this.dataGridViewPublicacionesFiltradas, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.buttonNuevo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicacionesFiltradas)).EndInit();
            this.grpBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBox_ofrece_envios.ResumeLayout(false);
            this.groupBox_ofrece_envios.PerformLayout();
            this.groupBoxTipoPublicacion.ResumeLayout(false);
            this.groupBoxTipoPublicacion.PerformLayout();
            this.groupBoxDeFechas.ResumeLayout(false);
            this.groupBoxDeFechas.PerformLayout();
            this.groupBox_fecha_hasta.ResumeLayout(false);
            this.groupBox_fecha_desde.ResumeLayout(false);
            this.groupBoxDeMagnitud.ResumeLayout(false);
            this.groupBoxDeMagnitud.PerformLayout();
            this.groupBoxHasta.ResumeLayout(false);
            this.groupBoxHasta.PerformLayout();
            this.groupBoxDesde.ResumeLayout(false);
            this.groupBoxDesde.PerformLayout();
            this.groupBoxDeTexto.ResumeLayout(false);
            this.groupBoxDeTexto.PerformLayout();
            this.groupBox_aceptaPreguntas.ResumeLayout(false);
            this.groupBox_aceptaPreguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dataGridViewPublicacionesFiltradas;
        private System.Windows.Forms.GroupBox grpBoxFiltrosBusqueda;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.GroupBox groupBox_aceptaPreguntas;
        private System.Windows.Forms.RadioButton acepta_preguntasNo;
        private System.Windows.Forms.RadioButton acepta_preguntasAmbos;
        private System.Windows.Forms.RadioButton acepta_preguntasSi;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.TextBox precio_desde;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox cod_publicacion;
        private System.Windows.Forms.Label label_cod_publicacion;
        private System.Windows.Forms.GroupBox groupBoxDeTexto;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.TextBox visibilidad;
        private System.Windows.Forms.Label label_visibilidad;
        private System.Windows.Forms.GroupBox groupBoxDeMagnitud;
        private System.Windows.Forms.GroupBox groupBoxHasta;
        private System.Windows.Forms.TextBox precio_hasta;
        private System.Windows.Forms.GroupBox groupBoxDesde;
        private System.Windows.Forms.DateTimePicker fecha_inicio_desde;
        private System.Windows.Forms.Label costo;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox costo_hasta;
        private System.Windows.Forms.TextBox stock_hasta;
        private System.Windows.Forms.TextBox costo_desde;
        private System.Windows.Forms.TextBox stock_desde;
        private System.Windows.Forms.GroupBox groupBoxDeFechas;
        private System.Windows.Forms.Label fecha_vencimiernto;
        private System.Windows.Forms.Label fecha_inicio;
        private System.Windows.Forms.GroupBox groupBox_fecha_hasta;
        private System.Windows.Forms.DateTimePicker fecha_vencimiernto_hasta;
        private System.Windows.Forms.DateTimePicker fecha_inicio_hasta;
        private System.Windows.Forms.GroupBox groupBox_fecha_desde;
        private System.Windows.Forms.DateTimePicker fecha_vencimiernto_desde;
        private System.Windows.Forms.GroupBox groupBox_ofrece_envios;
        private System.Windows.Forms.RadioButton ofrece_enviosNo;
        private System.Windows.Forms.RadioButton ofrece_enviosAmbos;
        private System.Windows.Forms.RadioButton ofrece_enviosSi;
        private System.Windows.Forms.GroupBox groupBoxTipoPublicacion;
        private System.Windows.Forms.RadioButton tipo_publicacionSubasta;
        private System.Windows.Forms.RadioButton tipo_publicacionAmbos;
        private System.Windows.Forms.RadioButton tipo_publicacionCompra;
    }
}