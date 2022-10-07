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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbRotura = new System.Windows.Forms.CheckBox();
            this.chbAtrasado = new System.Windows.Forms.CheckBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 419);
            this.dataGridView1.TabIndex = 2;
            // 
            // chbRotura
            // 
            this.chbRotura.AutoSize = true;
            this.chbRotura.Location = new System.Drawing.Point(376, 22);
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
            this.chbAtrasado.Location = new System.Drawing.Point(250, 22);
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
            this.cbxTipo.Location = new System.Drawing.Point(22, 22);
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
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.chbAtrasado);
            this.Controls.Add(this.chbRotura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListadoResponsable";
            this.Text = "frmListadoResponsable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbRotura;
        private System.Windows.Forms.CheckBox chbAtrasado;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}