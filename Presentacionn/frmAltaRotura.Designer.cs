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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEquipoRoto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregarRotura = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mtxtEquipoRoto = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIdPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.idPrestamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(298, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 110);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblEquipoRoto
            // 
            this.lblEquipoRoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEquipoRoto.AutoSize = true;
            this.lblEquipoRoto.Location = new System.Drawing.Point(48, 66);
            this.lblEquipoRoto.Name = "lblEquipoRoto";
            this.lblEquipoRoto.Size = new System.Drawing.Size(66, 13);
            this.lblEquipoRoto.TabIndex = 5;
            this.lblEquipoRoto.Text = "Equipo Roto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(229, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnAgregarRotura
            // 
            this.btnAgregarRotura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRotura.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarRotura.Location = new System.Drawing.Point(170, 423);
            this.btnAgregarRotura.Name = "btnAgregarRotura";
            this.btnAgregarRotura.Size = new System.Drawing.Size(144, 55);
            this.btnAgregarRotura.TabIndex = 31;
            this.btnAgregarRotura.Text = "Agregar";
            this.btnAgregarRotura.UseVisualStyleBackColor = false;
            this.btnAgregarRotura.Click += new System.EventHandler(this.btnAgregarRotura_Click_1);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 123);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 34;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(77, 129);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // mtxtEquipoRoto
            // 
            this.mtxtEquipoRoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtEquipoRoto.Location = new System.Drawing.Point(120, 63);
            this.mtxtEquipoRoto.Mask = "00000000";
            this.mtxtEquipoRoto.Name = "mtxtEquipoRoto";
            this.mtxtEquipoRoto.Size = new System.Drawing.Size(100, 20);
            this.mtxtEquipoRoto.TabIndex = 35;
            // 
            // mtxtIdPrestamo
            // 
            this.mtxtIdPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtIdPrestamo.Location = new System.Drawing.Point(120, 183);
            this.mtxtIdPrestamo.Mask = "00000000";
            this.mtxtIdPrestamo.Name = "mtxtIdPrestamo";
            this.mtxtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.mtxtIdPrestamo.TabIndex = 37;
            // 
            // idPrestamo
            // 
            this.idPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idPrestamo.AutoSize = true;
            this.idPrestamo.Location = new System.Drawing.Point(48, 186);
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.Size = new System.Drawing.Size(62, 13);
            this.idPrestamo.TabIndex = 36;
            this.idPrestamo.Text = "id Prestamo";
            // 
            // frmAltaRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtIdPrestamo);
            this.Controls.Add(this.idPrestamo);
            this.Controls.Add(this.mtxtEquipoRoto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnAgregarRotura);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEquipoRoto);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAltaRotura";
            this.Text = "frmAltaRotura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEquipoRoto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregarRotura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mtxtEquipoRoto;
        private System.Windows.Forms.MaskedTextBox mtxtIdPrestamo;
        private System.Windows.Forms.Label idPrestamo;
    }
}