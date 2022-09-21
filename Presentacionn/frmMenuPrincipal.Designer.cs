namespace Presentacionn
{
    partial class frmMenuPrincipal
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenuUsuarios = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.cbxListados = new System.Windows.Forms.ComboBox();
            this.cbxAcciones = new System.Windows.Forms.ComboBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.sc1 = new System.Windows.Forms.SplitContainer();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            this.sc1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(156)))), ((int)(((byte)(200)))));
            this.pnl1.Controls.Add(this.button1);
            this.pnl1.Controls.Add(this.btnMenuUsuarios);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1020, 57);
            this.pnl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(156)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(129)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentacionn.Properties.Resources.ArrayanesLogo;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 48);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMenuUsuarios
            // 
            this.btnMenuUsuarios.Location = new System.Drawing.Point(907, 12);
            this.btnMenuUsuarios.Name = "btnMenuUsuarios";
            this.btnMenuUsuarios.Size = new System.Drawing.Size(101, 39);
            this.btnMenuUsuarios.TabIndex = 2;
            this.btnMenuUsuarios.Text = "Usuarios";
            this.btnMenuUsuarios.UseVisualStyleBackColor = true;
            this.btnMenuUsuarios.Click += new System.EventHandler(this.btnMenuUsuarios_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl2.Controls.Add(this.cbxListados);
            this.pnl2.Controls.Add(this.cbxAcciones);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 57);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1020, 50);
            this.pnl2.TabIndex = 1;
            this.pnl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbxListados
            // 
            this.cbxListados.FormattingEnabled = true;
            this.cbxListados.Items.AddRange(new object[] {
            "Inventario",
            "Prestamos"});
            this.cbxListados.Location = new System.Drawing.Point(887, 23);
            this.cbxListados.Name = "cbxListados";
            this.cbxListados.Size = new System.Drawing.Size(121, 21);
            this.cbxListados.TabIndex = 4;
            this.cbxListados.Text = "Listado";
            this.cbxListados.SelectedIndexChanged += new System.EventHandler(this.cbxListados_SelectedIndexChanged);
            // 
            // cbxAcciones
            // 
            this.cbxAcciones.FormattingEnabled = true;
            this.cbxAcciones.Items.AddRange(new object[] {
            "Agregar Equipo",
            "Eliminar Equipo",
            "Modificar Equipo",
            "Agregar Prestamo",
            "Eliminar Prestamo",
            "Modificar Prestamo"});
            this.cbxAcciones.Location = new System.Drawing.Point(12, 23);
            this.cbxAcciones.Name = "cbxAcciones";
            this.cbxAcciones.Size = new System.Drawing.Size(121, 21);
            this.cbxAcciones.TabIndex = 3;
            this.cbxAcciones.Text = "Acciones";
            this.cbxAcciones.SelectedIndexChanged += new System.EventHandler(this.cbxAcciones_SelectedIndexChanged);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3.Location = new System.Drawing.Point(0, 603);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1020, 51);
            this.pnl3.TabIndex = 2;
            // 
            // sc1
            // 
            this.sc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc1.Location = new System.Drawing.Point(0, 107);
            this.sc1.Name = "sc1";
            // 
            // sc1.Panel1
            // 
            this.sc1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sc1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sc1_Panel1_Paint);
            // 
            // sc1.Panel2
            // 
            this.sc1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sc1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.sc1_Panel2_Paint);
            this.sc1.Size = new System.Drawing.Size(1020, 496);
            this.sc1.SplitterDistance = 518;
            this.sc1.TabIndex = 3;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 654);
            this.Controls.Add(this.sc1);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.pnl1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnMenuUsuarios;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ComboBox cbxListados;
        private System.Windows.Forms.ComboBox cbxAcciones;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.SplitContainer sc1;
        private System.Windows.Forms.Button button1;
    }
}