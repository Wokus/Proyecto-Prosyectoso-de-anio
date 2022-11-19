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

        string tipo;
        string estado;

        private void frmListadoEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipo();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
            
        }
                
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Todos los equipos Video Sonido Informatica Otros
            if (cbxTipo.Text == "Todos los equipos")
            {

                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipo();   

            }

            if (cbxTipo.Text != "Todos los equipos")
            {
                tipo = cbxTipo.Text;
                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipoT(tipo);
            }

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstado.Text == "Todos los estados")
            {

                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipo();

            }

            if (cbxEstado.Text != "Todos los estados")
            {

                estado = cbxEstado.Text;
                dEquipo unDE = new dEquipo();
                dgvEquipo.DataSource = unDE.listarEquipoE(estado);

            }

        }
    }
}
