namespace Presentacionn
{
    partial class frmListadoPrestamo
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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dgvListadoEquipo = new System.Windows.Forms.DataGridView();
            this.cbxFecha = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxPrioridad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Prestamos generales",
            "Prestamos de equipo",
            "Prestamo espontaneo",
            "Prestamo de espacio"});
            this.cbxTipo.Location = new System.Drawing.Point(12, 12);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 0;
            this.cbxTipo.Text = "Tipos de prestamo";
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxListadosPrestamos_SelectedIndexChanged);
            // 
            // dgvListadoEquipo
            // 
            this.dgvListadoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEquipo.Location = new System.Drawing.Point(12, 39);
            this.dgvListadoEquipo.Name = "dgvListadoEquipo";
            this.dgvListadoEquipo.Size = new System.Drawing.Size(474, 457);
            this.dgvListadoEquipo.TabIndex = 1;
            this.dgvListadoEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbxFecha
            // 
            this.cbxFecha.FormattingEnabled = true;
            this.cbxFecha.Items.AddRange(new object[] {
            "De mas antiguo a mas reciente",
            "De mas reciente a mas antiguo"});
            this.cbxFecha.Location = new System.Drawing.Point(365, 12);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(121, 21);
            this.cbxFecha.TabIndex = 2;
            this.cbxFecha.Text = "Orden por Fecha";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto "});
            this.cbxEstado.Location = new System.Drawing.Point(139, 12);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(105, 21);
            this.cbxEstado.TabIndex = 3;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // cbxPrioridad
            // 
            this.cbxPrioridad.FormattingEnabled = true;
            this.cbxPrioridad.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto "});
            this.cbxPrioridad.Location = new System.Drawing.Point(253, 12);
            this.cbxPrioridad.Name = "cbxPrioridad";
            this.cbxPrioridad.Size = new System.Drawing.Size(106, 21);
            this.cbxPrioridad.TabIndex = 4;
            this.cbxPrioridad.Text = "Prioridad";
            this.cbxPrioridad.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridad_SelectedIndexChanged);
            // 
            // frmListadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxPrioridad);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxFecha);
            this.Controls.Add(this.dgvListadoEquipo);
            this.Controls.Add(this.cbxTipo);
            this.Name = "frmListadoPrestamo";
            this.Text = "frmListadoPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListadoEquipo;
        private System.Windows.Forms.ComboBox cbxFecha;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxPrioridad;
    }
}