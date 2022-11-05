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
            bool tokenCampos = corroborarCampos("alta");
            if (tokenCampos == true)
            {
                try
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
                catch (Exception error) { MessageBox.Show(error.Message); }
            }

        }
        private void btnOkEliminar_Click(object sender, EventArgs e)
        {
            dUsuario unDU = new dUsuario();
            bool tokenCampos = corroborarCampos("baja");
            if (tokenCampos == true)
            {
                try
                {
                    eUsuario elAdmin = unDU.bajaUsuario(mtxtUsernameEliminar.Text);
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
            bool tokenCampos = corroborarCampos("modi");
            if (tokenCampos == true)
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
        public bool corroborarCampos(String accion)
        {
            bool token = false;
            bool tokenMuchoTexto = false;
            if (accion == "alta")
            {
               if(mtxtUsernameAgregar.MaskFull && txtPasswordAgregar.Text != "" && txtNombreAgregar.Text != "" && 
                    txtApellidoAgregar.Text != "" && mtxtTelefonoAgregar.MaskFull)
                {
                    token = true;
                    if (txtPasswordAgregar.Text.Length < 21  && txtNombreAgregar.Text.Length < 26 &&
                    txtApellidoAgregar.Text.Length < 26)
                    {
                        tokenMuchoTexto = true;
                    }
                }
            }
            if (accion == "baja")
            {
                if (mtxtUsernameEliminar.MaskFull)
                {
                    token = true;

                }
            }
            if (accion == "modi")
            {
                if (mtxtUsernameModificar.MaskFull && txtPasswordModificar.Text != "" && txtNombreModificar.Text != "" &&
                txtApellidoModificar.Text != "" && mtxtTelefonoModificar.MaskFull && mtxtNUAM.MaskFull)
                {
                    token = true;
                    if (txtPasswordModificar.Text.Length < 21 && txtNombreModificar.Text.Length < 26 &&
                    txtApellidoModificar.Text.Length < 26)
                    {
                        tokenMuchoTexto = true;
                    }
                }
            }
           if (token != true)
            {
                MessageBox.Show("Hay campos vacios o incompletos");
            }else
            {
               if (tokenMuchoTexto != true)
                {
                    MessageBox.Show("Hay campos con demasiado texto");
                    token = false;
                }
            }
            return token;
        }
    }

   



    }

