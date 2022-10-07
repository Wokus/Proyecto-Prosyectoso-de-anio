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
    public partial class frmListadoPrestamo : Form
    {
        public frmListadoPrestamo()
        {
            InitializeComponent();
        }

        private void cbxListadosPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxListadosPrestamos.SelectedIndex == 0)
            {

                dPrestamo unDP = new dPrestamo();
                dataGridView1.DataSource = unDP.listarPrestamo();

            }

            if (cbxListadosPrestamos.SelectedIndex == 1)
            {

                dPrestamoEquipo unDP = new dPrestamoEquipo();
                dataGridView1.DataSource = unDP.listarPrestamoDeEquipo();

            }

            if (cbxListadosPrestamos.SelectedIndex == 3)
            {

                dPrestamoEspacio unDP = new dPrestamoEspacio();
                dataGridView1.DataSource = unDP.listarPrestamoDeEspacio();

            }

            if (cbxListadosPrestamos.SelectedIndex == 2)
            {

                dPrestamoExpontaneo unDP = new dPrestamoExpontaneo();
                dataGridView1.DataSource = unDP.listarPrestamoEspontaneo();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
