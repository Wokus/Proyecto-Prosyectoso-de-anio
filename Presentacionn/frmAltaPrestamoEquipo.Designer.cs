namespace Presentacionn
{
    partial class frmAltaPrestamoEquipo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
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
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(264, 178);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 42;
            // 
            // mtxtFechaDevolucion
            // 
            this.mtxtFechaDevolucion.Location = new System.Drawing.Point(29, 244);
            this.mtxtFechaDevolucion.Mask = "00/00/0000";
            this.mtxtFechaDevolucion.Name = "mtxtFechaDevolucion";
            this.mtxtFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaDevolucion.TabIndex = 41;
            this.mtxtFechaDevolucion.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaRetiro
            // 
            this.mtxtFechaRetiro.Location = new System.Drawing.Point(29, 179);
            this.mtxtFechaRetiro.Mask = "00/00/0000";
            this.mtxtFechaRetiro.Name = "mtxtFechaRetiro";
            this.mtxtFechaRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaRetiro.TabIndex = 40;
            this.mtxtFechaRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaSolicitud
            // 
            this.mtxtFechaSolicitud.Location = new System.Drawing.Point(29, 119);
            this.mtxtFechaSolicitud.Mask = "00/00/0000";
            this.mtxtFechaSolicitud.Name = "mtxtFechaSolicitud";
            this.mtxtFechaSolicitud.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaSolicitud.TabIndex = 39;
            this.mtxtFechaSolicitud.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(26, 289);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 13);
            this.lblTipo.TabIndex = 38;
            this.lblTipo.Text = "Estado";
            // 
            // lblAsegurado
            // 
            this.lblAsegurado.AutoSize = true;
            this.lblAsegurado.Location = new System.Drawing.Point(26, 228);
            this.lblAsegurado.Name = "lblAsegurado";
            this.lblAsegurado.Size = new System.Drawing.Size(107, 13);
            this.lblAsegurado.TabIndex = 37;
            this.lblAsegurado.Text = "Fecha de devolucion";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(132, 163);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIgreso.TabIndex = 36;
            this.lblFechaIgreso.Text = "Hora de retiro";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 163);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 13);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Fecha de retiro";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(261, 102);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(107, 13);
            this.lblNumeroSerie.TabIndex = 34;
            this.lblNumeroSerie.Text = "Alumno Responsable";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(26, 103);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(93, 13);
            this.Nombre.TabIndex = 33;
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
            this.cbxEstado.Location = new System.Drawing.Point(29, 305);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.Text = "Armado";
            // 
            // mtxtHoraRetiro
            // 
            this.mtxtHoraRetiro.Location = new System.Drawing.Point(135, 179);
            this.mtxtHoraRetiro.Mask = "00:00";
            this.mtxtHoraRetiro.Name = "mtxtHoraRetiro";
            this.mtxtHoraRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraRetiro.TabIndex = 31;
            this.mtxtHoraRetiro.ValidatingType = typeof(System.DateTime);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Locacion";
            // 
            // txtLocacion
            // 
            this.txtLocacion.Location = new System.Drawing.Point(382, 118);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Equipo(ID)";
            // 
            // txtEquipoID
            // 
            this.txtEquipoID.Location = new System.Drawing.Point(267, 244);
            this.txtEquipoID.Name = "txtEquipoID";
            this.txtEquipoID.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoID.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Transporte";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(382, 179);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ejercicio";
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(382, 244);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 50;
            // 
            // frmAltaPrestamoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocacion);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEjercicio;
    }
}