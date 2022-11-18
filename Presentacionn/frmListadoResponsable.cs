using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidades;

namespace Presentacionn
{
    public partial class frmListadoResponsable : Form
    {
        public frmListadoResponsable()
        {
            InitializeComponent();
        }
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (cbxTipo.SelectedIndex == 0)
                {
                    dResponsable unDR = new dResponsable();
                    dgvResponsable.DataSource = unDR.ListarResponsable();
                }
            if (cbxTipo.SelectedIndex == 1)
                {
                    dResponsable unDR = new dResponsable();
                    dgvResponsable.DataSource = unDR.ListarResponsabletipoP();
                }
            if (cbxTipo.SelectedIndex == 2)
                {
                    dResponsable unDR = new dResponsable();
                    dgvResponsable.DataSource = unDR.ListarResponsabletipoA();

                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void chbRotura_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbAtrasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmListadoResponsable_Load_1(object sender, EventArgs e)
        {

            dResponsable unDR = new dResponsable();
            dgvResponsable.DataSource = unDR.ListarResponsable();

        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCurso.SelectedIndex == 0)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableCP();

            }
            if (cbxCurso.SelectedIndex == 1)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableCS();

            }
            if (cbxCurso.SelectedIndex == 2)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableCT();
            }
            if (cbxCurso.SelectedIndex == 3)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableFT();
            }
            if (cbxCurso.SelectedIndex == 4)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableTT();
            }
            if (cbxCurso.SelectedIndex == 5)
            {
                dResponsable unDR = new dResponsable();
                dgvResponsable.DataSource = unDR.ListarResponsableTTT();
            }

        }
    }
}
