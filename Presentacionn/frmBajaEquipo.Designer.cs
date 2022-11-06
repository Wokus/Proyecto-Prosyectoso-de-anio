namespace Presentacionn
{
    partial class frmBajaEquipo
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
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEquipo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(170, 423);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(144, 55);
            this.btnEliminarEquipo.TabIndex = 0;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.UseVisualStyleBackColor = false;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(194, 143);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Location = new System.Drawing.Point(118, 146);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(70, 13);
            this.lblIdEquipo.TabIndex = 2;
            this.lblIdEquipo.Text = "ID del equipo";
            // 
            // frmBajaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIdEquipo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Name = "frmBajaEquipo";
            this.Text = "frmBajaEquipo";
            this.Load += new System.EventHandler(this.frmBajaEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdEquipo;
    }
}