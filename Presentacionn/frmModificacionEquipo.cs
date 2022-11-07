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
    public partial class frmModificacionEquipo : Form
    {
        public frmModificacionEquipo()
        {
            InitializeComponent();
        }

        private bool corroborarCampos() 
        {
            bool token = true;
            if (txtNombre.Text == "" || txtNumeroSerie.Text == "" || cbxAsegurado.SelectedIndex == -1 ||
                cbxMoneda.SelectedIndex == -1 || cbxAsegurado.SelectedIndex == -1 || cbxTipo.SelectedIndex == -1 || txtPrecio.Text == "" || mtxtId.Text == "")
            {
                token = false;
            }
            else if (txtNombre.Text.Length > 50 || txtPrecio.Text.Length > 9 || txtObservaciones.Text.Length > 100)
            {
                MessageBox.Show("Hay campos con mucho texto");
            }
            if (token == false)
            {
                MessageBox.Show("Hay campos vacios");
            }
            return token;
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            bool tokenCampos = corroborarCampos();
            if (tokenCampos == true)
            {
                eEquipo unE = new eEquipo();
            unE.id = Convert.ToInt32(mtxtId.Text);
            unE.nombre = txtNombre.Text;
            unE.numeroSerie = txtNumeroSerie.Text;
            unE.estado = cbxEstado.Text;
            unE.fechaIngreso = dtpFecha.Value.ToString("yyyy-MM-dd");
            unE.asegurado = cbxAsegurado.Text;
            unE.precio = txtPrecio.Text + cbxMoneda.Text;
            unE.tipo = cbxTipo.Text;
            unE.observacion = txtObservaciones.Text;

            dEquipo unDE = new dEquipo();
            try
            {
              bool token =  unDE.modificacionEquipo(unE);
                if (token == true)
                {

                    MessageBox.Show("Equipo modificado con exito");

                }else {MessageBox.Show ("Equipo ingresado no existente"); }

            }catch (Exception error)
            {
                    MessageBox.Show(error.Message); 
            }

            }
        }
    }
}

