namespace Presentacionn
{
    partial class FrmAdministracionResponsable
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
            this.tbcResponsable = new System.Windows.Forms.TabControl();
            this.alta = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtResCi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAregar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tbcResponsable.SuspendLayout();
            this.alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcResponsable
            // 
            this.tbcResponsable.Controls.Add(this.alta);
            this.tbcResponsable.Controls.Add(this.tabPage2);
            this.tbcResponsable.Controls.Add(this.tabPage1);
            this.tbcResponsable.Controls.Add(this.tabPage3);
            this.tbcResponsable.Location = new System.Drawing.Point(1, 0);
            this.tbcResponsable.Name = "tbcResponsable";
            this.tbcResponsable.SelectedIndex = 0;
            this.tbcResponsable.Size = new System.Drawing.Size(399, 489);
            this.tbcResponsable.TabIndex = 0;
            // 
            // alta
            // 
            this.alta.Controls.Add(this.cbxTipo);
            this.alta.Controls.Add(this.label3);
            this.alta.Controls.Add(this.label2);
            this.alta.Controls.Add(this.label1);
            this.alta.Controls.Add(this.txtCurso);
            this.alta.Controls.Add(this.txtResCi);
            this.alta.Location = new System.Drawing.Point(4, 22);
            this.alta.Name = "alta";
            this.alta.Padding = new System.Windows.Forms.Padding(3);
            this.alta.Size = new System.Drawing.Size(391, 463);
            this.alta.TabIndex = 0;
            this.alta.Text = "Agregar";
            this.alta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "cedula del responsable";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(178, 75);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // txtResCi
            // 
            this.txtResCi.Location = new System.Drawing.Point(178, 49);
            this.txtResCi.Name = "txtResCi";
            this.txtResCi.Size = new System.Drawing.Size(100, 20);
            this.txtResCi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 463);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listar informacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 463);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAregar
            // 
            this.btnAregar.Location = new System.Drawing.Point(142, 495);
            this.btnAregar.Name = "btnAregar";
            this.btnAregar.Size = new System.Drawing.Size(131, 43);
            this.btnAregar.TabIndex = 0;
            this.btnAregar.Text = "Agregar";
            this.btnAregar.UseVisualStyleBackColor = true;
            this.btnAregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Estudiantes",
            "Profesor"});
            this.cbxTipo.Location = new System.Drawing.Point(178, 101);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // FrmAdministracionResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 550);
            this.Controls.Add(this.btnAregar);
            this.Controls.Add(this.tbcResponsable);
            this.Name = "FrmAdministracionResponsable";
            this.Text = "FrmAdministracionResponsable";
            this.tbcResponsable.ResumeLayout(false);
            this.alta.ResumeLayout(false);
            this.alta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcResponsable;
        private System.Windows.Forms.TabPage alta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtResCi;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}