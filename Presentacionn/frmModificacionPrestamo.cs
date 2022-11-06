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

        private bool corroborarCampos(string tipo)
        {
            bool token = false;
            bool tokenTipo = false;
            if (cbxEstado.SelectedIndex != -1 && cbxModificacionPrestamo.SelectedIndex != -1
                && mtxtHoraRetiro.MaskFull && mtxtProfesor.MaskFull && mtxtIdPrestamo.Text != "")
            {
                if (tipo == "equipo")
                {
                    token = corroborarCamposDeEquipo();

                }
                if (tipo == "espacio")
                {
                    token = corroborarCamposDeEspacio();

                }
                if (tipo == "espontaneo")
                {
                    token = corroborarCamposDeEspontaneo();

                }
            }
            else { MessageBox.Show("Hay campos vacíos, incompletos o con información incorrecta"); }

            return token;
        }
        private bool corroborarCamposDeEquipo()
        {
            bool token = false;
            bool tokenMuchoTexto = true;
            if (cbxEjercicioPEquip.SelectedIndex != -1 && mtxtAlumno.MaskFull)
            {
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

                    if (txtTransporte.Text.Length < 51)
                    {
                        String[] locaciones = txtLocacion.Text.Split(',');
                        for (int e = 0; e < locaciones.Length; e++)
                        {
                            if (locaciones[e].Length < 151)
                            {
                                tokenMuchoTexto = true;
                            }
                            else
                            {
                                tokenMuchoTexto = false;
                                break;
                            }
                        }

                    }
                    else { tokenMuchoTexto = false; }
                }
            }
            if (token == false)
            {
                MessageBox.Show("Hay campos vacíos, incompletos o con información incorrecta");

            }
            else
            if (tokenMuchoTexto == false)
            {
                MessageBox.Show("Hay campos con demasiado texto");
                token = false;
            }


            return token;
        }
        private bool corroborarCamposDeEspacio()
        {
            bool token = false;
            if (mtxtIDSalon.Text != "" && cbxEjercicioPEquip.SelectedIndex != -1 && mtxtAlumno.MaskFull)
            {
                token = true;
            }
            else
            {
                MessageBox.Show("Hay campos vacíos, incompletos o con información incorrecta");
            }

            return token;
        }
        private bool corroborarCamposDeEspontaneo()
        {
            bool token = false;
            bool tokenMuchoTexto = false;
            if (txtEjercicio.Text != "")
            {
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

                if (txtEjercicio.Text.Length > 50)
                {
                    tokenMuchoTexto = false;
                }
                else { tokenMuchoTexto = true; }
            }
            if (token == false)
            {
                MessageBox.Show("Hay campos vacíos, incompletos o con información incorrecta");
            }
            else
            if (tokenMuchoTexto == false)
            {
                MessageBox.Show("Hay campos con demasiado texto");
                token = false;
            }
            return token;
        }
        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            if (cbxModificacionPrestamo.Text == "De equipo(Formales)")
            {
   
                   bool tokenCampos = corroborarCampos("equipo");
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
                }
            }
            
   
            if (cbxModificacionPrestamo.Text == "De espacio")
            {
                bool tokenCamposEs = corroborarCampos("espacio");
                if (tokenCamposEs == true)
                {

                    ePrestamoEspacio unEPES = new ePrestamoEspacio();
                    eResponsable alumno = new eResponsable();
                    eResponsable profe = new eResponsable();
                    eEspacio unEs = new eEspacio();
                    unEs.nombreEspacio = mtxtIDSalon.Text;
                    alumno.ci = mtxtAlumno.Text;
                    profe.ci = mtxtProfesor.Text;
                    unEPES.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                    unEPES.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                    unEPES.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                    unEPES.horaRetiro = mtxtHoraRetiro.Text;
                    unEPES.estado = cbxEstado.Text;
                    unEPES.id = Convert.ToInt32(mtxtIdPrestamo.Text);
                    unEPES.unEs = unEs;
                    unEPES.alumnoResponsable = alumno;
                    unEPES.profeResponsable = profe;
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
                        MessageBox.Show("Espacio no existente");
                    }
                    if (token == 69)
                    {
                        MessageBox.Show("Prestamo no existente");
                    }

                }
            }

            if (cbxModificacionPrestamo.Text == "Espontaneo")
            {
                bool tokenCamposEsp = corroborarCampos("espontaneo");
                if (tokenCamposEsp == true)
                {
                    ePrestamoEspontaneos unEPEX = new ePrestamoEspontaneos();

                    eEquipo unEq = new eEquipo();
                    eResponsable alumno = new eResponsable();
                    eResponsable profe = new eResponsable();
                    alumno.ci = mtxtAlumno.Text;
                    profe.ci = mtxtProfesor.Text;
                    unEq.nombre = txtEquiposId.Text;
                    unEPEX.unE= unEq;
                    unEPEX.alumnoResponsable = alumno;
                    unEPEX.profeResponsable = profe;

                    unEPEX.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                    unEPEX.fechaRetiro = dtpFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                    unEPEX.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                    unEPEX.horaRetiro = mtxtHoraRetiro.Text;
                    unEPEX.estado = cbxEstado.Text;
                    unEPEX.ejercicio = txtEjercicio.Text;
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
                    if (token == 69)
                    {
                        MessageBox.Show("Prestamo no existente");
                    }
                }
            }
            //}catch
        }
        private void frmModificacionPrestamo_Load(object sender, EventArgs e)
        {
            // Hace no visible
                mtxtIDSalon.Visible = false;
            lblIDSalon.Visible = false;
            txtEjercicio.Visible = false;
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
            cbxEjercicioPEquip.Visible = true;
            // Hace visible los texto
        }

        private void cbxModificacionPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxModificacionPrestamo.Text == "De equipo(Formales)")
            {
                // Hace no visible
                mtxtIDSalon.Visible = false;
                lblIDSalon.Visible = false;
                txtEjercicio.Visible = false;
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
                cbxEjercicioPEquip.Visible = true;
                // Hace visible los textos


            }
            if (cbxModificacionPrestamo.Text == "De espacio")
            {
                // Hace no visible
                txtTransporte.Visible = false;
                txtEquiposId.Visible = false;
                txtLocacion.Visible = false;
                txtEjercicio.Visible = false;

                // Hace no visible

                // Hace no visible textos
                lblTransporte.Visible = false;
                lblEquipoID.Visible = false;
                lblLocacion.Visible = false;
                // Hace no visible textos

                // Hace si visible textos
                mtxtIDSalon.Visible = true;
                lblIDSalon.Visible = true;
                cbxEjercicioPEquip.Visible = true;
                // Hace si visible textos

            }
            if (cbxModificacionPrestamo.Text == "Espontaneo")
            {

                // Hace no visible 
                mtxtIDSalon.Visible = false;
                txtTransporte.Visible = false;
                cbxEjercicioPEquip.Visible = false;
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
                txtEjercicio.Visible = true;
                // Hace visible 


            
        }
    }
    }
}
