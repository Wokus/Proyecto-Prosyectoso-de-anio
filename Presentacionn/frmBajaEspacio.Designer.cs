namespace Presentacionn
{
    partial class frmBajaEspacio
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblNroEsp = new System.Windows.Forms.Label();
            this.txtBajaEspacio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaja.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBaja.Location = new System.Drawing.Point(170, 423);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(144, 55);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNroEsp
            // 
            this.lblNroEsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNroEsp.AutoSize = true;
            this.lblNroEsp.Location = new System.Drawing.Point(89, 146);
            this.lblNroEsp.Name = "lblNroEsp";
            this.lblNroEsp.Size = new System.Drawing.Size(99, 13);
            this.lblNroEsp.TabIndex = 1;
            this.lblNroEsp.Text = "Numero de espacio";
            this.lblNroEsp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBajaEspacio
            // 
            this.txtBajaEspacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBajaEspacio.Location = new System.Drawing.Point(194, 143);
            this.txtBajaEspacio.Name = "txtBajaEspacio";
            this.txtBajaEspacio.Size = new System.Drawing.Size(100, 20);
            this.txtBajaEspacio.TabIndex = 2;
            // 
            // frmBajaEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.txtBajaEspacio);
            this.Controls.Add(this.lblNroEsp);
            this.Controls.Add(this.btnBaja);
            this.Name = "frmBajaEspacio";
            this.Text = "frmBajaEspacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblNroEsp;
        private System.Windows.Forms.TextBox txtBajaEspacio;
    }
}