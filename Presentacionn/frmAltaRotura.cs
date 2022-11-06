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
        
        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            eRotura unR = new eRotura();
            eEquipo unEq = new eEquipo();
            eResponsable alumno = new eResponsable();
            eResponsable profesor = new eResponsable();
            ePrestamo unP = new ePrestamo();

            unR.idRotura = Int32.Parse(txtEquipoRoto.Text);
            unP.id = Int32.Parse(txtPrestamo.Text);
            alumno.ci = txtAluResponsable.Text;
            profesor.ci = txtProResponsable.Text;
            unR.descripcion = txtDescripcion.Text;
                
        }
    }
}
