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
    public partial class FrmAdministracionResponsable : Form
    {
        public FrmAdministracionResponsable()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            eResponsable unR = new eResponsable();
            unR.ci = txtResCi.Text;
            unR.curso = txtCurso.Text;
            unR.tipo = cbxTipo.Text;
            dResponsable unDR = new dResponsable();
            bool token = unDR.altaResponsable(unR);
            if (token == true)
            {

                MessageBox.Show("el responsable ha sido agregado correctamente ");
            }
            else
            {

                MessageBox.Show("el responsable no ha sido ingresado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dResponsable unDR = new dResponsable();
            eResponsable elAdmin = unDR.bajaResponsable(txtEliminarRes.Text);
            if (elAdmin == null)
            {
                MessageBox.Show("Usuario y/o clave incorrecto");

            }
            else
            {
                MessageBox.Show("Usuario eliminado correctamente");

            }
        }

        private void dgvListarResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModiRes_Click(object sender, EventArgs e)
        {
            eResponsable unR = new eResponsable();
            unR.ci = txtNewCi.Text;
            unR.curso = txtNewCi.Text;
            unR.tipo = cbxNewTipo.Text;
            dResponsable unDR = new dResponsable();
            eResponsable elAdmin = unDR.modificarResponsable(unR,txtOldCi.Text);


            if (elAdmin != null)
            {
                MessageBox.Show("Usuario modificado de manera exitosa");
                //MessageBox.Show("Nuevo Nombre de Usuario ya existente");
            }


            if (elAdmin == null)
            {
                MessageBox.Show("Ocurrio un error en los datos ingresados");
                //MessageBox.Show("Usuario a modificar no existente");
            }

        }
        private void frmAdministracionResponsable_load (object sender, EventArgs e)
        {
            dResponsable unDR = new dResponsable();
            dgvListarUsuario.DataSource = unDR.ListarResponsable();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void alta_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
  }
