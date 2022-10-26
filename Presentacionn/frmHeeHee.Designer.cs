namespace Presentacionn
{
    partial class frmHeeHee
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblProgramadores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEncargado2 = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Agency FB", 28F);
            this.lblCreditos.Location = new System.Drawing.Point(177, 30);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(113, 46);
            this.lblCreditos.TabIndex = 0;
            this.lblCreditos.Text = "Creditos";
            this.lblCreditos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProgramadores
            // 
            this.lblProgramadores.AutoSize = true;
            this.lblProgramadores.Font = new System.Drawing.Font("Alef", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramadores.Location = new System.Drawing.Point(12, 172);
            this.lblProgramadores.Name = "lblProgramadores";
            this.lblProgramadores.Size = new System.Drawing.Size(180, 31);
            this.lblProgramadores.TabIndex = 1;
            this.lblProgramadores.Text = "Programadores:";
            this.lblProgramadores.Click += new System.EventHandler(this.lblProgramadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mr.Doctor Q, La Cosa";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "y El Sol";
            // 
            // lblEncargado2
            // 
            this.lblEncargado2.AutoSize = true;
            this.lblEncargado2.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado2.Location = new System.Drawing.Point(148, 115);
            this.lblEncargado2.Name = "lblEncargado2";
            this.lblEncargado2.Size = new System.Drawing.Size(93, 20);
            this.lblEncargado2.TabIndex = 5;
            this.lblEncargado2.Text = "Mr.Doctor Q";
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Font = new System.Drawing.Font("Alef", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.Location = new System.Drawing.Point(12, 107);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(130, 31);
            this.lblEncargado.TabIndex = 4;
            this.lblEncargado.Text = "Encargado:";
            // 
            // frmHeeHee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 539);
            this.Controls.Add(this.lblEncargado2);
            this.Controls.Add(this.lblEncargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProgramadores);
            this.Controls.Add(this.lblCreditos);
            this.Name = "frmHeeHee";
            this.Text = "frmHeeHee";
            this.Load += new System.EventHandler(this.frmHeeHee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblProgramadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncargado2;
        private System.Windows.Forms.Label lblEncargado;
    }
}