namespace Presentacionn
{
    partial class frmListadoResponsable
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
            this.dgvResponsable = new System.Windows.Forms.DataGridView();
            this.chbRotura = new System.Windows.Forms.CheckBox();
            this.chbAtrasado = new System.Windows.Forms.CheckBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsable
            // 
            this.dgvResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsable.Location = new System.Drawing.Point(12, 39);
            this.dgvResponsable.Name = "dgvResponsable";
            this.dgvResponsable.Size = new System.Drawing.Size(474, 457);
            this.dgvResponsable.TabIndex = 2;
            // 
            // chbRotura
            // 
            this.chbRotura.AutoSize = true;
            this.chbRotura.Location = new System.Drawing.Point(391, 16);
            this.chbRotura.Name = "chbRotura";
            this.chbRotura.Size = new System.Drawing.Size(95, 17);
            this.chbRotura.TabIndex = 3;
            this.chbRotura.Text = "Equipos Rotos";
            this.chbRotura.UseVisualStyleBackColor = true;
            this.chbRotura.CheckedChanged += new System.EventHandler(this.chbRotura_CheckedChanged);
            // 
            // chbAtrasado
            // 
            this.chbAtrasado.AutoSize = true;
            this.chbAtrasado.Location = new System.Drawing.Point(265, 16);
            this.chbAtrasado.Name = "chbAtrasado";
            this.chbAtrasado.Size = new System.Drawing.Size(120, 17);
            this.chbAtrasado.TabIndex = 4;
            this.chbAtrasado.Text = "Prestamo Atrasados";
            this.chbAtrasado.UseVisualStyleBackColor = true;
            this.chbAtrasado.CheckedChanged += new System.EventHandler(this.chbAtrasado_CheckedChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Profesor",
            "Alumno"});
            this.cbxTipo.Location = new System.Drawing.Point(12, 12);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.Text = "Tipo";
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // frmListadoResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.chbAtrasado);
            this.Controls.Add(this.chbRotura);
            this.Controls.Add(this.dgvResponsable);
            this.Name = "frmListadoResponsable";
            this.Text = "frmListadoResponsable";
            this.Load += new System.EventHandler(this.frmListadoResponsable_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsable;
        private System.Windows.Forms.CheckBox chbRotura;
        private System.Windows.Forms.CheckBox chbAtrasado;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}