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
    public partial class frmListadoRotura : Form
    {
        public frmListadoRotura()
        {
            InitializeComponent();
        }

        private void frmListadoRotura_Load(object sender, EventArgs e)
        {
            try
            {
                dRotura unaDRo = new dRotura();
                dgvListadoRotura.DataSource = unaDRo.ListaRoturas();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }
    }
}
