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
    public partial class frmBajaRotura : Form
    {
        public frmBajaRotura()
        {
            InitializeComponent();
        }

        private void btnEliminarRotura_Click(object sender, EventArgs e)
        {

        }

        private void txtIdEquipo_TextChanged(object sender, EventArgs e)
        {
            eRotura unaRot = new eRotura();
            dRotura unaRotD = new dRotura();
            unaRot = unaRotD.RecrearRot(txtIdEquipo.Text);

        }
    }
}
