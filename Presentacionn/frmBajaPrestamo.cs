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
    public partial class frmBajaPrestamo : Form
    {
        public frmBajaPrestamo()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            dPrestamo unDP = new dPrestamo();
            try
            {
                int idPrestamo = unDP.bajaPrestamoDeEquipo(Convert.ToInt16(txtIdPrestamoBaja.Text));

                if (idPrestamo != 0)
                {

                    MessageBox.Show("Se bajo el prestamo correctamente");

                }
                else
                {

                    MessageBox.Show("No existe un prestamo con esa id");

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }

        }

        
    }
}
