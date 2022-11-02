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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCedulaResponsable = new System.Windows.Forms.Label();
            this.txtResCi = new System.Windows.Forms.TextBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.txtNombreRes = new System.Windows.Forms.TextBox();
            this.txtApellidoRes = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAregar
            // 
            this.btnAregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAregar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAregar.Location = new System.Drawing.Point(170, 423);
            this.btnAregar.Name = "btnAregar";
            this.btnAregar.Size = new System.Drawing.Size(144, 55);
            this.btnAregar.TabIndex = 6;
            this.btnAregar.Text = "Agregar";
            this.btnAregar.UseVisualStyleBackColor = false;
            this.btnAregar.Click += new System.EventHandler(this.btnAregar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Estudiantes",
            "Profesor"});
            this.cbxTipo.Location = new System.Drawing.Point(244, 186);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 12;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(210, 189);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(204, 162);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 10;
            this.lblCurso.Text = "Curso";
            // 
            // lblCedulaResponsable
            // 
            this.lblCedulaResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCedulaResponsable.AutoSize = true;
            this.lblCedulaResponsable.Location = new System.Drawing.Point(122, 84);
            this.lblCedulaResponsable.Name = "lblCedulaResponsable";
            this.lblCedulaResponsable.Size = new System.Drawing.Size(117, 13);
            this.lblCedulaResponsable.TabIndex = 9;
            this.lblCedulaResponsable.Text = "Cedula del responsable";
            // 
            // txtResCi
            // 
            this.txtResCi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResCi.Location = new System.Drawing.Point(244, 81);
            this.txtResCi.Name = "txtResCi";
            this.txtResCi.Size = new System.Drawing.Size(100, 20);
            this.txtResCi.TabIndex = 7;
            // 
            // cbxCurso
            // 
            this.cbxCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.txtNombreRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreRes.Location = new System.Drawing.Point(244, 107);
            this.txtNombreRes.Name = "txtNombreRes";
            this.txtNombreRes.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRes.TabIndex = 14;
            // 
            // txtApellidoRes
            // 
            this.txtApellidoRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidoRes.Location = new System.Drawing.Point(244, 133);
            this.txtApellidoRes.Name = "txtApellidoRes";
            this.txtApellidoRes.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoRes.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(194, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // frmAltaResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellidoRes);
            this.Controls.Add(this.txtNombreRes);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.btnAregar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCedulaResponsable);
            this.Controls.Add(this.txtResCi);
            this.Name = "frmAltaResponsable";
            this.Text = "AltaResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAregar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCedulaResponsable;
        private System.Windows.Forms.TextBox txtResCi;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TextBox txtNombreRes;
        private System.Windows.Forms.TextBox txtApellidoRes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
    }
}