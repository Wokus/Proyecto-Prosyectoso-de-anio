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
    public partial class frmBajaResponsable : Form
    {
        public frmBajaResponsable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
