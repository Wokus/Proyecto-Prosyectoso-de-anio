namespace Presentacionn
{
    partial class frmModificacionRotura
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
            this.btnModificarRotura = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrestamoRotura = new System.Windows.Forms.Label();
            this.lblEquipoRoto = new System.Windows.Forms.Label();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEquipoRoto = new System.Windows.Forms.TextBox();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.lblResponsableRotura = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbxIdRotura = new System.Windows.Forms.ComboBox();
            this.lblIdRotura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarRotura
            // 
            this.btnModificarRotura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarRotura.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarRotura.Location = new System.Drawing.Point(170, 423);
            this.btnModificarRotura.Name = "btnModificarRotura";
            this.btnModificarRotura.Size = new System.Drawing.Size(144, 55);
            this.btnModificarRotura.TabIndex = 40;
            this.btnModificarRotura.Text = "Modificar";
            this.btnModificarRotura.UseVisualStyleBackColor = false;
            this.btnModificarRotura.Click += new System.EventHandler(this.btnModificarRotura_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(244, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 39;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrestamoRotura
            // 
            this.lblPrestamoRotura.AutoSize = true;
            this.lblPrestamoRotura.Location = new System.Drawing.Point(25, 183);
            this.lblPrestamoRotura.Name = "lblPrestamoRotura";
            this.lblPrestamoRotura.Size = new System.Drawing.Size(51, 13);
            this.lblPrestamoRotura.TabIndex = 37;
            this.lblPrestamoRotura.Text = "Prestamo";
            // 
            // lblEquipoRoto
            // 
            this.lblEquipoRoto.AutoSize = true;
            this.lblEquipoRoto.Location = new System.Drawing.Point(12, 123);
            this.lblEquipoRoto.Name = "lblEquipoRoto";
            this.lblEquipoRoto.Size = new System.Drawing.Size(66, 13);
            this.lblEquipoRoto.TabIndex = 36;
            this.lblEquipoRoto.Text = "Equipo Roto";
            // 
            // txtPres
            // 
            this.txtPres.Location = new System.Drawing.Point(82, 180);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(100, 20);
            this.txtPres.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 120);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 110);
            this.textBox3.TabIndex = 34;
            // 
            // txtEquipoRoto
            // 
            this.txtEquipoRoto.Location = new System.Drawing.Point(82, 120);
            this.txtEquipoRoto.Name = "txtEquipoRoto";
            this.txtEquipoRoto.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoRoto.TabIndex = 33;
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.Location = new System.Drawing.Point(82, 60);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtIdEquipo.TabIndex = 32;
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Location = new System.Drawing.Point(24, 63);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(54, 13);
            this.lblIdEquipo.TabIndex = 42;
            this.lblIdEquipo.Text = "ID Equipo";
            // 
            // lblResponsableRotura
            // 
            this.lblResponsableRotura.AutoSize = true;
            this.lblResponsableRotura.Location = new System.Drawing.Point(12, 243);
            this.lblResponsableRotura.Name = "lblResponsableRotura";
            this.lblResponsableRotura.Size = new System.Drawing.Size(69, 13);
            this.lblResponsableRotura.TabIndex = 38;
            this.lblResponsableRotura.Text = "Responsable";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 41;
            // 
            // cbxIdRotura
            // 
            this.cbxIdRotura.FormattingEnabled = true;
            this.cbxIdRotura.Location = new System.Drawing.Point(313, 59);
            this.cbxIdRotura.Name = "cbxIdRotura";
            this.cbxIdRotura.Size = new System.Drawing.Size(121, 21);
            this.cbxIdRotura.TabIndex = 43;
            this.cbxIdRotura.Text = "Id Rotura";
            // 
            // lblIdRotura
            // 
            this.lblIdRotura.AutoSize = true;
            this.lblIdRotura.Location = new System.Drawing.Point(256, 63);
            this.lblIdRotura.Name = "lblIdRotura";
            this.lblIdRotura.Size = new System.Drawing.Size(53, 13);
            this.lblIdRotura.TabIndex = 16;
            this.lblIdRotura.Text = "ID Rotura";
            // 
            // frmModificacionRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIdRotura);
            this.Controls.Add(this.cbxIdRotura);
            this.Controls.Add(this.lblIdEquipo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnModificarRotura);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblResponsableRotura);
            this.Controls.Add(this.lblPrestamoRotura);
            this.Controls.Add(this.lblEquipoRoto);
            this.Controls.Add(this.txtPres);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtEquipoRoto);
            this.Controls.Add(this.txtIdEquipo);
            this.Name = "frmModificacionRotura";
            this.Text = "frmModificacionRotura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarRotura;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrestamoRotura;
        private System.Windows.Forms.Label lblEquipoRoto;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEquipoRoto;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.Label lblResponsableRotura;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cbxIdRotura;
        private System.Windows.Forms.Label lblIdRotura;
    }
}