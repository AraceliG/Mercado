namespace MercadoEnvioFRBA.ABM_Usuario
{
    partial class FormularioAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCrearEmpres = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonbuscarEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionalidades:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "BUSCAR CLIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCrearEmpres
            // 
            this.buttonCrearEmpres.Location = new System.Drawing.Point(260, 157);
            this.buttonCrearEmpres.Name = "buttonCrearEmpres";
            this.buttonCrearEmpres.Size = new System.Drawing.Size(148, 40);
            this.buttonCrearEmpres.TabIndex = 2;
            this.buttonCrearEmpres.Text = "CREAR EMPRESA";
            this.buttonCrearEmpres.UseVisualStyleBackColor = true;
            this.buttonCrearEmpres.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "CREAR CLIENTE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonbuscarEmpresa
            // 
            this.buttonbuscarEmpresa.Location = new System.Drawing.Point(260, 98);
            this.buttonbuscarEmpresa.Name = "buttonbuscarEmpresa";
            this.buttonbuscarEmpresa.Size = new System.Drawing.Size(149, 40);
            this.buttonbuscarEmpresa.TabIndex = 4;
            this.buttonbuscarEmpresa.Text = "BUSCAR EMPRESA";
            this.buttonbuscarEmpresa.UseVisualStyleBackColor = true;
            this.buttonbuscarEmpresa.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 256);
            this.Controls.Add(this.buttonbuscarEmpresa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCrearEmpres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormularioAdministrador";
            this.Text = "hola Administrador!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCrearEmpres;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonbuscarEmpresa;
    }
}