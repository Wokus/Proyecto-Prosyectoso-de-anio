namespace Presentacionn
{
    partial class frmModificacionEquipo
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
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAsegurado = new System.Windows.Forms.Label();
            this.lblFechaIgreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxMoneda = new System.Windows.Forms.ComboBox();
            this.mtxtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIdEquipoModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEquipo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarEquipo.Location = new System.Drawing.Point(155, 423);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(144, 55);
            this.btnModificarEquipo.TabIndex = 76;
            this.btnModificarEquipo.Text = "Modificar";
            this.btnModificarEquipo.UseVisualStyleBackColor = false;
            this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarEquipo_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.Location = new System.Drawing.Point(100, 204);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 93;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(227, 261);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(72, 13);
            this.lblObservaciones.TabIndex = 92;
            this.lblObservaciones.Text = "Observacioes";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(271, 207);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 91;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(262, 161);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 90;
            this.lblPrecio.Text = "Precio";
            // 
            // lblAsegurado
            // 
            this.lblAsegurado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAsegurado.AutoSize = true;
            this.lblAsegurado.Location = new System.Drawing.Point(241, 111);
            this.lblAsegurado.Name = "lblAsegurado";
            this.lblAsegurado.Size = new System.Drawing.Size(58, 13);
            this.lblAsegurado.TabIndex = 89;
            this.lblAsegurado.Text = "Asegurado";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(8, 261);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIgreso.TabIndex = 88;
            this.lblFechaIgreso.Text = "Fecha de Ingreso";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(54, 211);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 87;
            this.lblEstado.Text = "Estado";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(12, 161);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroSerie.TabIndex = 86;
            this.lblNumeroSerie.Text = "Numero de Serie";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Nombre";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Fotografia",
            "Sonido",
            "Informatica",
            "Otros"});
            this.cbxTipo.Location = new System.Drawing.Point(305, 203);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 84;
            this.cbxTipo.Text = "Fotografia";
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMoneda.FormattingEnabled = true;
            this.cbxMoneda.Location = new System.Drawing.Point(411, 153);
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Size = new System.Drawing.Size(38, 21);
            this.cbxMoneda.TabIndex = 83;
            this.cbxMoneda.Text = "$";
            // 
            // mtxtFechaIngreso
            // 
            this.mtxtFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtFechaIngreso.Location = new System.Drawing.Point(100, 254);
            this.mtxtFechaIngreso.Mask = "00/00/0000";
            this.mtxtFechaIngreso.Name = "mtxtFechaIngreso";
            this.mtxtFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaIngreso.TabIndex = 82;
            this.mtxtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Location = new System.Drawing.Point(305, 254);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(100, 20);
            this.txtObservaciones.TabIndex = 81;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(305, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 80;
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsegurado.Location = new System.Drawing.Point(305, 104);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(100, 20);
            this.txtAsegurado.TabIndex = 79;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroSerie.Location = new System.Drawing.Point(100, 154);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSerie.TabIndex = 78;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(100, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 77;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(100, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 94;
            // 
            // lblIdEquipoModificar
            // 
            this.lblIdEquipoModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdEquipoModificar.AutoSize = true;
            this.lblIdEquipoModificar.Location = new System.Drawing.Point(40, 61);
            this.lblIdEquipoModificar.Name = "lblIdEquipoModificar";
            this.lblIdEquipoModificar.Size = new System.Drawing.Size(52, 13);
            this.lblIdEquipoModificar.TabIndex = 95;
            this.lblIdEquipoModificar.Text = "Id Equipo";
            // 
            // frmModificacionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIdEquipoModificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAsegurado);
            this.Controls.Add(this.lblFechaIgreso);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxMoneda);
            this.Controls.Add(this.mtxtFechaIngreso);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAsegurado);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificarEquipo);
            this.Name = "frmModificacionEquipo";
            this.Text = "frmModificacionEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAsegurado;
        private System.Windows.Forms.Label lblFechaIgreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxMoneda;
        private System.Windows.Forms.MaskedTextBox mtxtFechaIngreso;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAsegurado;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdEquipoModificar;
    }
}