namespace Presentacionn
{
    partial class frmModificacionEspacio
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
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.mtxtNumeroCam = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroCam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNumero.Location = new System.Drawing.Point(214, 141);
            this.mtxtNumero.Mask = "0000000";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumero.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(214, 191);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(168, 144);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Numero";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 194);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(170, 423);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 55);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // mtxtNumeroCam
            // 
            this.mtxtNumeroCam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNumeroCam.Location = new System.Drawing.Point(214, 91);
            this.mtxtNumeroCam.Mask = "0000000";
            this.mtxtNumeroCam.Name = "mtxtNumeroCam";
            this.mtxtNumeroCam.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumeroCam.TabIndex = 29;
            // 
            // lblNumeroCam
            // 
            this.lblNumeroCam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroCam.AutoSize = true;
            this.lblNumeroCam.Location = new System.Drawing.Point(119, 94);
            this.lblNumeroCam.Name = "lblNumeroCam";
            this.lblNumeroCam.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroCam.TabIndex = 28;
            this.lblNumeroCam.Text = "Numero a cambiar";
            // 
            // frmModificacionEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtNumeroCam);
            this.Controls.Add(this.lblNumeroCam);
            this.Controls.Add(this.mtxtNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Name = "frmModificacionEspacio";
            this.Text = "frmModificacionEspacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MaskedTextBox mtxtNumeroCam;
        private System.Windows.Forms.Label lblNumeroCam;
    }
}