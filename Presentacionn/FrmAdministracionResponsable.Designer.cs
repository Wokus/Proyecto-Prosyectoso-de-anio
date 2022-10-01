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
            this.btnAregar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtResCi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEliminarRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListarUsuario = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModiRes = new System.Windows.Forms.Button();
            this.txtOldCi = new System.Windows.Forms.TextBox();
            this.txtNewCi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxNewTipo = new System.Windows.Forms.ComboBox();
            this.tbcResponsable.SuspendLayout();
            this.alta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.alta.Controls.Add(this.btnAregar);
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
            // btnAregar
            // 
            this.btnAregar.Location = new System.Drawing.Point(118, 401);
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
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtEliminarRes);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar Responsable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEliminarRes
            // 
            this.txtEliminarRes.Location = new System.Drawing.Point(153, 58);
            this.txtEliminarRes.Name = "txtEliminarRes";
            this.txtEliminarRes.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarRes.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cedula del responsable";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvListarUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 463);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listar informacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvListarUsuario
            // 
            this.dgvListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuario.Location = new System.Drawing.Point(24, 102);
            this.dgvListarUsuario.Name = "dgvListarUsuario";
            this.dgvListarUsuario.Size = new System.Drawing.Size(334, 263);
            this.dgvListarUsuario.TabIndex = 12;
            this.dgvListarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarResponsable_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbxNewTipo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtNewCurso);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtNewCi);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtOldCi);
            this.tabPage3.Controls.Add(this.btnModiRes);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 463);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cedula del responsable a modificar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnModiRes
            // 
            this.btnModiRes.Location = new System.Drawing.Point(109, 389);
            this.btnModiRes.Name = "btnModiRes";
            this.btnModiRes.Size = new System.Drawing.Size(147, 41);
            this.btnModiRes.TabIndex = 1;
            this.btnModiRes.Text = "Modificar";
            this.btnModiRes.UseVisualStyleBackColor = true;
            this.btnModiRes.Click += new System.EventHandler(this.btnModiRes_Click);
            // 
            // txtOldCi
            // 
            this.txtOldCi.Location = new System.Drawing.Point(187, 61);
            this.txtOldCi.Name = "txtOldCi";
            this.txtOldCi.Size = new System.Drawing.Size(100, 20);
            this.txtOldCi.TabIndex = 2;
            // 
            // txtNewCi
            // 
            this.txtNewCi.Location = new System.Drawing.Point(187, 87);
            this.txtNewCi.Name = "txtNewCi";
            this.txtNewCi.Size = new System.Drawing.Size(100, 20);
            this.txtNewCi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cedula nueva";
            // 
            // txtNewCurso
            // 
            this.txtNewCurso.Location = new System.Drawing.Point(187, 113);
            this.txtNewCurso.Name = "txtNewCurso";
            this.txtNewCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNewCurso.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Curso";
            // 
            // cbxNewTipo
            // 
            this.cbxNewTipo.FormattingEnabled = true;
            this.cbxNewTipo.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cbxNewTipo.Location = new System.Drawing.Point(187, 139);
            this.cbxNewTipo.Name = "cbxNewTipo";
            this.cbxNewTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxNewTipo.TabIndex = 11;
            // 
            // FrmAdministracionResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 550);
            this.Controls.Add(this.tbcResponsable);
            this.Name = "FrmAdministracionResponsable";
            this.Text = "FrmAdministracionResponsable";
            this.tbcResponsable.ResumeLayout(false);
            this.alta.ResumeLayout(false);
            this.alta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtEliminarRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListarUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewCi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOldCi;
        private System.Windows.Forms.Button btnModiRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxNewTipo;
    }
}