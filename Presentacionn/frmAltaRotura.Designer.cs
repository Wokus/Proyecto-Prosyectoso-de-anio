namespace Presentacionn
{
    partial class frmAltaRotura
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
            this.txtEquipoRoto = new System.Windows.Forms.TextBox();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProResponsable = new System.Windows.Forms.TextBox();
            this.lblEquipoRoto = new System.Windows.Forms.Label();
            this.lblPrestamoRotura = new System.Windows.Forms.Label();
            this.lblResponsableRotura = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAluResponsable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEquipoRoto
            // 
            this.txtEquipoRoto.Location = new System.Drawing.Point(120, 63);
            this.txtEquipoRoto.Name = "txtEquipoRoto";
            this.txtEquipoRoto.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoRoto.TabIndex = 0;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(120, 123);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtPrestamo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(298, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 110);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtProResponsable
            // 
            this.txtProResponsable.Location = new System.Drawing.Point(120, 240);
            this.txtProResponsable.Name = "txtProResponsable";
            this.txtProResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtProResponsable.TabIndex = 4;
            // 
            // lblEquipoRoto
            // 
            this.lblEquipoRoto.AutoSize = true;
            this.lblEquipoRoto.Location = new System.Drawing.Point(48, 66);
            this.lblEquipoRoto.Name = "lblEquipoRoto";
            this.lblEquipoRoto.Size = new System.Drawing.Size(66, 13);
            this.lblEquipoRoto.TabIndex = 5;
            this.lblEquipoRoto.Text = "Equipo Roto";
            // 
            // lblPrestamoRotura
            // 
            this.lblPrestamoRotura.AutoSize = true;
            this.lblPrestamoRotura.Location = new System.Drawing.Point(63, 126);
            this.lblPrestamoRotura.Name = "lblPrestamoRotura";
            this.lblPrestamoRotura.Size = new System.Drawing.Size(51, 13);
            this.lblPrestamoRotura.TabIndex = 6;
            this.lblPrestamoRotura.Text = "Prestamo";
            // 
            // lblResponsableRotura
            // 
            this.lblResponsableRotura.AutoSize = true;
            this.lblResponsableRotura.Location = new System.Drawing.Point(8, 243);
            this.lblResponsableRotura.Name = "lblResponsableRotura";
            this.lblResponsableRotura.Size = new System.Drawing.Size(106, 13);
            this.lblResponsableRotura.TabIndex = 7;
            this.lblResponsableRotura.Text = "Profesor responsable";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(229, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(170, 423);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(144, 55);
            this.btnAgregarPrestamo.TabIndex = 31;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Alumno responsable";
            // 
            // txtAluResponsable
            // 
            this.txtAluResponsable.Location = new System.Drawing.Point(120, 183);
            this.txtAluResponsable.Name = "txtAluResponsable";
            this.txtAluResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtAluResponsable.TabIndex = 32;
            // 
            // frmAltaRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAluResponsable);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblResponsableRotura);
            this.Controls.Add(this.lblPrestamoRotura);
            this.Controls.Add(this.lblEquipoRoto);
            this.Controls.Add(this.txtProResponsable);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.txtEquipoRoto);
            this.Name = "frmAltaRotura";
            this.Text = "frmAltaRotura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquipoRoto;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProResponsable;
        private System.Windows.Forms.Label lblEquipoRoto;
        private System.Windows.Forms.Label lblPrestamoRotura;
        private System.Windows.Forms.Label lblResponsableRotura;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAluResponsable;
    }
}