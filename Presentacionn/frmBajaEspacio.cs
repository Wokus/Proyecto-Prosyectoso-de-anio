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
    public partial class frmBajaEspacio : Form
    {
        public frmBajaEspacio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dEspacio unES = new dEspacio();
            eEspacio elAdmin = unES.bajaEspacio(txtBajaEspacio.Text);
            if (elAdmin == null)
            {
                MessageBox.Show("El espacio es incorrecto");
             }
            else
            {
                MessageBox.Show("El espacio fue eliminado");
            }





               

        }
    }
}
