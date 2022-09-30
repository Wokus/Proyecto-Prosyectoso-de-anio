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
 
    public partial class frmMenuInicial : Form
    {
        /*private bool v;*/

        public frmMenuInicial()
        {
            InitializeComponent();
        }

        /*public frmMenuInicial(bool v)
        {
            this.v = v;
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            dUsuario unAD = new dUsuario();

            eUsuario elAdmin = unAD.login(txtUserName.Text, txtPassword.Text);


            if (elAdmin == null)
            {
                MessageBox.Show("Usuario y/o constraseNIa incorrecta");

            }
            else
            {
                MessageBox.Show("Usuario y constraseNIa Correcta");
                frmMenuPrincipal unMP = new frmMenuPrincipal(true);
                this.Hide();
                unMP.Show();
                


            }
    }
        
        private void btnInvitado_Click(object sender, EventArgs e)
        {

            
            frmMenuPrincipal unMPI = new frmMenuPrincipal(false);
            
            this.Hide();
            unMPI.Show();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
