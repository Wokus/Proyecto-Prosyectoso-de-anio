namespace Presentacionn
{
    partial class frmBajaPrestamo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdPrestamoBaja = new System.Windows.Forms.TextBox();
            this.lblIdPrestamoBaja = new System.Windows.Forms.Label();
            this.cbxPrestamosAEliminar = new System.Windows.Forms.ComboBox();
            this.txtBajaPrestamoEspacio = new System.Windows.Forms.TextBox();
            this.txtBajaPrestamoEspontaneo = new System.Windows.Forms.TextBox();
            this.btnEliminarPrestamoEspacio = new System.Windows.Forms.Button();
            this.btnEliminarPrestamoEspontaneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 55);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdPrestamoBaja
            // 
            this.txtIdPrestamoBaja.Location = new System.Drawing.Point(189, 192);
            this.txtIdPrestamoBaja.Name = "txtIdPrestamoBaja";
            this.txtIdPrestamoBaja.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamoBaja.TabIndex = 1;
            // 
            // lblIdPrestamoBaja
            // 
            this.lblIdPrestamoBaja.AutoSize = true;
            this.lblIdPrestamoBaja.Location = new System.Drawing.Point(120, 195);
            this.lblIdPrestamoBaja.Name = "lblIdPrestamoBaja";
            this.lblIdPrestamoBaja.Size = new System.Drawing.Size(63, 13);
            this.lblIdPrestamoBaja.TabIndex = 2;
            this.lblIdPrestamoBaja.Text = "Id Prestamo";
            // 
            // cbxPrestamosAEliminar
            // 
            this.cbxPrestamosAEliminar.FormattingEnabled = true;
            this.cbxPrestamosAEliminar.Items.AddRange(new object[] {
            "Prestamo de Equipo",
            "Prestamo de Espacio",
            "Prestamo Espontaneo"});
            this.cbxPrestamosAEliminar.Location = new System.Drawing.Point(349, 12);
            this.cbxPrestamosAEliminar.Name = "cbxPrestamosAEliminar";
            this.cbxPrestamosAEliminar.Size = new System.Drawing.Size(133, 21);
            this.cbxPrestamosAEliminar.TabIndex = 3;
            this.cbxPrestamosAEliminar.Text = "Prestamo a Eliminar";
            this.cbxPrestamosAEliminar.SelectedIndexChanged += new System.EventHandler(this.cbxPrestamosAEliminar_SelectedIndexChanged);
            // 
            // txtBajaPrestamoEspacio
            // 
            this.txtBajaPrestamoEspacio.Location = new System.Drawing.Point(189, 192);
            this.txtBajaPrestamoEspacio.Name = "txtBajaPrestamoEspacio";
            this.txtBajaPrestamoEspacio.Size = new System.Drawing.Size(100, 20);
            this.txtBajaPrestamoEspacio.TabIndex = 4;
            // 
            // txtBajaPrestamoEspontaneo
            // 
            this.txtBajaPrestamoEspontaneo.Location = new System.Drawing.Point(189, 192);
            this.txtBajaPrestamoEspontaneo.Name = "txtBajaPrestamoEspontaneo";
            this.txtBajaPrestamoEspontaneo.Size = new System.Drawing.Size(100, 20);
            this.txtBajaPrestamoEspontaneo.TabIndex = 5;
            // 
            // btnEliminarPrestamoEspacio
            // 
            this.btnEliminarPrestamoEspacio.Location = new System.Drawing.Point(170, 423);
            this.btnEliminarPrestamoEspacio.Name = "btnEliminarPrestamoEspacio";
            this.btnEliminarPrestamoEspacio.Size = new System.Drawing.Size(144, 55);
            this.btnEliminarPrestamoEspacio.TabIndex = 6;
            this.btnEliminarPrestamoEspacio.Text = "Eliminar";
            this.btnEliminarPrestamoEspacio.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamoEspacio.Click += new System.EventHandler(this.btnEliminarPrestamoEspacio_Click);
            // 
            // btnEliminarPrestamoEspontaneo
            // 
            this.btnEliminarPrestamoEspontaneo.Location = new System.Drawing.Point(170, 423);
            this.btnEliminarPrestamoEspontaneo.Name = "btnEliminarPrestamoEspontaneo";
            this.btnEliminarPrestamoEspontaneo.Size = new System.Drawing.Size(144, 55);
            this.btnEliminarPrestamoEspontaneo.TabIndex = 7;
            this.btnEliminarPrestamoEspontaneo.Text = "Eliminar";
            this.btnEliminarPrestamoEspontaneo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamoEspontaneo.Click += new System.EventHandler(this.btnEliminarPrestamoEspontaneo_Click);
            // 
            // frmBajaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.btnEliminarPrestamoEspontaneo);
            this.Controls.Add(this.btnEliminarPrestamoEspacio);
            this.Controls.Add(this.txtBajaPrestamoEspontaneo);
            this.Controls.Add(this.txtBajaPrestamoEspacio);
            this.Controls.Add(this.cbxPrestamosAEliminar);
            this.Controls.Add(this.lblIdPrestamoBaja);
            this.Controls.Add(this.txtIdPrestamoBaja);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmBajaPrestamo";
            this.Text = "frmBajaPrestamo";
            this.Load += new System.EventHandler(this.frmBajaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdPrestamoBaja;
        private System.Windows.Forms.Label lblIdPrestamoBaja;
        private System.Windows.Forms.ComboBox cbxPrestamosAEliminar;
        private System.Windows.Forms.TextBox txtBajaPrestamoEspacio;
        private System.Windows.Forms.TextBox txtBajaPrestamoEspontaneo;
        private System.Windows.Forms.Button btnEliminarPrestamoEspacio;
        private System.Windows.Forms.Button btnEliminarPrestamoEspontaneo;
    }
}