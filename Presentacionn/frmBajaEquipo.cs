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
    public partial class frmBajaEquipo : Form
    {
        public frmBajaEquipo()
        {
            InitializeComponent();
        }

        private void frmBajaEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            dEquipo unDE = new dEquipo();
            int id = unDE.bajaEquipo(txtId.Text);



            if (id == 0)
            {

                MessageBox.Show("id infresado incorrrecto");

            }
            else
            {
                MessageBox.Show("Equipo bajado de manera exitosa");
            }
        }


    }
}