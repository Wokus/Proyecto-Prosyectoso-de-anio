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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsable
            // 
            this.dgvResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsable.Location = new System.Drawing.Point(12, 39);
            this.dgvResponsable.Name = "dgvResponsable";
            this.dgvResponsable.Size = new System.Drawing.Size(474, 457);
            this.dgvResponsable.TabIndex = 2;
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "General",
            "Profesor",
            "Alumno"});
            this.cbxTipo.Location = new System.Drawing.Point(12, 12);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.Text = "Tipo";
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // cbxCurso
            // 
            this.cbxCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Audiovisual 1",
            "Audiovisual 2",
            "Audiovisual 3",
            "Finest",
            "Tecnicatura 1",
            "Tecnicatura 2"});
            this.cbxCurso.Location = new System.Drawing.Point(138, 12);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(121, 21);
            this.cbxCurso.TabIndex = 7;
            this.cbxCurso.Text = "Curso";
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // frmListadoResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.dgvResponsable);
            this.Name = "frmListadoResponsable";
            this.Text = "frmListadoResponsable";
            this.Load += new System.EventHandler(this.frmListadoResponsable_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsable;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxCurso;
    }
}