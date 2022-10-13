namespace Presentacionn
{
    partial class frmAltaResponsable
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
            this.btnAregar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResCi = new System.Windows.Forms.TextBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.txtNombreRes = new System.Windows.Forms.TextBox();
            this.txtApellidoRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAregar
            // 
            this.btnAregar.Location = new System.Drawing.Point(213, 409);
            this.btnAregar.Name = "btnAregar";
            this.btnAregar.Size = new System.Drawing.Size(131, 43);
            this.btnAregar.TabIndex = 6;
            this.btnAregar.Text = "Agregar";
            this.btnAregar.UseVisualStyleBackColor = true;
            this.btnAregar.Click += new System.EventHandler(this.btnAregar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Estudiantes",
            "Profesor"});
            this.cbxTipo.Location = new System.Drawing.Point(244, 186);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 12;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cedula del responsable";
            // 
            // txtResCi
            // 
            this.txtResCi.Location = new System.Drawing.Point(244, 81);
            this.txtResCi.Name = "txtResCi";
            this.txtResCi.Size = new System.Drawing.Size(100, 20);
            this.txtResCi.TabIndex = 7;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.cbxCurso.Location = new System.Drawing.Point(244, 159);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(100, 21);
            this.cbxCurso.TabIndex = 13;
            // 
            // txtNombreRes
            // 
            this.txtNombreRes.Location = new System.Drawing.Point(244, 107);
            this.txtNombreRes.Name = "txtNombreRes";
            this.txtNombreRes.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRes.TabIndex = 14;
            // 
            // txtApellidoRes
            // 
            this.txtApellidoRes.Location = new System.Drawing.Point(244, 133);
            this.txtApellidoRes.Name = "txtApellidoRes";
            this.txtApellidoRes.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoRes.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apellido";
            // 
            // frmAltaResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoRes);
            this.Controls.Add(this.txtNombreRes);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.btnAregar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResCi);
            this.Name = "frmAltaResponsable";
            this.Text = "AltaResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAregar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResCi;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TextBox txtNombreRes;
        private System.Windows.Forms.TextBox txtApellidoRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}