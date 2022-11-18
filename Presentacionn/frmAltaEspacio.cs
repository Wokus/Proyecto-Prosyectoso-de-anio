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
    public partial class frmAltaEspacio : Form
    {
        public frmAltaEspacio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text.Length < 16 && mtxtNumero.Text != "")
            {

                eEspacio unE = new eEspacio();
                unE.nombreEspacio = txtNombre.Text;
                unE.numeroEspacio = mtxtNumero.Text;

                dEspacio unDE = new dEspacio();
                bool altaEspacio = unDE.altaEspacio(unE);
                
                if (altaEspacio == false)
                {

                    MessageBox.Show("Se agrego el espacio");

                }else
                {
                
                    MessageBox.Show("No se agrego el espacio");

                }

            }else
            {

                MessageBox.Show("Hay errores con los datos ingresados");

            }
        }
    }
}
