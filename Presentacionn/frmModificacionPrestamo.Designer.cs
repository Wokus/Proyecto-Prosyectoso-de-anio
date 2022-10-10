namespace Presentacionn
{
    partial class frmModificacionPrestamo
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
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.cbxModificacionPrestamo = new System.Windows.Forms.ComboBox();
            this.lblIDSalon = new System.Windows.Forms.Label();
            this.txtNombreSalon = new System.Windows.Forms.TextBox();
            this.lblNombreSalon = new System.Windows.Forms.Label();
            this.txtIDSalon = new System.Windows.Forms.TextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.lblLocacion = new System.Windows.Forms.Label();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.lblEquipoID = new System.Windows.Forms.Label();
            this.txtEquipoID = new System.Windows.Forms.TextBox();
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
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Location = new System.Drawing.Point(170, 423);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(144, 55);
            this.btnModificarPrestamo.TabIndex = 8;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // cbxModificacionPrestamo
            // 
            this.cbxModificacionPrestamo.FormattingEnabled = true;
            this.cbxModificacionPrestamo.Items.AddRange(new object[] {
            "Prestamo de Equipo",
            "Prestamo de Espacio",
            "Prestamo Espontaneo"});
            this.cbxModificacionPrestamo.Location = new System.Drawing.Point(357, 12);
            this.cbxModificacionPrestamo.Name = "cbxModificacionPrestamo";
            this.cbxModificacionPrestamo.Size = new System.Drawing.Size(125, 21);
            this.cbxModificacionPrestamo.TabIndex = 9;
            this.cbxModificacionPrestamo.Text = "Prestamo a Modificar";
            this.cbxModificacionPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxModificacionPrestamo_SelectedIndexChanged);
            // 
            // lblIDSalon
            // 
            this.lblIDSalon.AutoSize = true;
            this.lblIDSalon.Location = new System.Drawing.Point(362, 148);
            this.lblIDSalon.Name = "lblIDSalon";
            this.lblIDSalon.Size = new System.Drawing.Size(48, 13);
            this.lblIDSalon.TabIndex = 100;
            this.lblIDSalon.Text = "ID Salon";
            this.lblIDSalon.Visible = false;
            // 
            // txtNombreSalon
            // 
            this.txtNombreSalon.Location = new System.Drawing.Point(365, 103);
            this.txtNombreSalon.Name = "txtNombreSalon";
            this.txtNombreSalon.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSalon.TabIndex = 99;
            this.txtNombreSalon.Visible = false;
            // 
            // lblNombreSalon
            // 
            this.lblNombreSalon.AutoSize = true;
            this.lblNombreSalon.Location = new System.Drawing.Point(362, 88);
            this.lblNombreSalon.Name = "lblNombreSalon";
            this.lblNombreSalon.Size = new System.Drawing.Size(87, 13);
            this.lblNombreSalon.TabIndex = 98;
            this.lblNombreSalon.Text = "Nombre de salon";
            this.lblNombreSalon.Visible = false;
            // 
            // txtIDSalon
            // 
            this.txtIDSalon.Location = new System.Drawing.Point(365, 164);
            this.txtIDSalon.Name = "txtIDSalon";
            this.txtIDSalon.Size = new System.Drawing.Size(100, 20);
            this.txtIDSalon.TabIndex = 97;
            this.txtIDSalon.Visible = false;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(362, 213);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblEjercicio.TabIndex = 96;
            this.lblEjercicio.Text = "Ejercicio";
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(365, 229);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 95;
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(365, 164);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 93;
            // 
            // lblLocacion
            // 
            this.lblLocacion.AutoSize = true;
            this.lblLocacion.Location = new System.Drawing.Point(362, 87);
            this.lblLocacion.Name = "lblLocacion";
            this.lblLocacion.Size = new System.Drawing.Size(51, 13);
            this.lblLocacion.TabIndex = 92;
            this.lblLocacion.Text = "Locacion";
            // 
            // txtLocacion
            // 
            this.txtLocacion.Location = new System.Drawing.Point(365, 103);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 91;
            // 
            // lblEquipoID
            // 
            this.lblEquipoID.AutoSize = true;
            this.lblEquipoID.Location = new System.Drawing.Point(247, 213);
            this.lblEquipoID.Name = "lblEquipoID";
            this.lblEquipoID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipoID.TabIndex = 90;
            this.lblEquipoID.Text = "Equipo(ID)";
            // 
            // txtEquipoID
            // 
            this.txtEquipoID.Location = new System.Drawing.Point(250, 229);
            this.txtEquipoID.Name = "txtEquipoID";
            this.txtEquipoID.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoID.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Profesor responsable";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(247, 163);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 87;
            // 
            // mtxtFechaDevolucion
            // 
            this.mtxtFechaDevolucion.Location = new System.Drawing.Point(12, 229);
            this.mtxtFechaDevolucion.Mask = "00/00/0000";
            this.mtxtFechaDevolucion.Name = "mtxtFechaDevolucion";
            this.mtxtFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaDevolucion.TabIndex = 86;
            this.mtxtFechaDevolucion.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaRetiro
            // 
            this.mtxtFechaRetiro.Location = new System.Drawing.Point(12, 164);
            this.mtxtFechaRetiro.Mask = "00/00/0000";
            this.mtxtFechaRetiro.Name = "mtxtFechaRetiro";
            this.mtxtFechaRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaRetiro.TabIndex = 85;
            this.mtxtFechaRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaSolicitud
            // 
            this.mtxtFechaSolicitud.Location = new System.Drawing.Point(12, 104);
            this.mtxtFechaSolicitud.Mask = "00/00/0000";
            this.mtxtFechaSolicitud.Name = "mtxtFechaSolicitud";
            this.mtxtFechaSolicitud.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaSolicitud.TabIndex = 84;
            this.mtxtFechaSolicitud.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 274);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 13);
            this.lblTipo.TabIndex = 83;
            this.lblTipo.Text = "Estado";
            // 
            // lblAsegurado
            // 
            this.lblAsegurado.AutoSize = true;
            this.lblAsegurado.Location = new System.Drawing.Point(9, 213);
            this.lblAsegurado.Name = "lblAsegurado";
            this.lblAsegurado.Size = new System.Drawing.Size(107, 13);
            this.lblAsegurado.TabIndex = 82;
            this.lblAsegurado.Text = "Fecha de devolucion";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(115, 148);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIgreso.TabIndex = 81;
            this.lblFechaIgreso.Text = "Hora de retiro";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 148);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 13);
            this.lblEstado.TabIndex = 80;
            this.lblEstado.Text = "Fecha de retiro";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(244, 87);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(107, 13);
            this.lblNumeroSerie.TabIndex = 79;
            this.lblNumeroSerie.Text = "Alumno Responsable";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(9, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(93, 13);
            this.Nombre.TabIndex = 78;
            this.Nombre.Text = "Fecha de solicitud";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Devuelto",
            "Cancelado"});
            this.cbxEstado.Location = new System.Drawing.Point(12, 290);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 77;
            this.cbxEstado.Text = "Armado";
            // 
            // mtxtHoraRetiro
            // 
            this.mtxtHoraRetiro.Location = new System.Drawing.Point(118, 164);
            this.mtxtHoraRetiro.Mask = "00:00";
            this.mtxtHoraRetiro.Name = "mtxtHoraRetiro";
            this.mtxtHoraRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraRetiro.TabIndex = 76;
            this.mtxtHoraRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(247, 103);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno.TabIndex = 75;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(12, 53);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamo.TabIndex = 101;
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Location = new System.Drawing.Point(9, 37);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(63, 13);
            this.lblIdPrestamo.TabIndex = 102;
            this.lblIdPrestamo.Text = "Id Prestamo";
            // 
            // frmModificacionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIdPrestamo);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.lblIDSalon);
            this.Controls.Add(this.txtNombreSalon);
            this.Controls.Add(this.lblNombreSalon);
            this.Controls.Add(this.txtIDSalon);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.txtEjercicio);
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
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.cbxModificacionPrestamo);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Name = "frmModificacionPrestamo";
            this.Text = "frmModificacionPrestamo";
            this.Load += new System.EventHandler(this.frmModificacionPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.ComboBox cbxModificacionPrestamo;
        private System.Windows.Forms.Label lblIDSalon;
        private System.Windows.Forms.TextBox txtNombreSalon;
        private System.Windows.Forms.Label lblNombreSalon;
        private System.Windows.Forms.TextBox txtIDSalon;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label lblLocacion;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.Label lblEquipoID;
        private System.Windows.Forms.TextBox txtEquipoID;
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
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label lblIdPrestamo;
    }
}