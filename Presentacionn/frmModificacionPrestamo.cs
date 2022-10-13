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
    public partial class frmModificacionPrestamo : Form
    {
        public frmModificacionPrestamo()
        {
            InitializeComponent();
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {

            if (cbxModificacionPrestamo.Text == "Prestamo de Equipo")
            {

                ePrestamoEquipo unEPE = new ePrestamoEquipo();

                unEPE.alumnoRespon = mtxtAlumno.Text;
                unEPE.profeRespon = mtxtProfesor.Text;
                unEPE.fechaSolicitada = mtxtFechaSolicitud.Text;
                unEPE.fechaRetiro = mtxtFechaRetiro.Text;
                unEPE.fechaDevolucion = mtxtFechaDevolucion.Text;
                unEPE.horaRetiro = mtxtHoraRetiro.Text;
                unEPE.estado = cbxEstado.Text;
                unEPE.ejercicio = txtEjercicio.Text;
                unEPE.transporte = txtTransporte.Text;
                unEPE.locacion = txtLocacion.Text;
                unEPE.equipos = mtxtEquipoID.Text;
                unEPE.horaDevolucion = "Sex:ooo";
                unEPE.cantidadDias = 69;
                //unEPE.idPrestamo = Convert.ToInt16(txtIdPrestamo.Text);

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                bool confirmacion = unDPE.modificacionPrestamo(unEPE, mtxtIdPrestamo.Text);

                if(confirmacion = true)
                {

                    MessageBox.Show("Se Modifico el Prestamo Correctamente");

                }
                else
                {

                    MessageBox.Show("No se Modifico el Prestamo Correctamente");

                }

                }

            if (cbxModificacionPrestamo.Text == "Prestamo de Espacio")
            {

                ePrestamoEspacio unEPES = new ePrestamoEspacio();

                unEPES.alumnoRespon = mtxtAlumno.Text;
                unEPES.profeRespon = mtxtProfesor.Text;
                unEPES.fechaSolicitada = mtxtFechaSolicitud.Text;
                unEPES.fechaRetiro = mtxtFechaRetiro.Text;
                unEPES.fechaDevolucion = mtxtFechaDevolucion.Text;
                unEPES.horaRetiro = mtxtHoraRetiro.Text;
                unEPES.estado = cbxEstado.Text;
                unEPES.horaDevolucion = "Sex:ooo";
                unEPES.cantidadDias = 69;

                dPrestamoEspacio unDPES = new dPrestamoEspacio();
                bool confirmacion = unDPES.modificacionPrestamo(unEPES, mtxtIdPrestamo.Text);

                if (confirmacion = true)
                {

                    MessageBox.Show("Se Modifico el Prestamo Correctamente");

                }
                else
                {

                    MessageBox.Show("No se Modifico el Prestamo Correctamente");

                }

            }

            if (cbxModificacionPrestamo.Text == "Prestamo Espontaneo")
            {

                ePrestamoEspontaneos unEPEX = new ePrestamoEspontaneos();

                unEPEX.alumnoRespon = mtxtAlumno.Text;
                unEPEX.profeRespon = mtxtProfesor.Text;
                unEPEX.fechaSolicitada = mtxtFechaSolicitud.Text;
                unEPEX.fechaRetiro = mtxtFechaRetiro.Text;
                unEPEX.fechaDevolucion = mtxtFechaDevolucion.Text;
                unEPEX.horaRetiro = mtxtHoraRetiro.Text;
                unEPEX.estado = cbxEstado.Text;
                unEPEX.horaDevolucion = "Sex:ooo";
                unEPEX.cantidadDias = 69;

                dPrestamoExpontaneo unDPEX = new dPrestamoExpontaneo();
                bool confirmacion = unDPEX.modificacionPrestamo(unEPEX, mtxtIdPrestamo.Text);

                if (confirmacion = true)
                {

                    MessageBox.Show("Se Modifico el Prestamo Correctamente");

                }
                else
                {

                    MessageBox.Show("No se Modifico el Prestamo Correctamente");

                }

            }

        }

       

        private void frmModificacionPrestamo_Load(object sender, EventArgs e)
        {

        }

       private void cbxModificacionPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxModificacionPrestamo.SelectedIndex == 0)
            {

                mtxtIDSalon.Visible = true;
                txtLocacion.Visible = true;
                txtEjercicio.Visible = true;
                txtTransporte.Visible = true;
                mtxtEquipoID.Visible = true;

            }
            if (cbxModificacionPrestamo.SelectedIndex == 1)
            {

                txtLocacion.Visible = false;
                txtEjercicio.Visible = false;
                txtTransporte.Visible = false;
                mtxtEquipoID.Visible = false;
                
            }
            if (cbxModificacionPrestamo.SelectedIndex == 2)
            {

                txtLocacion.Visible = false;
                txtEjercicio.Visible = false;
                txtTransporte.Visible = false;
                mtxtEquipoID.Visible = false;

            }

        }
    }
}
