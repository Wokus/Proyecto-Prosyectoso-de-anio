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
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtResCi = new System.Windows.Forms.TextBox();
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
            this.cbxTipo.Location = new System.Drawing.Point(244, 133);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "cedula del responsable";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(244, 107);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 8;
            // 
            // txtResCi
            // 
            this.txtResCi.Location = new System.Drawing.Point(244, 81);
            this.txtResCi.Name = "txtResCi";
            this.txtResCi.Size = new System.Drawing.Size(100, 20);
            this.txtResCi.TabIndex = 7;
            // 
            // AltaResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.btnAregar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtResCi);
            this.Name = "AltaResponsable";
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
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtResCi;
    }
}