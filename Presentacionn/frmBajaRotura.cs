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
        private bool corroborarCampo()
        {
            bool tokenCampo = false;
            if (mtxtRotura.Text == "")
            {
                MessageBox.Show("Campo vacio");

            }
            else { tokenCampo = true; }
            return tokenCampo;
        }
        private void btnEliminarRotura_Click(object sender, EventArgs e)
        {
            bool tokenCa = corroborarCampo();
            if (tokenCa == true)
            {

                try
                {


                    dRotura unaRotD = new dRotura();
                    bool token = unaRotD.bajaRotura(Convert.ToString(Convert.ToInt32(mtxtRotura.Text)));
                    if (token == true)
                    {
                        MessageBox.Show("Rotura eliminada correctamente");

                    }
                    else { MessageBox.Show("Rotura no existente"); }
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
        }

        
    }
}
