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
    public partial class frmAltaEquipo : Form
    {
        public frmAltaEquipo()
        {
            InitializeComponent();
        }

        private void frmAgregarEquipo_Load(object sender, EventArgs e)
        {

        }



        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            bool pija = true;
            
            eEquipo unE = new eEquipo();
            unE.nombre = txtNombre.Text;
            unE.numeroSerie = txtNumeroSerie.Text;
            unE.estado = cbxEstado.Text;
            unE.fechaIngreso = mtxtFechaIngreso.Text;
            unE.asegurado = txtAsegurado.Text;
            unE.precio = txtPrecio.Text + cbxMoneda.Text;
            //unE.tipo = cbxTipo.Text;
            unE.observacion = txtObservaciones.Text;

            dEquipo unDE = new dEquipo();
            unDE.altaEquipo(unE);

            MessageBox.Show("Equipo agregado de manera exitosa");

        }

        private void txtAsegurado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
