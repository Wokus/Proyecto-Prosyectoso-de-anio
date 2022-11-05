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
            eUsuario elAdmin = null;
            eUsuario unU = new eUsuario(); 
            unU.ci = mtxtUsernameAgregar.Text; 
            unU.password = txtPasswordAgregar.Text; 
            unU.nombre = txtNombreAgregar.Text;
            unU.apellido = txtApellidoAgregar.Text;
            unU.telefono = mtxtTelefonoAgregar.Text;
            dUsuario unDU = new dUsuario(); 
           elAdmin = unDU.altaUsuario(unU);
                if (elAdmin != null)
                {
                    MessageBox.Show("Nombre de Usuario ya existente");
                }
                else
                {
                    MessageBox.Show("Usuario creado exitosamente");
                }
            
           
            
        }
        private void btnOkEliminar_Click(object sender, EventArgs e)
        {
            dUsuario unDU = new dUsuario();
            try
            {
                eUsuario elAdmin = unDU.bajaUsuario(txtUsernameEliminar.Text);
                if (elAdmin == null)
                {
                    MessageBox.Show("Usuario y/o clave incorrecto");

                }
                else
                {
                    MessageBox.Show("Usuario eliminado correctamente");

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
         
        }
        private void tbcUsuarios_Click(object sender, EventArgs e)
        {
            dUsuario unDU = new dUsuario();
            try
            {
            dgvListarUsuario.DataSource = unDU.listarUsuario();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }
        private void btnOkModificar_Click(object sender, EventArgs e)
        {
            eUsuario unU = new eUsuario();
            unU.ci = mtxtUsernameModificar.Text;
            unU.password = txtPasswordModificar.Text;
            unU.nombre = txtNombreModificar.Text;
            unU.apellido = txtApellidoModificar.Text;
            unU.telefono = mtxtTelefonoModificar.Text;
            dUsuario unDU = new dUsuario();
            try
            {
                eUsuario elAdmin = unDU.modificarUsuario(unU, mtxtNUAM.Text);
                if (elAdmin != null)
                {
                    MessageBox.Show("Usuario modificado de manera exitosa");
                }
                if (elAdmin == null)
                {
                    MessageBox.Show("Ocurrio un error en los datos ingresados");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

