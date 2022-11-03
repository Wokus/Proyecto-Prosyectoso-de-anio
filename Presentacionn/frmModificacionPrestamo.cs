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

        private bool corroborarCampos()
        {
            bool token = false;
            if (cbxEstado.SelectedIndex != -1 && cbxEjercicioPEquip.SelectedIndex != -1
                && mtxtHoraRetiro.MaskFull && mtxtProfesor.MaskFull && mtxtIdPrestamo.Text != "")
            {
                token = true;   
             }

            return token;
        }
        private bool corroborarCamposDeEquipo()
        {
            bool token = false;
            for (int i = 0; i < txtEquiposId.Text.Length; i++)
            {
                char c = txtEquiposId.Text[i];
                String cc = Convert.ToString(c);
                if (cc != "1" && cc != "2" && cc != "3" && cc != "4" && cc != "5" && cc != "6" && cc != "7" && cc != "8" && cc != "9" && cc != "0" && cc != ",")
                {
                    token = false;
                    break;
                }
                else { token = true; }

            }
            return token;
        }
        private bool corroborarCamposDeEspacio()
        {
            bool token = false;
            if (mtxtIDSalon.Text != "")
            {
                token = true;
            }

            return token;
        }
        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            bool tokenCampos = corroborarCampos();
            if (tokenCampos == false)
            {
                MessageBox.Show("Hay campos vacios, imcompletos o con informacion incorrecta");
            }
            else
            {
                if (cbxModificacionPrestamo.Text == "Prestamo de Equipo")
            {
                bool tokenCamposEq = corroborarCamposDeEquipo();
                if (tokenCampos == true)
                {
                    ePrestamoEquipo unPRE = new ePrestamoEquipo();
                    eEquipo unEq = new eEquipo();
                    eResponsable alumno = new eResponsable();
                    eResponsable profe = new eResponsable();
                    alumno.ci = mtxtAlumno.Text;
                    profe.ci = mtxtProfesor.Text;
                    unPRE.alumnoResponsable = alumno;
                    unPRE.profeResponsable = profe;
                    unPRE.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                    unPRE.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                    unPRE.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                    unPRE.horaRetiro = mtxtHoraRetiro.Text;
                    unPRE.estado = cbxEstado.Text;
                    unPRE.ejercicio = cbxEjercicioPEquip.Text;
                    unPRE.transporte = txtTransporte.Text;
                    unPRE.locacion = txtLocacion.Text;
                    unEq.nombre = txtEquiposId.Text;
                    unPRE.unE = unEq;

                    unPRE.id = Convert.ToInt32(mtxtIdPrestamo.Text);

                    dPrestamoEquipo unDPE = new dPrestamoEquipo();



                    int confirmacion = unDPE.modificacionPrestamo(unPRE);

                    if (confirmacion == 0)
                    {
                        MessageBox.Show("Prestamo modificado de manera exitosa");


                    }
                    if (confirmacion == 3)
                    {
                        MessageBox.Show("Alumno no existente");
                    }
                    if (confirmacion == 2)
                    {
                        MessageBox.Show("Profesor no existente");
                    }
                    if (confirmacion == 1)
                    {
                        MessageBox.Show("Equipo no existente");
                    }
                    if (confirmacion == 69)
                    {
                        MessageBox.Show("Prestamo no existente");
                    }

                    } else {MessageBox.Show("Hay campos vacios, imcompletos o con informacion incorrecta");}
                }

                if (cbxModificacionPrestamo.Text == "Prestamo de Espacio")
                    {
                            bool tokenCamposEs = corroborarCamposDeEspacio();
                            if (tokenCamposEs == true)
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

                    }else {MessageBox.Show("Hay campos vacios, imcompletos o con informacion incorrecta");}

                }

                if (cbxModificacionPrestamo.Text == "Prestamo Espontaneo")
                    {
                            bool tokenCamposEsp = corroborarCamposDeEquipo();
                            if (tokenCamposEsp == true)
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
                        }else {MessageBox.Show("Hay campos vacios, imcompletos o con informacion incorrecta");}
                    }
                }
            
          
            
        }




        private void frmModificacionPrestamo_Load(object sender, EventArgs e)
        {
            // Hace no visible
            mtxtIDSalon.Visible = false;
            lblIDSalon.Visible = false;
            // Hace no visible

            // Hace visible
            txtTransporte.Visible = true;
            txtEquiposId.Visible = true;
            txtLocacion.Visible = true;
            cbxEjercicioPEquip.Visible = true;
            // Hace visible

            // Hace visible los textos
            lblTransporte.Visible = true;
            lblEjercicio.Visible = true;
            lblEquipoID.Visible = true;
            lblLocacion.Visible = true;
            // Hace visible los textos
        }

        private void cbxModificacionPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxModificacionPrestamo.SelectedIndex == 0)
            {

                // Hace no visible
                mtxtIDSalon.Visible = false;
                lblIDSalon.Visible = false;
                // Hace no visible

                // Hace visible
                txtTransporte.Visible = true;
                txtEquiposId.Visible = true;
                txtLocacion.Visible = true;
                // Hace visible

                // Hace visible los textos
                lblTransporte.Visible = true;
                lblEquipoID.Visible = true;
                lblLocacion.Visible = true;
                // Hace visible los textos

            }
            if (cbxModificacionPrestamo.SelectedIndex == 1)
            {

                // Hace no visible
                txtTransporte.Visible = false;
                txtEquiposId.Visible = false;
                txtLocacion.Visible = false;
                // Hace no visible

                // Hace no visible textos
                lblTransporte.Visible = false;
                lblEquipoID.Visible = false;
                lblLocacion.Visible = false;
                // Hace no visible textos

                // Hace si visible textos
                mtxtIDSalon.Visible = true;
                lblIDSalon.Visible = true;
                // Hace si visible textos

            }
            if (cbxModificacionPrestamo.SelectedIndex == 2)
            {

                // Hace no visible 
                mtxtIDSalon.Visible = false;
                txtTransporte.Visible = false;
                txtLocacion.Visible = false;
                // Hace no visible 

                // Hace no visible textos
                lblTransporte.Visible = false;
                lblLocacion.Visible = false;
                lblIDSalon.Visible = false;
                // Hace no visible textos

                // Hace visible 
                lblEquipoID.Visible = true;
                txtEquiposId.Visible = true;
                // Hace visible 

            }

        }

    }
}
