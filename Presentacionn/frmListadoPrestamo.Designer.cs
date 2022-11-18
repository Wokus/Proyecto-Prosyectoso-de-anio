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
            this.cbxFechaEquipo = new System.Windows.Forms.ComboBox();
            this.cbxFechaEspontaneo = new System.Windows.Forms.ComboBox();
            this.cbxFechaEspacio = new System.Windows.Forms.ComboBox();
            this.cbxEstadoEquipo = new System.Windows.Forms.ComboBox();
            this.cbxEstadoEspacio = new System.Windows.Forms.ComboBox();
            this.cbxEstadoEspontaneo = new System.Windows.Forms.ComboBox();
            this.cbxPrioridad = new System.Windows.Forms.ComboBox();
            this.cbxPrioridadEspacio = new System.Windows.Forms.ComboBox();
            this.cbxPrioridadEquipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.dgvListadoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEquipo.Location = new System.Drawing.Point(12, 39);
            this.dgvListadoEquipo.Name = "dgvListadoEquipo";
            this.dgvListadoEquipo.Size = new System.Drawing.Size(474, 457);
            this.dgvListadoEquipo.TabIndex = 1;
            // 
            // cbxFecha
            // 
            this.cbxFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFecha.FormattingEnabled = true;
            this.cbxFecha.Items.AddRange(new object[] {
            "De mas antiguo a mas reciente",
            "De mas reciente a mas antiguo"});
            this.cbxFecha.Location = new System.Drawing.Point(139, 12);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(104, 21);
            this.cbxFecha.TabIndex = 2;
            this.cbxFecha.Text = "Listado por fecha";
            this.cbxFecha.SelectedIndexChanged += new System.EventHandler(this.cbxFecha_SelectedIndexChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto ",
            "En progreso"});
            this.cbxEstado.Location = new System.Drawing.Point(249, 12);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(110, 21);
            this.cbxEstado.TabIndex = 3;
            this.cbxEstado.Text = "Listado por estado";
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged_1);
            // 
            // cbxFechaEquipo
            // 
            this.cbxFechaEquipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFechaEquipo.Items.AddRange(new object[] {
            "De mas antiguo a mas reciente",
            "De mas reciente a mas antiguo"});
            this.cbxFechaEquipo.Location = new System.Drawing.Point(139, 12);
            this.cbxFechaEquipo.Name = "cbxFechaEquipo";
            this.cbxFechaEquipo.Size = new System.Drawing.Size(104, 21);
            this.cbxFechaEquipo.TabIndex = 14;
            this.cbxFechaEquipo.Text = "Listado por fecha";
            this.cbxFechaEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxFechaEquipo_SelectedIndexChanged_1);
            // 
            // cbxFechaEspontaneo
            // 
            this.cbxFechaEspontaneo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFechaEspontaneo.Items.AddRange(new object[] {
            "De mas antiguo a mas reciente",
            "De mas reciente a mas antiguo"});
            this.cbxFechaEspontaneo.Location = new System.Drawing.Point(139, 12);
            this.cbxFechaEspontaneo.Name = "cbxFechaEspontaneo";
            this.cbxFechaEspontaneo.Size = new System.Drawing.Size(104, 21);
            this.cbxFechaEspontaneo.TabIndex = 13;
            this.cbxFechaEspontaneo.Text = "Listado por fecha";
            this.cbxFechaEspontaneo.SelectedIndexChanged += new System.EventHandler(this.cbxFechaEspontaneo_SelectedIndexChanged_1);
            // 
            // cbxFechaEspacio
            // 
            this.cbxFechaEspacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFechaEspacio.Items.AddRange(new object[] {
            "De mas antiguo a mas reciente",
            "De mas reciente a mas antiguo"});
            this.cbxFechaEspacio.Location = new System.Drawing.Point(139, 12);
            this.cbxFechaEspacio.Name = "cbxFechaEspacio";
            this.cbxFechaEspacio.Size = new System.Drawing.Size(104, 21);
            this.cbxFechaEspacio.TabIndex = 12;
            this.cbxFechaEspacio.Text = "Listado por fecha";
            this.cbxFechaEspacio.SelectedIndexChanged += new System.EventHandler(this.cbxFechaEspacio_SelectedIndexChanged_1);
            // 
            // cbxEstadoEquipo
            // 
            this.cbxEstadoEquipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstadoEquipo.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto ",
            "En progreso"});
            this.cbxEstadoEquipo.Location = new System.Drawing.Point(249, 12);
            this.cbxEstadoEquipo.Name = "cbxEstadoEquipo";
            this.cbxEstadoEquipo.Size = new System.Drawing.Size(110, 21);
            this.cbxEstadoEquipo.TabIndex = 11;
            this.cbxEstadoEquipo.Text = "Listado por estado";
            this.cbxEstadoEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoEquipo_SelectedIndexChanged_1);
            // 
            // cbxEstadoEspacio
            // 
            this.cbxEstadoEspacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstadoEspacio.FormattingEnabled = true;
            this.cbxEstadoEspacio.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto ",
            "En progreso"});
            this.cbxEstadoEspacio.Location = new System.Drawing.Point(249, 12);
            this.cbxEstadoEspacio.Name = "cbxEstadoEspacio";
            this.cbxEstadoEspacio.Size = new System.Drawing.Size(110, 21);
            this.cbxEstadoEspacio.TabIndex = 9;
            this.cbxEstadoEspacio.Text = "Listado por estado";
            this.cbxEstadoEspacio.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoEspacio_SelectedIndexChanged);
            // 
            // cbxEstadoEspontaneo
            // 
            this.cbxEstadoEspontaneo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstadoEspontaneo.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Cancelado",
            "Devuelto ",
            "En progreso"});
            this.cbxEstadoEspontaneo.Location = new System.Drawing.Point(249, 12);
            this.cbxEstadoEspontaneo.Name = "cbxEstadoEspontaneo";
            this.cbxEstadoEspontaneo.Size = new System.Drawing.Size(110, 21);
            this.cbxEstadoEspontaneo.TabIndex = 10;
            this.cbxEstadoEspontaneo.Text = "Listado por estado";
            this.cbxEstadoEspontaneo.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoEspontaneo_SelectedIndexChanged_1);
            // 
            // cbxPrioridad
            // 
            this.cbxPrioridad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPrioridad.FormattingEnabled = true;
            this.cbxPrioridad.Items.AddRange(new object[] {
            "De mayor a menor",
            "De menor a mayor"});
            this.cbxPrioridad.Location = new System.Drawing.Point(365, 12);
            this.cbxPrioridad.Name = "cbxPrioridad";
            this.cbxPrioridad.Size = new System.Drawing.Size(117, 21);
            this.cbxPrioridad.TabIndex = 15;
            this.cbxPrioridad.Text = "Listado por prioridad";
            this.cbxPrioridad.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridad_SelectedIndexChanged);
            // 
            // cbxPrioridadEspacio
            // 
            this.cbxPrioridadEspacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPrioridadEspacio.FormattingEnabled = true;
            this.cbxPrioridadEspacio.Items.AddRange(new object[] {
            "De mayor a menor",
            "De menor a mayor"});
            this.cbxPrioridadEspacio.Location = new System.Drawing.Point(365, 12);
            this.cbxPrioridadEspacio.Name = "cbxPrioridadEspacio";
            this.cbxPrioridadEspacio.Size = new System.Drawing.Size(117, 21);
            this.cbxPrioridadEspacio.TabIndex = 16;
            this.cbxPrioridadEspacio.Text = "Listado por prioridad";
            this.cbxPrioridadEspacio.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridadEspacio_SelectedIndexChanged);
            // 
            // cbxPrioridadEquipo
            // 
            this.cbxPrioridadEquipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPrioridadEquipo.FormattingEnabled = true;
            this.cbxPrioridadEquipo.Items.AddRange(new object[] {
            "De mayor a menor",
            "De menor a mayor"});
            this.cbxPrioridadEquipo.Location = new System.Drawing.Point(365, 12);
            this.cbxPrioridadEquipo.Name = "cbxPrioridadEquipo";
            this.cbxPrioridadEquipo.Size = new System.Drawing.Size(117, 21);
            this.cbxPrioridadEquipo.TabIndex = 18;
            this.cbxPrioridadEquipo.Text = "Listado por prioridad";
            this.cbxPrioridadEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridadEquipo_SelectedIndexChanged);
            // 
            // frmListadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.cbxPrioridadEquipo);
            this.Controls.Add(this.cbxPrioridadEspacio);
            this.Controls.Add(this.cbxPrioridad);
            this.Controls.Add(this.cbxEstadoEspacio);
            this.Controls.Add(this.cbxEstadoEspontaneo);
            this.Controls.Add(this.cbxEstadoEquipo);
            this.Controls.Add(this.cbxFechaEspacio);
            this.Controls.Add(this.cbxFechaEspontaneo);
            this.Controls.Add(this.cbxFechaEquipo);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxFecha);
            this.Controls.Add(this.dgvListadoEquipo);
            this.Controls.Add(this.cbxTipo);
            this.Name = "frmListadoPrestamo";
            this.Text = "frmListadoPrestamo";
            this.Load += new System.EventHandler(this.frmListadoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListadoEquipo;
        private System.Windows.Forms.ComboBox cbxFecha;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxFechaEquipo;
        private System.Windows.Forms.ComboBox cbxFechaEspontaneo;
        private System.Windows.Forms.ComboBox cbxFechaEspacio;
        private System.Windows.Forms.ComboBox cbxEstadoEquipo;
        private System.Windows.Forms.ComboBox cbxEstadoEspacio;
        private System.Windows.Forms.ComboBox cbxEstadoEspontaneo;
        private System.Windows.Forms.ComboBox cbxPrioridad;
        private System.Windows.Forms.ComboBox cbxPrioridadEspacio;
        private System.Windows.Forms.ComboBox cbxPrioridadEquipo;
    }
}