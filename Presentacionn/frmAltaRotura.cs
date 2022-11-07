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
    public partial class frmAltaRotura : Form
    {
        public frmAltaRotura()
        {
            InitializeComponent();
        }
        private bool corroborarCampos()
        {
            bool token = false;
            if (txtDescripcion.Text == "" || mtxtEquipoRoto.Text == "" || mtxtIdPrestamo.Text == "")
            {
                MessageBox.Show("Hay campos vacios");
            }else {
                token = true;

                if (txtDescripcion.Text.Length > 200)
                {
                    MessageBox.Show("Descripción muy larga");
                    token = false;
                }

            }
            return token;
        }

        private void btnAgregarRotura_Click_1(object sender, EventArgs e)
        {
            try { 
            bool tokenCampos = corroborarCampos();
            if (tokenCampos == true)
            {
                
                eEquipo unEq = new eEquipo();
                eResponsable alumno = new eResponsable();

                unEq.id = Convert.ToInt32(mtxtEquipoRoto.Text);
                unEq.rotu.descripcion = txtDescripcion.Text;
                unEq.rotu.fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                

                dRotura dRo = new dRotura();
                int token = dRo.altaRotura(unEq, Convert.ToString(Convert.ToInt32(mtxtIdPrestamo.Text)));
                if (token == 0)
                {
                    MessageBox.Show("Rotura agregada");
                }
                else if(token == 1)
                {
                    MessageBox.Show("Rotura no agregada, equipo no existente");
                }
                else if (token == 2)
                {
                    MessageBox.Show("Rotura no agregada, prestamo no existente");
                }

            }
            }
            catch (Exception error) {MessageBox.Show(error.Message); }

}

    }
}
