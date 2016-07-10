namespace MercadoEnvioFRBA.Presentacion.Facturas
{
    partial class FacturasVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasVendedor));
            this.timeHasta = new System.Windows.Forms.DateTimePicker();
            this.timeDesde = new System.Windows.Forms.DateTimePicker();
            this.fecha_inicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDeFechas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_importeHasta = new System.Windows.Forms.TextBox();
            this.txt_importeDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_formaPago = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numFact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBoxDeFechas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // timeHasta
            // 
            this.timeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeHasta.Location = new System.Drawing.Point(69, 60);
            this.timeHasta.Name = "timeHasta";
            this.timeHasta.Size = new System.Drawing.Size(82, 20);
            this.timeHasta.TabIndex = 29;
            // 
            // timeDesde
            // 
            this.timeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDesde.Location = new System.Drawing.Point(69, 26);
            this.timeDesde.Name = "timeDesde";
            this.timeDesde.Size = new System.Drawing.Size(82, 20);
            this.timeDesde.TabIndex = 28;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.AutoSize = true;
            this.fecha_inicio.Location = new System.Drawing.Point(22, 29);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(41, 13);
            this.fecha_inicio.TabIndex = 30;
            this.fecha_inicio.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hasta:";
            // 
            // groupBoxDeFechas
            // 
            this.groupBoxDeFechas.Controls.Add(this.fecha_inicio);
            this.groupBoxDeFechas.Controls.Add(this.timeDesde);
            this.groupBoxDeFechas.Controls.Add(this.label1);
            this.groupBoxDeFechas.Controls.Add(this.timeHasta);
            this.groupBoxDeFechas.Location = new System.Drawing.Point(553, 65);
            this.groupBoxDeFechas.Name = "groupBoxDeFechas";
            this.groupBoxDeFechas.Size = new System.Drawing.Size(175, 96);
            this.groupBoxDeFechas.TabIndex = 34;
            this.groupBoxDeFechas.TabStop = false;
            this.groupBoxDeFechas.Text = "Filtrar por fechas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_importeHasta);
            this.groupBox1.Controls.Add(this.txt_importeDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(326, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 96);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Importe:";
            // 
            // txt_importeHasta
            // 
            this.txt_importeHasta.Location = new System.Drawing.Point(69, 60);
            this.txt_importeHasta.Name = "txt_importeHasta";
            this.txt_importeHasta.Size = new System.Drawing.Size(100, 20);
            this.txt_importeHasta.TabIndex = 33;
            this.txt_importeHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importeHasta_KeyPress);
            // 
            // txt_importeDesde
            // 
            this.txt_importeDesde.Location = new System.Drawing.Point(69, 26);
            this.txt_importeDesde.Name = "txt_importeDesde";
            this.txt_importeDesde.Size = new System.Drawing.Size(100, 20);
            this.txt_importeDesde.TabIndex = 32;
            this.txt_importeDesde.TextChanged += new System.EventHandler(this.txt_importeDesde_TextChanged);
            this.txt_importeDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importeDesde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Hasta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cuil);
            this.groupBox2.Controls.Add(this.txt_dni);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(33, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 96);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por usuario al que está dirigida";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(69, 60);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(100, 20);
            this.txt_cuil.TabIndex = 33;
            this.txt_cuil.TextChanged += new System.EventHandler(this.txt_cuil_TextChanged);
            this.txt_cuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuil_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(69, 26);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 32;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "CUIL:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_formaPago);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_numFact);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(33, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 67);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por detalles de factura:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // check_formaPago
            // 
            this.check_formaPago.AutoSize = true;
            this.check_formaPago.Location = new System.Drawing.Point(377, 36);
            this.check_formaPago.Name = "check_formaPago";
            this.check_formaPago.Size = new System.Drawing.Size(65, 17);
            this.check_formaPago.TabIndex = 36;
            this.check_formaPago.Text = "Efectivo";
            this.check_formaPago.UseVisualStyleBackColor = true;
            this.check_formaPago.CheckedChanged += new System.EventHandler(this.check_formaPago_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Forma de pago:";
            // 
            // txt_numFact
            // 
            this.txt_numFact.Location = new System.Drawing.Point(126, 30);
            this.txt_numFact.Name = "txt_numFact";
            this.txt_numFact.Size = new System.Drawing.Size(100, 20);
            this.txt_numFact.TabIndex = 33;
            this.txt_numFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numFact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Número de factura:";
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(33, 277);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.Size = new System.Drawing.Size(761, 228);
            this.dataGridFacturas.TabIndex = 38;
            // 
            // button_guardar
            // 
            this.button_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_guardar.BackgroundImage")));
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_guardar.Location = new System.Drawing.Point(622, 209);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 28);
            this.button_guardar.TabIndex = 41;
            this.button_guardar.Text = "Buscar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // FacturasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 569);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.dataGridFacturas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDeFechas);
            this.Name = "FacturasVendedor";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.misFacturas_Load);
            this.Controls.SetChildIndex(this.groupBoxDeFechas, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.dataGridFacturas, 0);
            this.Controls.SetChildIndex(this.button_guardar, 0);
            this.groupBoxDeFechas.ResumeLayout(false);
            this.groupBoxDeFechas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeHasta;
        private System.Windows.Forms.DateTimePicker timeDesde;
        private System.Windows.Forms.Label fecha_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDeFechas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_importeHasta;
        private System.Windows.Forms.TextBox txt_importeDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cuil;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox check_formaPago;
        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.Button button_guardar;
    }
}