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

                unEPE.alumnoResponsable.ci = mtxtAlumno.Text;
                unEPE.profeResponsable.ci = mtxtProfesor.Text;
                unEPE.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                unEPE.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                unEPE.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                unEPE.horaRetiro = mtxtHoraRetiro.Text;
                unEPE.estado = cbxEstado.Text;
                unEPE.ejercicio = txtEjercicio.Text;
                unEPE.transporte = txtTransporte.Text;
                unEPE.locacion = txtLocacion.Text;
                unEPE.unE.nombre = mtxtEquipoID.Text;
                
                unEPE.id = Convert.ToInt32(mtxtIdPrestamo.Text);
                //unEPE.idPrestamo = Convert.ToInt16(txtIdPrestamo.Text);

                dPrestamoEquipo unDPE = new dPrestamoEquipo();
                int confirmacion = unDPE.modificacionPrestamo(unEPE);

                if (confirmacion == 0)
                {
                    MessageBox.Show("Prestamo modificado de manera exitosa");


                }
                if (confirmacion == 1)
                {
                    MessageBox.Show("Alumno no existente");


                }
                if (confirmacion == 2)
                {
                    MessageBox.Show("Profesor no existente");
                }
                if (confirmacion == 3)
                {
                    MessageBox.Show("Equipo no existente");
                }
                if (confirmacion == 69)
                {
                    MessageBox.Show("Prestamo no existente");
                }
            }

            if (cbxModificacionPrestamo.Text == "Prestamo de Espacio")
            {

                ePrestamoEspacio unEPES = new ePrestamoEspacio();

                unEPES.alumnoResponsable.ci = mtxtAlumno.Text;

                unEPES.profeResponsable.ci = mtxtProfesor.Text;
                
                unEPES.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                unEPES.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                unEPES.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                unEPES.horaRetiro = mtxtHoraRetiro.Text;
                unEPES.estado = cbxEstado.Text;
                unEPES.id = Convert.ToInt32(mtxtIdPrestamo.Text);

                dPrestamoEspacio unDPES = new dPrestamoEspacio();
                int token = unDPES.modificacionPrestamo(unEPES);

                if (token == 0)
                {
                    MessageBox.Show("Prestamo modificado de manera exitosa");


                }
                if (token == 1)
                {
                    MessageBox.Show("Alumno no existente");
                }
                if (token == 2)
                {
                    MessageBox.Show("Profesor no existente");
                }
                if (token == 3)
                {
                    MessageBox.Show("Equipo no existente");
                }

            }

            if (cbxModificacionPrestamo.Text == "Prestamo Espontaneo")
            {

                ePrestamoEspontaneos unEPEX = new ePrestamoEspontaneos();

                unEPEX.alumnoResponsable.ci = mtxtAlumno.Text;
                unEPEX.profeResponsable.ci = mtxtProfesor.Text;
                unEPEX.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                unEPEX.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                unEPEX.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                unEPEX.horaRetiro = mtxtHoraRetiro.Text;
                unEPEX.estado = cbxEstado.Text;
            
                unEPEX.id = Convert.ToInt32(mtxtIdPrestamo.Text);

                dPrestamoExpontaneo unDPEX = new dPrestamoExpontaneo();
                int token = unDPEX.modificacionPrestamo(unEPEX);

                if (token == 0)
                {
                    MessageBox.Show("Prestamo modificado de manera exitosa");


                }
                if (token == 1)
                {
                    MessageBox.Show("Alumno no existente");


                }
                if (token == 2)
                {
                    MessageBox.Show("Profesor no existente");
                }
                if (token == 3)
                {
                    MessageBox.Show("Equipo no existente");
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
