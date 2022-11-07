namespace Presentacionn
{
    partial class frmListadoEspacio
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
            this.dgvListadoEspacio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoEspacio
            // 
            this.dgvListadoEspacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEspacio.Location = new System.Drawing.Point(12, 39);
            this.dgvListadoEspacio.Name = "dgvListadoEspacio";
            this.dgvListadoEspacio.Size = new System.Drawing.Size(474, 457);
            this.dgvListadoEspacio.TabIndex = 2;
            // 
            // frmListadoEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.dgvListadoEspacio);
            this.Name = "frmListadoEspacio";
            this.Text = "frmListadoEspacio";
            this.Load += new System.EventHandler(this.frmListadoEspacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEspacio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoEspacio;
    }
}