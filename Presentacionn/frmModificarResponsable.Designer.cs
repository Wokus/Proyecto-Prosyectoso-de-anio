namespace Presentacionn
{
    partial class frmModificarResponsable
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
            this.cbxNewTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewCurso = new System.Windows.Forms.TextBox();
            this.txtNewCi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldCi = new System.Windows.Forms.TextBox();
            this.btnModiRes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxNewTipo
            // 
            this.cbxNewTipo.FormattingEnabled = true;
            this.cbxNewTipo.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cbxNewTipo.Location = new System.Drawing.Point(256, 146);
            this.cbxNewTipo.Name = "cbxNewTipo";
            this.cbxNewTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxNewTipo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo";
            // 
            // txtNewCurso
            // 
            this.txtNewCurso.Location = new System.Drawing.Point(256, 120);
            this.txtNewCurso.Name = "txtNewCurso";
            this.txtNewCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNewCurso.TabIndex = 17;
            // 
            // txtNewCi
            // 
            this.txtNewCi.Location = new System.Drawing.Point(256, 94);
            this.txtNewCi.Name = "txtNewCi";
            this.txtNewCi.Size = new System.Drawing.Size(100, 20);
            this.txtNewCi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cedula nueva";
            // 
            // txtOldCi
            // 
            this.txtOldCi.Location = new System.Drawing.Point(256, 68);
            this.txtOldCi.Name = "txtOldCi";
            this.txtOldCi.Size = new System.Drawing.Size(100, 20);
            this.txtOldCi.TabIndex = 14;
            // 
            // btnModiRes
            // 
            this.btnModiRes.Location = new System.Drawing.Point(178, 396);
            this.btnModiRes.Name = "btnModiRes";
            this.btnModiRes.Size = new System.Drawing.Size(147, 41);
            this.btnModiRes.TabIndex = 13;
            this.btnModiRes.Text = "Modificar";
            this.btnModiRes.UseVisualStyleBackColor = true;
            this.btnModiRes.Click += new System.EventHandler(this.btnModiRes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cedula del responsable a modificar";
            // 
            // ModificarResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxNewTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNewCurso);
            this.Controls.Add(this.txtNewCi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOldCi);
            this.Controls.Add(this.btnModiRes);
            this.Controls.Add(this.label5);
            this.Name = "ModificarResponsable";
            this.Text = "ModificarResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNewTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewCurso;
        private System.Windows.Forms.TextBox txtNewCi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOldCi;
        private System.Windows.Forms.Button btnModiRes;
        private System.Windows.Forms.Label label5;
    }
}