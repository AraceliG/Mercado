namespace MercadoEnvioFRBA.ComprarOfertar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_rubro0 = new System.Windows.Forms.ComboBox();
            this.comboBox_rubro1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_rubro2 = new System.Windows.Forms.ComboBox();
            this.comboBox_rubro3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Compralabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridPublicacion = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_rubro0
            // 
            this.comboBox_rubro0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro0.FormattingEnabled = true;
            this.comboBox_rubro0.Location = new System.Drawing.Point(249, 142);
            this.comboBox_rubro0.Name = "comboBox_rubro0";
            this.comboBox_rubro0.Size = new System.Drawing.Size(198, 28);
            this.comboBox_rubro0.TabIndex = 117;
            // 
            // comboBox_rubro1
            // 
            this.comboBox_rubro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro1.FormattingEnabled = true;
            this.comboBox_rubro1.Location = new System.Drawing.Point(249, 94);
            this.comboBox_rubro1.Name = "comboBox_rubro1";
            this.comboBox_rubro1.Size = new System.Drawing.Size(198, 28);
            this.comboBox_rubro1.TabIndex = 118;
            this.comboBox_rubro1.SelectedIndexChanged += new System.EventHandler(this.comboBox_rubro1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "Rubros para búsqueda:";
            // 
            // comboBox_rubro2
            // 
            this.comboBox_rubro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro2.FormattingEnabled = true;
            this.comboBox_rubro2.Location = new System.Drawing.Point(472, 94);
            this.comboBox_rubro2.Name = "comboBox_rubro2";
            this.comboBox_rubro2.Size = new System.Drawing.Size(198, 28);
            this.comboBox_rubro2.TabIndex = 120;
            // 
            // comboBox_rubro3
            // 
            this.comboBox_rubro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro3.FormattingEnabled = true;
            this.comboBox_rubro3.Location = new System.Drawing.Point(472, 142);
            this.comboBox_rubro3.Name = "comboBox_rubro3";
            this.comboBox_rubro3.Size = new System.Drawing.Size(198, 28);
            this.comboBox_rubro3.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 122;
            this.label2.Text = "Descripción:";
            // 
            // Compralabel
            // 
            this.Compralabel.AutoSize = true;
            this.Compralabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compralabel.Image = global::MercadoEnvioFRBA.Properties.Resources.fondoBoton1;
            this.Compralabel.Location = new System.Drawing.Point(390, 18);
            this.Compralabel.Name = "Compralabel";
            this.Compralabel.Size = new System.Drawing.Size(159, 24);
            this.Compralabel.TabIndex = 123;
            this.Compralabel.Text = "Comprar/Ofertar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(249, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 29);
            this.textBox1.TabIndex = 124;
            // 
            // dataGridPublicacion
            // 
            this.dataGridPublicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicacion.Location = new System.Drawing.Point(43, 259);
            this.dataGridPublicacion.Name = "dataGridPublicacion";
            this.dataGridPublicacion.Size = new System.Drawing.Size(875, 191);
            this.dataGridPublicacion.TabIndex = 125;
            this.dataGridPublicacion.VirtualMode = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(538, 197);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(96, 41);
            this.btn_buscar.TabIndex = 126;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 478);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dataGridPublicacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Compralabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_rubro3);
            this.Controls.Add(this.comboBox_rubro2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_rubro1);
            this.Controls.Add(this.comboBox_rubro0);
            this.Name = "Form1";
            this.Text = "Comprar/Ofertar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.comboBox_rubro0, 0);
            this.Controls.SetChildIndex(this.comboBox_rubro1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox_rubro2, 0);
            this.Controls.SetChildIndex(this.comboBox_rubro3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Compralabel, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridPublicacion, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_rubro0;
        private System.Windows.Forms.ComboBox comboBox_rubro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_rubro2;
        private System.Windows.Forms.ComboBox comboBox_rubro3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Compralabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridPublicacion;
        private System.Windows.Forms.Button btn_buscar;
    }
}