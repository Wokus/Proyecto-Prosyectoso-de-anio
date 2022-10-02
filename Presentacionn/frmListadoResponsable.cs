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
    public partial class frmListadoResponsable : Form
    {
        public frmListadoResponsable()
        {
            dResponsable unDR = new dResponsable();
            dataGridView1.DataSource = unDR.ListarResponsable();
        }
    }
}
