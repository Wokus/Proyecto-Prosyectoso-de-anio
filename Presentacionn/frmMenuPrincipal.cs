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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(bool clase)
        {
            
            InitializeComponent();
            if (clase == false)
            {
                
               // sc1.Panel1Collapsed = true;
                //panel 1=gestion de pedidos
                //panel 2= inventario
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //String combpot = cbxPrestamos.SelectedText;
            //if (combpot == "Agregar")
            //{
                rellenarPanel1(new frmAltaEquipo());

           //}
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            frmAdministracionUsuarios MU = new frmAdministracionUsuarios();
            MU.Show();
        }



        private void cbxListados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListados.SelectedIndex == 0)
            {
                rellenarPanel2(new frmListadoEquipo());
                
            }

            if (cbxListados.SelectedIndex == 1)
            {

                rellenarPanel2(new frmListadoPrestamo());

            }
            if (cbxListados.SelectedIndex == 2)
            {

                rellenarPanel2(new frmListadoResponsable());

            }

        }
        private void cbxAcciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAcciones.SelectedIndex == 0)
            {
                rellenarPanel1(new frmAltaEquipo());
                

            }
            if (cbxAcciones.SelectedIndex == 1)
            {
                rellenarPanel1(new frmBajaEquipo());

            }
            if (cbxAcciones.SelectedIndex == 2)
            {
                rellenarPanel1(new frmModificacionEquipo());
            }

            if (cbxAcciones.SelectedIndex == 3)
            {
                rellenarPanel1(new frmAltaPrestamo());

            }

            if (cbxAcciones.SelectedIndex == 4)
            {
                rellenarPanel1(new frmBajaPrestamo());
            }
            if (cbxAcciones.SelectedIndex == 5)
            {

                rellenarPanel1(new frmModificacionPrestamo());

            }

            if (cbxAcciones.SelectedIndex == 6)
            {
                rellenarPanel1(new frmAltaResponsable());
            }

            if (cbxAcciones.SelectedIndex == 7)
            {
                rellenarPanel1(new frmBajaResponsable());
            }

            if (cbxAcciones.SelectedIndex == 8)
            {
                rellenarPanel1(new frmModificacionResponsable());
            }
            if (cbxAcciones.SelectedIndex == 9)
            {
                rellenarPanel1(new frmAltaRotura());
            }
            if (cbxAcciones.SelectedIndex == 10)
            {
                rellenarPanel1(new frmBajaRotura());
            }
            if (cbxAcciones.SelectedIndex == 11)
            {
                rellenarPanel1(new frmModificacionRotura());
            }




        }

        private Form formActivo = null;
        public void rellenarPanel1(Form formHijo)
        {
            if (formActivo!=null)
           {
               formActivo.Close();
           }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            sc1.Panel1.Controls.Add(formHijo);
            sc1.Panel1.Tag = formHijo;
            formHijo.Show();
        }

        private Form formActivo2 = null;
        public void rellenarPanel2(Form formHijo2)
        {
            if (formActivo2 != null)
            {
                formActivo2.Close();
            }
            formActivo2 = formHijo2;
            formHijo2.TopLevel = false;
            formHijo2.FormBorderStyle = FormBorderStyle.None;
            formHijo2.Dock = DockStyle.Fill;
            sc1.Panel2.Controls.Add(formHijo2);
            sc1.Panel2.Tag = formHijo2;
            formHijo2.Show();
        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sc1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void sc1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }
        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
