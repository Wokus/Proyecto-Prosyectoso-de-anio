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
            this.txtDescricion = new System.Windows.Forms.TextBox();
            this.lblIdRotura = new System.Windows.Forms.Label();
            this.mtxtRotura = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mtxtEquipo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPrestamo = new System.Windows.Forms.MaskedTextBox();
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
            this.lblDescripcion.Location = new System.Drawing.Point(244, 71);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 39;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrestamoRotura
            // 
            this.lblPrestamoRotura.AutoSize = true;
            this.lblPrestamoRotura.Location = new System.Drawing.Point(25, 237);
            this.lblPrestamoRotura.Name = "lblPrestamoRotura";
            this.lblPrestamoRotura.Size = new System.Drawing.Size(51, 13);
            this.lblPrestamoRotura.TabIndex = 37;
            this.lblPrestamoRotura.Text = "Prestamo";
            // 
            // lblEquipoRoto
            // 
            this.lblEquipoRoto.AutoSize = true;
            this.lblEquipoRoto.Location = new System.Drawing.Point(12, 127);
            this.lblEquipoRoto.Name = "lblEquipoRoto";
            this.lblEquipoRoto.Size = new System.Drawing.Size(66, 13);
            this.lblEquipoRoto.TabIndex = 36;
            this.lblEquipoRoto.Text = "Equipo Roto";
            // 
            // txtDescricion
            // 
            this.txtDescricion.Location = new System.Drawing.Point(313, 64);
            this.txtDescricion.Multiline = true;
            this.txtDescricion.Name = "txtDescricion";
            this.txtDescricion.Size = new System.Drawing.Size(169, 110);
            this.txtDescricion.TabIndex = 34;
            // 
            // lblIdRotura
            // 
            this.lblIdRotura.AutoSize = true;
            this.lblIdRotura.Location = new System.Drawing.Point(27, 71);
            this.lblIdRotura.Name = "lblIdRotura";
            this.lblIdRotura.Size = new System.Drawing.Size(51, 13);
            this.lblIdRotura.TabIndex = 16;
            this.lblIdRotura.Text = "Id Rotura";
            // 
            // mtxtRotura
            // 
            this.mtxtRotura.Location = new System.Drawing.Point(82, 64);
            this.mtxtRotura.Mask = "00000";
            this.mtxtRotura.Name = "mtxtRotura";
            this.mtxtRotura.Size = new System.Drawing.Size(100, 20);
            this.mtxtRotura.TabIndex = 43;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(82, 177);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 45;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 183);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 44;
            this.lblFecha.Text = "Fecha";
            // 
            // mtxtEquipo
            // 
            this.mtxtEquipo.Location = new System.Drawing.Point(82, 124);
            this.mtxtEquipo.Mask = "00000";
            this.mtxtEquipo.Name = "mtxtEquipo";
            this.mtxtEquipo.Size = new System.Drawing.Size(100, 20);
            this.mtxtEquipo.TabIndex = 46;
            // 
            // mtxtPrestamo
            // 
            this.mtxtPrestamo.Location = new System.Drawing.Point(82, 237);
            this.mtxtPrestamo.Mask = "00000";
            this.mtxtPrestamo.Name = "mtxtPrestamo";
            this.mtxtPrestamo.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrestamo.TabIndex = 47;
            // 
            // frmModificacionRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtPrestamo);
            this.Controls.Add(this.mtxtEquipo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mtxtRotura);
            this.Controls.Add(this.lblIdRotura);
            this.Controls.Add(this.btnModificarRotura);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrestamoRotura);
            this.Controls.Add(this.lblEquipoRoto);
            this.Controls.Add(this.txtDescricion);
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
        private System.Windows.Forms.TextBox txtDescricion;
        private System.Windows.Forms.Label lblIdRotura;
        private System.Windows.Forms.MaskedTextBox mtxtRotura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mtxtEquipo;
        private System.Windows.Forms.MaskedTextBox mtxtPrestamo;
    }
}