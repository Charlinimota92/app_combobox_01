namespace app_combobox_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Asignatura = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_Asignatura = new System.Windows.Forms.Label();
            this.lbl_Indice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignatura";
            // 
            // cbo_Asignatura
            // 
            this.cbo_Asignatura.FormattingEnabled = true;
            this.cbo_Asignatura.Items.AddRange(new object[] {
            "Lengua Española",
            "Matemática",
            "Ciencias Sociales",
            "Ciencias de la Naturaleza",
            "Formación y Orientación Laboral",
            "Inglés",
            "Educación Fisica"});
            this.cbo_Asignatura.Location = new System.Drawing.Point(122, 78);
            this.cbo_Asignatura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbo_Asignatura.Name = "cbo_Asignatura";
            this.cbo_Asignatura.Size = new System.Drawing.Size(317, 30);
            this.cbo_Asignatura.TabIndex = 1;
            this.cbo_Asignatura.SelectedIndexChanged += new System.EventHandler(this.cbo_Asignatura_SelectedIndexChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(408, 144);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 39);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_Asignatura
            // 
            this.lbl_Asignatura.AutoSize = true;
            this.lbl_Asignatura.Location = new System.Drawing.Point(27, 144);
            this.lbl_Asignatura.Name = "lbl_Asignatura";
            this.lbl_Asignatura.Size = new System.Drawing.Size(59, 22);
            this.lbl_Asignatura.TabIndex = 3;
            this.lbl_Asignatura.Text = "label2";
            this.lbl_Asignatura.Click += new System.EventHandler(this.lbl_Asignatura_Click);
            // 
            // lbl_Indice
            // 
            this.lbl_Indice.AutoSize = true;
            this.lbl_Indice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Indice.Location = new System.Drawing.Point(31, 185);
            this.lbl_Indice.Name = "lbl_Indice";
            this.lbl_Indice.Size = new System.Drawing.Size(59, 22);
            this.lbl_Indice.TabIndex = 4;
            this.lbl_Indice.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 506);
            this.Controls.Add(this.lbl_Indice);
            this.Controls.Add(this.lbl_Asignatura);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.cbo_Asignatura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Asignatura;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_Asignatura;
        private System.Windows.Forms.Label lbl_Indice;
    }
}

