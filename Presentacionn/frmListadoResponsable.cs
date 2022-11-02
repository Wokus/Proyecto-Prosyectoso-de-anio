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
        private void frmListadoResponsable_Load (object sener, EventArgs e)
        {
            try
            {
            dResponsable unDR = new dResponsable();
            dgvResponsable.DataSource = unDR.ListarResponsable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
                dgvResponsable.DataSource = unDR.ListarResponsable();
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
    }
}
