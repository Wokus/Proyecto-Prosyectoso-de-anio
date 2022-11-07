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
    public partial class frmModificacionRotura : Form
    {
        public frmModificacionRotura()
        {
            InitializeComponent();
        }
        private bool corroborarCampos()
        {
            bool token = false;
            if (txtDescricion.Text == "" || mtxtEquipo.Text == "" || mtxtPrestamo.Text == "")
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                token = true;

                if (txtDescricion.Text.Length > 200)
                {
                    MessageBox.Show("Descripción muy larga");
                    token = false;
                }

            }
            return token;
        }

        private void btnModificarRotura_Click(object sender, EventArgs e)
        {
            bool tokenCampos = corroborarCampos();
            if (tokenCampos == true)
            {
                try
                {


                    eEquipo unEq = new eEquipo();
                    eResponsable alumno = new eResponsable();

                    unEq.id = Convert.ToInt32(mtxtEquipo.Text);
                    unEq.rotu.descripcion = txtDescricion.Text;
                    unEq.rotu.fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                    unEq.rotu.idRotura = Convert.ToInt32(mtxtRotura.Text);


                    dRotura dRo = new dRotura();
                    int token = dRo.modificacionRotura(unEq, Convert.ToString(Convert.ToInt32(mtxtPrestamo.Text)));
                    if (token == 0)
                    {
                        MessageBox.Show("Rotura modificada");
                    }
                    else if (token == 1)
                    {
                        MessageBox.Show("Rotura no modificada, equipo no existente");
                    }
                    else if (token == 2)
                    {
                        MessageBox.Show("Rotura no modificada, prestamo no existente");
                    }

                }catch(Exception error) {MessageBox.Show(error.Message);
 }

        }
        }
    }
}
