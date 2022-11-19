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
            // Se corrobora que el campo este lleno, luego se convierte en un int el masked text para llamar a la id de dicho prestamo 
            // luego se mostara un mensaje dependiendo de lo que se halla agregado en programa 
            dPrestamo unDP = new dPrestamo();
            bool tokenCampos = corroborarCampo();
            if (tokenCampos == true)
            {     
            try
            {   
                int token = unDP.bajaPrestamoDeEquipo(Convert.ToInt16(mtxtidPrestamo.Text));

                if (token == 1)
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
            } else { MessageBox.Show("Campo vacio"); }

        }
        //Se crea un metodo para corroborrar si hay campos vacios en el programa
        private bool corroborarCampo()
        {
            bool token = true;
            if (mtxtidPrestamo.Text == "")
            {
                token = false;
            }
            return token;
        }
    }
}
