namespace Presentacionn
{
    partial class frmAltaPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.mtxtFechaDevolucion = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaRetiro = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaSolicitud = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAsegurado = new System.Windows.Forms.Label();
            this.lblFechaIgreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.mtxtHoraRetiro = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblLocacion = new System.Windows.Forms.Label();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.lblEquipoID = new System.Windows.Forms.Label();
            this.txtEquipoID = new System.Windows.Forms.TextBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.cbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblIDSalon = new System.Windows.Forms.Label();
            this.txtNombreSalon = new System.Windows.Forms.TextBox();
            this.lblNombreSalon = new System.Windows.Forms.Label();
            this.txtIDSalon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Profesor responsable";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(264, 178);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 42;
            this.txtProfesor.TextChanged += new System.EventHandler(this.txtProfesor_TextChanged);
            // 
            // mtxtFechaDevolucion
            // 
            this.mtxtFechaDevolucion.Location = new System.Drawing.Point(29, 244);
            this.mtxtFechaDevolucion.Mask = "00/00/0000";
            this.mtxtFechaDevolucion.Name = "mtxtFechaDevolucion";
            this.mtxtFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaDevolucion.TabIndex = 41;
            this.mtxtFechaDevolucion.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaDevolucion.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaDevolucion_MaskInputRejected);
            // 
            // mtxtFechaRetiro
            // 
            this.mtxtFechaRetiro.Location = new System.Drawing.Point(29, 179);
            this.mtxtFechaRetiro.Mask = "00/00/0000";
            this.mtxtFechaRetiro.Name = "mtxtFechaRetiro";
            this.mtxtFechaRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaRetiro.TabIndex = 40;
            this.mtxtFechaRetiro.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaRetiro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaRetiro_MaskInputRejected);
            // 
            // mtxtFechaSolicitud
            // 
            this.mtxtFechaSolicitud.Location = new System.Drawing.Point(29, 119);
            this.mtxtFechaSolicitud.Mask = "00/00/0000";
            this.mtxtFechaSolicitud.Name = "mtxtFechaSolicitud";
            this.mtxtFechaSolicitud.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaSolicitud.TabIndex = 39;
            this.mtxtFechaSolicitud.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaSolicitud.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaSolicitud_MaskInputRejected);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(26, 289);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 13);
            this.lblTipo.TabIndex = 38;
            this.lblTipo.Text = "Estado";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // lblAsegurado
            // 
            this.lblAsegurado.AutoSize = true;
            this.lblAsegurado.Location = new System.Drawing.Point(26, 228);
            this.lblAsegurado.Name = "lblAsegurado";
            this.lblAsegurado.Size = new System.Drawing.Size(107, 13);
            this.lblAsegurado.TabIndex = 37;
            this.lblAsegurado.Text = "Fecha de devolucion";
            this.lblAsegurado.Click += new System.EventHandler(this.lblAsegurado_Click);
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(132, 163);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIgreso.TabIndex = 36;
            this.lblFechaIgreso.Text = "Hora de retiro";
            this.lblFechaIgreso.Click += new System.EventHandler(this.lblFechaIgreso_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 163);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 13);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Fecha de retiro";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(261, 102);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(107, 13);
            this.lblNumeroSerie.TabIndex = 34;
            this.lblNumeroSerie.Text = "Alumno Responsable";
            this.lblNumeroSerie.Click += new System.EventHandler(this.lblNumeroSerie_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(26, 103);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(93, 13);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Fecha de solicitud";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Devuelto",
            "Cancelado"});
            this.cbxEstado.Location = new System.Drawing.Point(29, 305);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.Text = "Armado";
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // mtxtHoraRetiro
            // 
            this.mtxtHoraRetiro.Location = new System.Drawing.Point(135, 179);
            this.mtxtHoraRetiro.Mask = "00:00";
            this.mtxtHoraRetiro.Name = "mtxtHoraRetiro";
            this.mtxtHoraRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraRetiro.TabIndex = 31;
            this.mtxtHoraRetiro.ValidatingType = typeof(System.DateTime);
            this.mtxtHoraRetiro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtHoraRetiro_MaskInputRejected);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(170, 423);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(144, 55);
            this.btnAgregarPrestamo.TabIndex = 30;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(264, 118);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno.TabIndex = 29;
            this.txtAlumno.TextChanged += new System.EventHandler(this.txtAlumno_TextChanged);
            // 
            // lblLocacion
            // 
            this.lblLocacion.AutoSize = true;
            this.lblLocacion.Location = new System.Drawing.Point(379, 102);
            this.lblLocacion.Name = "lblLocacion";
            this.lblLocacion.Size = new System.Drawing.Size(51, 13);
            this.lblLocacion.TabIndex = 47;
            this.lblLocacion.Text = "Locacion";
            this.lblLocacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLocacion
            // 
            this.txtLocacion.Location = new System.Drawing.Point(382, 118);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 46;
            this.txtLocacion.TextChanged += new System.EventHandler(this.txtLocacion_TextChanged);
            // 
            // lblEquipoID
            // 
            this.lblEquipoID.AutoSize = true;
            this.lblEquipoID.Location = new System.Drawing.Point(264, 228);
            this.lblEquipoID.Name = "lblEquipoID";
            this.lblEquipoID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipoID.TabIndex = 45;
            this.lblEquipoID.Text = "Equipo(ID)";
            this.lblEquipoID.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEquipoID
            // 
            this.txtEquipoID.Location = new System.Drawing.Point(267, 244);
            this.txtEquipoID.Name = "txtEquipoID";
            this.txtEquipoID.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoID.TabIndex = 44;
            this.txtEquipoID.TextChanged += new System.EventHandler(this.txtEquipoID_TextChanged);
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(379, 163);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(58, 13);
            this.lblTransporte.TabIndex = 49;
            this.lblTransporte.Text = "Transporte";
            this.lblTransporte.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(382, 179);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 48;
            this.txtTransporte.TextChanged += new System.EventHandler(this.txtTransporte_TextChanged);
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(379, 228);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblEjercicio.TabIndex = 51;
            this.lblEjercicio.Text = "Ejercicio";
            this.lblEjercicio.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(382, 244);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 50;
            this.txtEjercicio.TextChanged += new System.EventHandler(this.txtEjercicio_TextChanged);
            // 
            // cbxTipoPrestamo
            // 
            this.cbxTipoPrestamo.FormattingEnabled = true;
            this.cbxTipoPrestamo.Items.AddRange(new object[] {
            "De equipo(Formales)",
            "De espacio",
            "Expontaneo"});
            this.cbxTipoPrestamo.Location = new System.Drawing.Point(361, 28);
            this.cbxTipoPrestamo.Name = "cbxTipoPrestamo";
            this.cbxTipoPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoPrestamo.TabIndex = 52;
            this.cbxTipoPrestamo.Text = "De equipo(Formales)";
            this.cbxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPrestamo_SelectedIndexChanged);
            // 
            // lblIDSalon
            // 
            this.lblIDSalon.AutoSize = true;
            this.lblIDSalon.Location = new System.Drawing.Point(379, 163);
            this.lblIDSalon.Name = "lblIDSalon";
            this.lblIDSalon.Size = new System.Drawing.Size(48, 13);
            this.lblIDSalon.TabIndex = 74;
            this.lblIDSalon.Text = "ID Salon";
            this.lblIDSalon.Visible = false;
            // 
            // txtNombreSalon
            // 
            this.txtNombreSalon.Location = new System.Drawing.Point(382, 118);
            this.txtNombreSalon.Name = "txtNombreSalon";
            this.txtNombreSalon.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSalon.TabIndex = 73;
            this.txtNombreSalon.Visible = false;
            // 
            // lblNombreSalon
            // 
            this.lblNombreSalon.AutoSize = true;
            this.lblNombreSalon.Location = new System.Drawing.Point(379, 103);
            this.lblNombreSalon.Name = "lblNombreSalon";
            this.lblNombreSalon.Size = new System.Drawing.Size(87, 13);
            this.lblNombreSalon.TabIndex = 72;
            this.lblNombreSalon.Text = "Numero de salon";
            this.lblNombreSalon.Visible = false;
            // 
            // txtIDSalon
            // 
            this.txtIDSalon.Location = new System.Drawing.Point(382, 179);
            this.txtIDSalon.Name = "txtIDSalon";
            this.txtIDSalon.Size = new System.Drawing.Size(100, 20);
            this.txtIDSalon.TabIndex = 71;
            this.txtIDSalon.Visible = false;
            // 
            // frmAltaPrestamoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIDSalon);
            this.Controls.Add(this.txtNombreSalon);
            this.Controls.Add(this.lblNombreSalon);
            this.Controls.Add(this.txtIDSalon);
            this.Controls.Add(this.cbxTipoPrestamo);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.lblLocacion);
            this.Controls.Add(this.txtLocacion);
            this.Controls.Add(this.lblEquipoID);
            this.Controls.Add(this.txtEquipoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.mtxtFechaDevolucion);
            this.Controls.Add(this.mtxtFechaRetiro);
            this.Controls.Add(this.mtxtFechaSolicitud);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblAsegurado);
            this.Controls.Add(this.lblFechaIgreso);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.mtxtHoraRetiro);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.txtAlumno);
            this.Name = "frmAltaPrestamoEquipo";
            this.Text = "frmAltaPrestamo";
            this.Load += new System.EventHandler(this.frmAltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.MaskedTextBox mtxtFechaDevolucion;
        private System.Windows.Forms.MaskedTextBox mtxtFechaRetiro;
        private System.Windows.Forms.MaskedTextBox mtxtFechaSolicitud;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAsegurado;
        private System.Windows.Forms.Label lblFechaIgreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mtxtHoraRetiro;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblLocacion;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.Label lblEquipoID;
        private System.Windows.Forms.TextBox txtEquipoID;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.ComboBox cbxTipoPrestamo;
        private System.Windows.Forms.Label lblIDSalon;
        private System.Windows.Forms.TextBox txtNombreSalon;
        private System.Windows.Forms.Label lblNombreSalon;
        private System.Windows.Forms.TextBox txtIDSalon;
    }
}