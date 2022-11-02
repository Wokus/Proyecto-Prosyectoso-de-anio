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
    public partial class frmModificacionResponsable : Form
    {
        public frmModificacionResponsable()
        {
            InitializeComponent();
        }

        private void btnModiRes_Click(object sender, EventArgs e)
        {
            eResponsable unR = new eResponsable();
            unR.ci = txtNewCi.Text;
            unR.curso = txtNewCi.Text;
            unR.tipo = cbxNewTipo.Text;
            dResponsable unDR = new dResponsable();
            try
            {
                eResponsable elAdmin = unDR.modificarResponsable(unR, txtOldCi.Text);

                if (elAdmin != null)
                {
                    MessageBox.Show("Usuario modificado de manera exitosa");

                }

                if (elAdmin == null)
                {
                    MessageBox.Show("Ocurrio un error en los datos ingresados");

                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
    }
}
