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
    public partial class frmListadoEquipo : Form
    {
        public frmListadoEquipo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void frmListadoEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipo();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
            
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
