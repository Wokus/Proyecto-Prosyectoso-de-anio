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
    public partial class frmModificacionEspacio : Form
    {
        public frmModificacionEspacio()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (txtNombre.Text != "" && txtNombre.Text.Length < 16 && mtxtNumero.Text != "" && mtxtNumeroCam.Text != "")
            {

                eEspacio unE = new eEspacio();
                unE.nombreEspacio = txtNombre.Text;
                unE.numeroEspacio = mtxtNumero.Text;

                dEspacio unDE = new dEspacio();
                int token = unDE.modificarEspacio(unE,mtxtNumeroCam.Text);

                if (token == 0)
                {

                    MessageBox.Show("Se modificó el espacio");

                }
                else if (token == 1)
                {

                    MessageBox.Show("Espacio a modificar no existente");

                }
                else if (token == 2)
                {

                    MessageBox.Show("Ya existe un espacio con el numero ingresado");

                }

            }
            else
            {

                MessageBox.Show("Hay errores con los datos ingresados");

            }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }
    }
}
