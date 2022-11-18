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
            this.lblIdPrestamoBaja = new System.Windows.Forms.Label();
            this.mtxtidPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.Location = new System.Drawing.Point(170, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 55);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdPrestamoBaja
            // 
            this.lblIdPrestamoBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdPrestamoBaja.AutoSize = true;
            this.lblIdPrestamoBaja.Location = new System.Drawing.Point(107, 150);
            this.lblIdPrestamoBaja.Name = "lblIdPrestamoBaja";
            this.lblIdPrestamoBaja.Size = new System.Drawing.Size(81, 13);
            this.lblIdPrestamoBaja.TabIndex = 2;
            this.lblIdPrestamoBaja.Text = "ID del prestamo";
            // 
            // mtxtidPrestamo
            // 
            this.mtxtidPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtidPrestamo.Location = new System.Drawing.Point(194, 147);
            this.mtxtidPrestamo.Mask = "0000000";
            this.mtxtidPrestamo.Name = "mtxtidPrestamo";
            this.mtxtidPrestamo.Size = new System.Drawing.Size(100, 20);
            this.mtxtidPrestamo.TabIndex = 3;
            // 
            // frmBajaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtidPrestamo);
            this.Controls.Add(this.lblIdPrestamoBaja);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmBajaPrestamo";
            this.Text = "frmBajaPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdPrestamoBaja;
        private System.Windows.Forms.MaskedTextBox mtxtidPrestamo;
    }
}