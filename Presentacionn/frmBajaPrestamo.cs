using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Presentacionn
{
    public partial class frmBajaPrestamo : Form
    {
        public frmBajaPrestamo()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            dPrestamoEquipo unDPE = new dPrestamoEquipo();
            int idPrestamo = unDPE.bajaPrestamoDeEquipo(Convert.ToInt16(txtIdPrestamoBaja.Text));

            if (idPrestamo != 0)
            {

                MessageBox.Show("Se bajo el prestamo correctamente");

            }
            else
            {

                MessageBox.Show("No existe un prestamo con esa id");

            }
        }

        private void cbxPrestamosAEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cbxPrestamosAEliminar.SelectedIndex == 0)
            {

                txtIdPrestamoBaja.Visible = true;
                btnEliminar.Visible = true;

                txtBajaPrestamoEspacio.Visible = false;
                txtBajaPrestamoEspontaneo.Visible = false;
                btnEliminarPrestamoEspacio.Visible = false;
                btnEliminarPrestamoEspontaneo.Visible = false;

                }

            if (cbxPrestamosAEliminar.SelectedIndex == 1)
            {

                txtBajaPrestamoEspacio.Visible = true;
                btnEliminarPrestamoEspacio.Visible = true;

                txtIdPrestamoBaja.Visible = false;
                txtBajaPrestamoEspontaneo.Visible = false;
                btnEliminar.Visible = false;
                btnEliminarPrestamoEspontaneo.Visible = false;

            }

            if (cbxPrestamosAEliminar.SelectedIndex == 2)
            {

                txtBajaPrestamoEspontaneo.Visible = true;
                btnEliminarPrestamoEspontaneo.Visible = true;

                txtBajaPrestamoEspacio.Visible = false;
                txtIdPrestamoBaja.Visible = false;
                btnEliminar.Visible = false;
                btnEliminarPrestamoEspacio.Visible = false;

            }

        }

        private void frmBajaPrestamo_Load(object sender, EventArgs e)
        {

            txtIdPrestamoBaja.Visible = false;
            txtBajaPrestamoEspontaneo.Visible = false;
            txtBajaPrestamoEspacio.Visible = false;
            btnEliminar.Visible = false;
            btnEliminarPrestamoEspacio.Visible = false;
            btnEliminarPrestamoEspontaneo.Visible = false;
            
        }
             */
        }
    }
}
