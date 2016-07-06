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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.dataGridPublicacion = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.comboBox_rubro0.Size = new System.Drawing.Size(343, 28);
            this.comboBox_rubro0.TabIndex = 117;
            this.comboBox_rubro0.SelectedIndexChanged += new System.EventHandler(this.comboBox_rubro0_SelectedIndexChanged);
            // 
            // comboBox_rubro1
            // 
            this.comboBox_rubro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro1.FormattingEnabled = true;
            this.comboBox_rubro1.Location = new System.Drawing.Point(249, 94);
            this.comboBox_rubro1.Name = "comboBox_rubro1";
            this.comboBox_rubro1.Size = new System.Drawing.Size(343, 28);
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
            this.comboBox_rubro2.Location = new System.Drawing.Point(598, 94);
            this.comboBox_rubro2.Name = "comboBox_rubro2";
            this.comboBox_rubro2.Size = new System.Drawing.Size(343, 28);
            this.comboBox_rubro2.TabIndex = 120;
            this.comboBox_rubro2.SelectedIndexChanged += new System.EventHandler(this.comboBox_rubro2_SelectedIndexChanged);
            // 
            // comboBox_rubro3
            // 
            this.comboBox_rubro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rubro3.FormattingEnabled = true;
            this.comboBox_rubro3.Location = new System.Drawing.Point(598, 142);
            this.comboBox_rubro3.Name = "comboBox_rubro3";
            this.comboBox_rubro3.Size = new System.Drawing.Size(343, 28);
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
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(249, 197);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(198, 29);
            this.txt_desc.TabIndex = 124;
            // 
            // dataGridPublicacion
            // 
            this.dataGridPublicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicacion.Location = new System.Drawing.Point(43, 259);
            this.dataGridPublicacion.Name = "dataGridPublicacion";
            this.dataGridPublicacion.Size = new System.Drawing.Size(875, 230);
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
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(43, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 127;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(162, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 128;
            this.button2.Text = "Ofertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dataGridPublicacion);
            this.Controls.Add(this.txt_desc);
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
            this.Controls.SetChildIndex(this.txt_desc, 0);
            this.Controls.SetChildIndex(this.dataGridPublicacion, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
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
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.DataGridView dataGridPublicacion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}