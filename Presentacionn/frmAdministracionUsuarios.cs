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
    public partial class frmAdministracionUsuarios : Form
    {
        public frmAdministracionUsuarios()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            eUsuario unU = new eUsuario(); 
            unU.username = txtUsernameAgregar.Text; 
            unU.password = txtPasswordAgregar.Text; 
            unU.nombreCompleto = txtNombreCompletoAgregar.Text;
            unU.telefono = mtxtTelefonoAgregar.Text;
            dUsuario unDU = new dUsuario(); 
            eUsuario elAdmin = unDU.altaUsuario(unU);
            if (elAdmin!=null)
            {
                MessageBox.Show("Nombre de Usuario ya existente");
            }else
            {
                MessageBox.Show("Usuario creado EXITAntemente");
            }
        }
        private void btnOkEliminar_Click(object sender, EventArgs e)
        {

            dUsuario unDU = new dUsuario();
            eUsuario elAdmin = unDU.bajaUsuario(txtUsernameEliminar.Text, txtPasswordEliminar.Text);
            if (elAdmin==null)
            {
                MessageBox.Show("Usuario y/o clave incorrecto");

            }else
            {
                MessageBox.Show("Usuario eliminado correctamente");

            }
        }
        private void frmAdministracionUsuarios_Load(object sender, EventArgs e)
        {
            dUsuario unDU = new dUsuario();
            dgvListarUsuario.DataSource = unDU.listarUsuario();
        }


        private void tbcUsuarios_Click(object sender, EventArgs e)
        {
            dUsuario unDU = new dUsuario();
            dgvListarUsuario.DataSource = unDU.listarUsuario();
        }

        private void btnOkModificar_Click(object sender, EventArgs e)
        {
            eUsuario unU = new eUsuario();
            unU.username = txtUsernameModificar.Text;
            unU.password = txtPasswordModificar.Text;
            unU.nombreCompleto = txtNombreCompletoModificar.Text;
            unU.telefono = mtxtTelefonoModificar.Text;
            dUsuario unDU = new dUsuario();
            eUsuario elAdmin = unDU.modificarUsuario(unU, txtNUAM.Text);
            

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

          
           
            /*
            if (elAdmin.username == "1")
            {
                
            }
            */
        }

        private void txtPasswordAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkListar_Click(object sender, EventArgs e)
        {

        }

        private void tbpListarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblNDAM_Click(object sender, EventArgs e)
        {

        }

        private void txtUsernameModificar_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

