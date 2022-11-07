namespace Presentacionn
{
    partial class frmBajaRotura
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
            this.btnEliminarRotura = new System.Windows.Forms.Button();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.mtxtRotura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnEliminarRotura
            // 
            this.btnEliminarRotura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRotura.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarRotura.Location = new System.Drawing.Point(170, 423);
            this.btnEliminarRotura.Name = "btnEliminarRotura";
            this.btnEliminarRotura.Size = new System.Drawing.Size(144, 55);
            this.btnEliminarRotura.TabIndex = 11;
            this.btnEliminarRotura.Text = "Eliminar";
            this.btnEliminarRotura.UseVisualStyleBackColor = false;
            this.btnEliminarRotura.Click += new System.EventHandler(this.btnEliminarRotura_Click);
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Location = new System.Drawing.Point(156, 146);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(54, 13);
            this.lblIdEquipo.TabIndex = 7;
            this.lblIdEquipo.Text = "ID Equipo";
            // 
            // mtxtRotura
            // 
            this.mtxtRotura.Location = new System.Drawing.Point(217, 138);
            this.mtxtRotura.Mask = "000000";
            this.mtxtRotura.Name = "mtxtRotura";
            this.mtxtRotura.Size = new System.Drawing.Size(100, 20);
            this.mtxtRotura.TabIndex = 12;
            // 
            // frmBajaRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtRotura);
            this.Controls.Add(this.btnEliminarRotura);
            this.Controls.Add(this.lblIdEquipo);
            this.Name = "frmBajaRotura";
            this.Text = "frmBajaRotura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarRotura;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.MaskedTextBox mtxtRotura;
    }
}