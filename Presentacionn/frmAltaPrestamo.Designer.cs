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
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.lblFechaIgreso = new System.Windows.Forms.Label();
            this.lblFechaRe = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblFechaSoli = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.mtxtHoraRetiro = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.lblEquipoID = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.cbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblIDSalon = new System.Windows.Forms.Label();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.lblLocacion = new System.Windows.Forms.Label();
            this.mtxtIDSalon = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProfesor = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAlumno = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.dtptFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.cbxEjercicioPEquip = new System.Windows.Forms.ComboBox();
            this.txtEquiposId = new System.Windows.Forms.TextBox();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfesor
            // 
            this.lblProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(262, 163);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(106, 13);
            this.lblProfesor.TabIndex = 43;
            this.lblProfesor.Text = "Profesor responsable";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 289);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Location = new System.Drawing.Point(26, 228);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDev.TabIndex = 37;
            this.lblFechaDev.Text = "Fecha de devolucion";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(132, 163);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIgreso.TabIndex = 36;
            this.lblFechaIgreso.Text = "Hora de retiro";
            // 
            // lblFechaRe
            // 
            this.lblFechaRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaRe.AutoSize = true;
            this.lblFechaRe.Location = new System.Drawing.Point(26, 163);
            this.lblFechaRe.Name = "lblFechaRe";
            this.lblFechaRe.Size = new System.Drawing.Size(78, 13);
            this.lblFechaRe.TabIndex = 35;
            this.lblFechaRe.Text = "Fecha de retiro";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(262, 103);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(107, 13);
            this.lblResponsable.TabIndex = 34;
            this.lblResponsable.Text = "Alumno Responsable";
            // 
            // lblFechaSoli
            // 
            this.lblFechaSoli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaSoli.AutoSize = true;
            this.lblFechaSoli.Location = new System.Drawing.Point(26, 103);
            this.lblFechaSoli.Name = "lblFechaSoli";
            this.lblFechaSoli.Size = new System.Drawing.Size(93, 13);
            this.lblFechaSoli.TabIndex = 33;
            this.lblFechaSoli.Text = "Fecha de solicitud";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Devuelto",
            "Cancelado",
            "En progreso"});
            this.cbxEstado.Location = new System.Drawing.Point(29, 305);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 32;
            // 
            // mtxtHoraRetiro
            // 
            this.mtxtHoraRetiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtHoraRetiro.Location = new System.Drawing.Point(135, 179);
            this.mtxtHoraRetiro.Mask = "00:00";
            this.mtxtHoraRetiro.Name = "mtxtHoraRetiro";
            this.mtxtHoraRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraRetiro.TabIndex = 31;
            this.mtxtHoraRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(170, 423);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(144, 55);
            this.btnAgregarPrestamo.TabIndex = 30;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // lblEquipoID
            // 
            this.lblEquipoID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEquipoID.AutoSize = true;
            this.lblEquipoID.Location = new System.Drawing.Point(262, 228);
            this.lblEquipoID.Name = "lblEquipoID";
            this.lblEquipoID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipoID.TabIndex = 45;
            this.lblEquipoID.Text = "Equipo(ID)";
            // 
            // lblTransporte
            // 
            this.lblTransporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(379, 163);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(58, 13);
            this.lblTransporte.TabIndex = 49;
            this.lblTransporte.Text = "Transporte";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransporte.Location = new System.Drawing.Point(382, 179);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 48;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(379, 228);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblEjercicio.TabIndex = 51;
            this.lblEjercicio.Text = "Ejercicio";
            // 
            // cbxTipoPrestamo
            // 
            this.cbxTipoPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPrestamo.FormattingEnabled = true;
            this.cbxTipoPrestamo.Items.AddRange(new object[] {
            "De equipo(Formales)",
            "De espacio",
            "Espontaneo"});
            this.cbxTipoPrestamo.Location = new System.Drawing.Point(361, 28);
            this.cbxTipoPrestamo.Name = "cbxTipoPrestamo";
            this.cbxTipoPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoPrestamo.TabIndex = 52;
            this.cbxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPrestamo_SelectedIndexChanged);
            // 
            // lblIDSalon
            // 
            this.lblIDSalon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDSalon.AutoSize = true;
            this.lblIDSalon.Location = new System.Drawing.Point(379, 163);
            this.lblIDSalon.Name = "lblIDSalon";
            this.lblIDSalon.Size = new System.Drawing.Size(48, 13);
            this.lblIDSalon.TabIndex = 74;
            this.lblIDSalon.Text = "ID Salon";
            this.lblIDSalon.Visible = false;
            // 
            // txtLocacion
            // 
            this.txtLocacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocacion.Location = new System.Drawing.Point(382, 119);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 46;
            // 
            // lblLocacion
            // 
            this.lblLocacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocacion.AutoSize = true;
            this.lblLocacion.Location = new System.Drawing.Point(379, 103);
            this.lblLocacion.Name = "lblLocacion";
            this.lblLocacion.Size = new System.Drawing.Size(51, 13);
            this.lblLocacion.TabIndex = 47;
            this.lblLocacion.Text = "Locacion";
            // 
            // mtxtIDSalon
            // 
            this.mtxtIDSalon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtIDSalon.HidePromptOnLeave = true;
            this.mtxtIDSalon.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtIDSalon.Location = new System.Drawing.Point(382, 179);
            this.mtxtIDSalon.Mask = "99999";
            this.mtxtIDSalon.Name = "mtxtIDSalon";
            this.mtxtIDSalon.Size = new System.Drawing.Size(100, 20);
            this.mtxtIDSalon.TabIndex = 76;
            this.mtxtIDSalon.Visible = false;
            // 
            // mtxtProfesor
            // 
            this.mtxtProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtProfesor.Location = new System.Drawing.Point(265, 179);
            this.mtxtProfesor.Mask = "9,999,999-9";
            this.mtxtProfesor.Name = "mtxtProfesor";
            this.mtxtProfesor.Size = new System.Drawing.Size(100, 20);
            this.mtxtProfesor.TabIndex = 78;
            // 
            // mtxtAlumno
            // 
            this.mtxtAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtAlumno.Location = new System.Drawing.Point(265, 119);
            this.mtxtAlumno.Mask = "9,999,999-9";
            this.mtxtAlumno.Name = "mtxtAlumno";
            this.mtxtAlumno.Size = new System.Drawing.Size(100, 20);
            this.mtxtAlumno.TabIndex = 79;
            this.mtxtAlumno.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(29, 119);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaSolicitud.TabIndex = 80;
            // 
            // dtptFechaRetiro
            // 
            this.dtptFechaRetiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtptFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptFechaRetiro.Location = new System.Drawing.Point(29, 179);
            this.dtptFechaRetiro.Name = "dtptFechaRetiro";
            this.dtptFechaRetiro.Size = new System.Drawing.Size(100, 20);
            this.dtptFechaRetiro.TabIndex = 81;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(29, 244);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDevolucion.TabIndex = 82;
            // 
            // cbxEjercicioPEquip
            // 
            this.cbxEjercicioPEquip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEjercicioPEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEjercicioPEquip.FormattingEnabled = true;
            this.cbxEjercicioPEquip.Items.AddRange(new object[] {
            "Rodaje",
            "Practica de Rodaje"});
            this.cbxEjercicioPEquip.Location = new System.Drawing.Point(382, 244);
            this.cbxEjercicioPEquip.Name = "cbxEjercicioPEquip";
            this.cbxEjercicioPEquip.Size = new System.Drawing.Size(100, 21);
            this.cbxEjercicioPEquip.TabIndex = 84;
            // 
            // txtEquiposId
            // 
            this.txtEquiposId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEquiposId.Location = new System.Drawing.Point(265, 244);
            this.txtEquiposId.Name = "txtEquiposId";
            this.txtEquiposId.Size = new System.Drawing.Size(100, 20);
            this.txtEquiposId.TabIndex = 83;
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEjercicio.Location = new System.Drawing.Point(382, 244);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 85;
            this.txtEjercicio.Visible = false;
            // 
            // frmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.cbxEjercicioPEquip);
            this.Controls.Add(this.txtEquiposId);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.dtptFechaRetiro);
            this.Controls.Add(this.dtpFechaSolicitud);
            this.Controls.Add(this.mtxtAlumno);
            this.Controls.Add(this.mtxtProfesor);
            this.Controls.Add(this.mtxtIDSalon);
            this.Controls.Add(this.lblIDSalon);
            this.Controls.Add(this.cbxTipoPrestamo);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.lblLocacion);
            this.Controls.Add(this.txtLocacion);
            this.Controls.Add(this.lblEquipoID);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaDev);
            this.Controls.Add(this.lblFechaIgreso);
            this.Controls.Add(this.lblFechaRe);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblFechaSoli);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.mtxtHoraRetiro);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Name = "frmAltaPrestamo";
            this.Text = "frmAltaPrestamo";
            this.Load += new System.EventHandler(this.frmAltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.Label lblFechaIgreso;
        private System.Windows.Forms.Label lblFechaRe;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblFechaSoli;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mtxtHoraRetiro;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Label lblEquipoID;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.ComboBox cbxTipoPrestamo;
        private System.Windows.Forms.Label lblIDSalon;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.Label lblLocacion;
        private System.Windows.Forms.MaskedTextBox mtxtIDSalon;
        private System.Windows.Forms.MaskedTextBox mtxtProfesor;
        private System.Windows.Forms.MaskedTextBox mtxtAlumno;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.DateTimePicker dtptFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.ComboBox cbxEjercicioPEquip;
        private System.Windows.Forms.TextBox txtEquiposId;
        private System.Windows.Forms.TextBox txtEjercicio;
    }
}