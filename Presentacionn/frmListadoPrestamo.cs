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
            try
            {           
            if (cbxTipo.SelectedIndex == 0)
            {

                dPrestamo unDP = new dPrestamo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamo();

            }

            if (cbxTipo.SelectedIndex == 1)
            {

                dPrestamoEquipo unDP = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEquipo();

            }

            if (cbxTipo.SelectedIndex == 3)
            {

                dPrestamoEspacio unDP = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEspacio();

            }

            if (cbxTipo.SelectedIndex == 2)
            {

                dPrestamoExpontaneo unDP = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoEspontaneo();

            }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmListadoPrestamo_Load(object sender, EventArgs e)
        {
            dPrestamo unDP = new dPrestamo();
            dgvListadoEquipo.DataSource = unDP.listarPrestamo();
        }

        private void cbxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFecha.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamo unDPF = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                }

                if (cbxFecha.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamo unDPF = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();
               
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }
        }
        
}
