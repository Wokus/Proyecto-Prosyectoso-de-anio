namespace Presentacionn
{
    partial class frmModificacionResponsable
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNewCi = new System.Windows.Forms.TextBox();
            this.lblCedulaNueva = new System.Windows.Forms.Label();
            this.txtOldCi = new System.Windows.Forms.TextBox();
            this.btnModiRes = new System.Windows.Forms.Button();
            this.lblCedulaAmodificar = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
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
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(213, 123);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 19;
            this.lblCurso.Text = "Curso";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(219, 149);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNewCi
            // 
            this.txtNewCi.Location = new System.Drawing.Point(256, 94);
            this.txtNewCi.Name = "txtNewCi";
            this.txtNewCi.Size = new System.Drawing.Size(100, 20);
            this.txtNewCi.TabIndex = 16;
            // 
            // lblCedulaNueva
            // 
            this.lblCedulaNueva.AutoSize = true;
            this.lblCedulaNueva.Location = new System.Drawing.Point(174, 97);
            this.lblCedulaNueva.Name = "lblCedulaNueva";
            this.lblCedulaNueva.Size = new System.Drawing.Size(73, 13);
            this.lblCedulaNueva.TabIndex = 15;
            this.lblCedulaNueva.Text = "Cedula nueva";
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
            this.btnModiRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModiRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModiRes.Location = new System.Drawing.Point(170, 423);
            this.btnModiRes.Name = "btnModiRes";
            this.btnModiRes.Size = new System.Drawing.Size(144, 55);
            this.btnModiRes.TabIndex = 13;
            this.btnModiRes.Text = "Modificar";
            this.btnModiRes.UseVisualStyleBackColor = false;
            this.btnModiRes.Click += new System.EventHandler(this.btnModiRes_Click);
            // 
            // lblCedulaAmodificar
            // 
            this.lblCedulaAmodificar.AutoSize = true;
            this.lblCedulaAmodificar.Location = new System.Drawing.Point(76, 71);
            this.lblCedulaAmodificar.Name = "lblCedulaAmodificar";
            this.lblCedulaAmodificar.Size = new System.Drawing.Size(171, 13);
            this.lblCedulaAmodificar.TabIndex = 12;
            this.lblCedulaAmodificar.Text = "Cedula del responsable a modificar";
            // 
            // cbxCurso
            // 
            this.cbxCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.cbxCurso.Location = new System.Drawing.Point(256, 120);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(100, 21);
            this.cbxCurso.TabIndex = 22;
            // 
            // frmModificacionResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.cbxNewTipo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNewCi);
            this.Controls.Add(this.lblCedulaNueva);
            this.Controls.Add(this.txtOldCi);
            this.Controls.Add(this.btnModiRes);
            this.Controls.Add(this.lblCedulaAmodificar);
            this.Name = "frmModificacionResponsable";
            this.Text = "ModificarResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNewTipo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNewCi;
        private System.Windows.Forms.Label lblCedulaNueva;
        private System.Windows.Forms.TextBox txtOldCi;
        private System.Windows.Forms.Button btnModiRes;
        private System.Windows.Forms.Label lblCedulaAmodificar;
        private System.Windows.Forms.ComboBox cbxCurso;
    }
}