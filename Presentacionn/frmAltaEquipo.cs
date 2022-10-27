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
            unE.estado = txtEstado.Text;
            unE.fechaIngreso = dtpFecha.Value.ToString("yyyy-MM-dd");
            unE.asegurado = cbxAsegurado.Text;
            unE.precio = txtPrecio.Text + cbxMoneda.Text;
            unE.tipo = cbxTipo.Text;
            unE.observacion = txtObservaciones.Text;

            dEquipo unDE = new dEquipo();
            try
            {
            bool productoCreado = unDE.altaEquipo(unE);
            if (productoCreado == true)
            {
                MessageBox.Show("Equipo agregado de manera exitosa");
            }else { MessageBox.Show("Numero de serie repetido"); }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

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

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
