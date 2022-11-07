namespace Presentacionn
{
    partial class frmBajaRotura
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
            this.cbxRotura = new System.Windows.Forms.ComboBox();
            this.btnEliminarRotura = new System.Windows.Forms.Button();
            this.lblRotura = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.txtEquipoRoto = new System.Windows.Forms.TextBox();
            this.lblEquipoRoto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxRotura
            // 
            this.cbxRotura.FormattingEnabled = true;
            this.cbxRotura.Location = new System.Drawing.Point(274, 60);
            this.cbxRotura.Name = "cbxRotura";
            this.cbxRotura.Size = new System.Drawing.Size(121, 21);
            this.cbxRotura.TabIndex = 9;
            // 
            // btnEliminarRotura
            // 
            this.btnEliminarRotura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRotura.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarRotura.Location = new System.Drawing.Point(170, 423);
            this.btnEliminarRotura.Name = "btnEliminarRotura";
            this.btnEliminarRotura.Size = new System.Drawing.Size(144, 55);
            this.btnEliminarRotura.TabIndex = 11;
            this.btnEliminarRotura.Text = "Eliminar";
            this.btnEliminarRotura.UseVisualStyleBackColor = false;
            this.btnEliminarRotura.Click += new System.EventHandler(this.btnEliminarRotura_Click);
            // 
            // lblRotura
            // 
            this.lblRotura.AutoSize = true;
            this.lblRotura.Location = new System.Drawing.Point(217, 63);
            this.lblRotura.Name = "lblRotura";
            this.lblRotura.Size = new System.Drawing.Size(53, 13);
            this.lblRotura.TabIndex = 12;
            this.lblRotura.Text = "ID Rotura";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(205, 127);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Location = new System.Drawing.Point(24, 63);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(54, 13);
            this.lblIdEquipo.TabIndex = 7;
            this.lblIdEquipo.Text = "ID Equipo";
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.Location = new System.Drawing.Point(82, 60);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtIdEquipo.TabIndex = 8;
            this.txtIdEquipo.TextChanged += new System.EventHandler(this.txtIdEquipo_TextChanged);
            // 
            // txtEquipoRoto
            // 
            this.txtEquipoRoto.Location = new System.Drawing.Point(82, 124);
            this.txtEquipoRoto.Name = "txtEquipoRoto";
            this.txtEquipoRoto.Size = new System.Drawing.Size(100, 20);
            this.txtEquipoRoto.TabIndex = 15;
            // 
            // lblEquipoRoto
            // 
            this.lblEquipoRoto.AutoSize = true;
            this.lblEquipoRoto.Location = new System.Drawing.Point(10, 127);
            this.lblEquipoRoto.Name = "lblEquipoRoto";
            this.lblEquipoRoto.Size = new System.Drawing.Size(66, 13);
            this.lblEquipoRoto.TabIndex = 14;
            this.lblEquipoRoto.Text = "Equipo Roto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 90);
            this.textBox1.TabIndex = 16;
            // 
            // frmBajaRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEquipoRoto);
            this.Controls.Add(this.lblEquipoRoto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRotura);
            this.Controls.Add(this.btnEliminarRotura);
            this.Controls.Add(this.cbxRotura);
            this.Controls.Add(this.txtIdEquipo);
            this.Controls.Add(this.lblIdEquipo);
            this.Name = "frmBajaRotura";
            this.Text = "frmBajaRotura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxRotura;
        private System.Windows.Forms.Button btnEliminarRotura;
        private System.Windows.Forms.Label lblRotura;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.TextBox txtEquipoRoto;
        private System.Windows.Forms.Label lblEquipoRoto;
        private System.Windows.Forms.TextBox textBox1;
    }
}