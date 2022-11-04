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

        string tuHermana;

        private void cbxListadosPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {           
            if (cbxTipo.SelectedIndex == 0)
            {

                dPrestamo unDP = new dPrestamo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamo();

            cbxFecha.Visible = true;
            cbxFechaEquipo.Visible = false;
            cbxFechaEspacio.Visible = false;
            cbxFechaEspontaneo.Visible = false;

            cbxEstado.Visible = true;
            cbxEstadoEquipo.Visible = false;
            cbxEstadoEspacio.Visible = false;
            cbxEstadoEspontaneo.Visible = false;

            }

            if (cbxTipo.SelectedIndex == 1)
            {

                dPrestamoEquipo unDP = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEquipo();

                cbxFecha.Visible = false;
                cbxFechaEquipo.Visible = true;
                cbxFechaEspacio.Visible = false;
                cbxFechaEspontaneo.Visible = false;

                cbxEstado.Visible = false;
                cbxEstadoEquipo.Visible = true;
                cbxEstadoEspacio.Visible = false;
                cbxEstadoEspontaneo.Visible = false;

                }

            if (cbxTipo.SelectedIndex == 3)
            {

                dPrestamoEspacio unDP = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEspacio();

                cbxFecha.Visible = false;
                cbxFechaEquipo.Visible = false;
                cbxFechaEspacio.Visible = true;
                cbxFechaEspontaneo.Visible = false;

                cbxEstado.Visible = false;
                cbxEstadoEquipo.Visible = false;
                cbxEstadoEspacio.Visible = true;
                cbxEstadoEspontaneo.Visible = false;

                }

            if (cbxTipo.SelectedIndex == 2)
            {

                dPrestamoExpontaneo unDP = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDP.listarPrestamoEspontaneo();

                cbxFecha.Visible = false;
                cbxFechaEquipo.Visible = false;
                cbxFechaEspacio.Visible = false;
                cbxFechaEspontaneo.Visible = true;

                cbxEstado.Visible = false;
                cbxEstadoEquipo.Visible = false;
                cbxEstadoEspacio.Visible = false;
                cbxEstadoEspontaneo.Visible = true;

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

            cbxFecha.Visible = true;
            cbxFechaEquipo.Visible = false;
            cbxFechaEspacio.Visible = false;
            cbxFechaEspontaneo.Visible = false;

            cbxEstado.Visible = true;
            cbxEstadoEquipo.Visible = false;
            cbxEstadoEspacio.Visible = false;
            cbxEstadoEspontaneo.Visible = false;

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

        private void cbxFechaEspontaneo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxFechaEspontaneo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoExpontaneo unDPF = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                }

                if (cbxFechaEspontaneo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoExpontaneo unDPF = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }

        }

        private void cbxFechaEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxFechaEspontaneo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEspacio unDPF = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                }

                if (cbxFechaEspontaneo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEspacio unDPF = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }

        }

        private void cbxFechaEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxFechaEspontaneo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEquipo unDPF = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                }

                if (cbxFechaEspontaneo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEquipo unDPF = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }

        }

        /*Armado
        Levantado
        Cancelado
        Devuelto
        En progreso*/
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxEstado.SelectedIndex == 0)
                {

                    tuHermana=cbxEstado.Text;

                    dPrestamo unDPE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

                }
                if (cbxEstado.SelectedIndex == 1)
                {

                    tuHermana = cbxEstado.Text;

                    dPrestamo unDPE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

                }
                if (cbxEstado.SelectedIndex == 2)
                {

                    tuHermana = cbxEstado.Text;

                    dPrestamo unDPE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

                }
                if (cbxEstado.SelectedIndex == 3)
                {

                    tuHermana = cbxEstado.Text;

                    dPrestamo unDPE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

                }
                if (cbxEstado.SelectedIndex == 4)
                {

                    tuHermana = cbxEstado.Text;

                    dPrestamo unDPE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxEstadoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstadoEquipo.SelectedIndex == 0)
            {

                tuHermana = cbxEstadoEquipo.Text;

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEquipo.SelectedIndex == 1)
            {

                tuHermana = cbxEstadoEquipo.Text;

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEquipo.SelectedIndex == 2)
            {

                tuHermana = cbxEstadoEquipo.Text;

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEquipo.SelectedIndex == 3)
            {

                tuHermana = cbxEstadoEquipo.Text;

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEquipo.SelectedIndex == 4)
            {

                tuHermana = cbxEstadoEquipo.Text;

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }

        }

        private void cbxEstadoEspontaneo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstadoEspontaneo.SelectedIndex == 0)
            {

                tuHermana = cbxEstadoEspontaneo.Text;

                dPrestamoExpontaneo unDPE = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspontaneo.SelectedIndex == 1)
            {

                tuHermana = cbxEstadoEspontaneo.Text;

                dPrestamoExpontaneo unDPE = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspontaneo.SelectedIndex == 2)
            {

                tuHermana = cbxEstadoEspontaneo.Text;

                dPrestamoExpontaneo unDPE = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspontaneo.SelectedIndex == 3)
            {

                tuHermana = cbxEstadoEspontaneo.Text;

                dPrestamoExpontaneo unDPE = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspontaneo.SelectedIndex == 4)
            {

                tuHermana = cbxEstadoEspontaneo.Text;

                dPrestamoExpontaneo unDPE = new dPrestamoExpontaneo();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }

        }

        private void cbxEstadoEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstadoEspacio.SelectedIndex == 0)
            {

                tuHermana = cbxEstadoEspacio.Text;

                dPrestamoEspacio unDPE = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspacio.SelectedIndex == 1)
            {

                tuHermana = cbxEstadoEspacio.Text;

                dPrestamoEspacio unDPE = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspacio.SelectedIndex == 2)
            {

                tuHermana = cbxEstadoEspacio.Text;

                dPrestamoEspacio unDPE = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspacio.SelectedIndex == 3)
            {

                tuHermana = cbxEstadoEspacio.Text;

                dPrestamoEspacio unDPE = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }
            if (cbxEstadoEspacio.SelectedIndex == 4)
            {

                tuHermana = cbxEstadoEspacio.Text;

                dPrestamoEspacio unDPE = new dPrestamoEspacio();
                dgvListadoEquipo.DataSource = unDPE.listarPrestamoPorEstado(tuHermana);

            }

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        
}
