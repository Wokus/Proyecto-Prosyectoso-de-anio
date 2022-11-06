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
    public partial class frmAltaPrestamo : Form
    {
        public frmAltaPrestamo()
        {
            
            InitializeComponent();
        }
        private bool corroborarCampos(string tipo)
        {
            bool token = false;
            bool tokenTipo = false;
            if (cbxEstado.SelectedIndex != -1 && cbxTipoPrestamo.SelectedIndex != -1
                && mtxtHoraRetiro.MaskFull && mtxtProfesor.MaskFull)
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
            }else { MessageBox.Show("Hay campos vacíos, incompletos o con información incorrecta"); }
            
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
                
            } else
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
            }else
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
            }else
            if (tokenMuchoTexto == false)
            {
                MessageBox.Show("Hay campos con demasiado texto");
                token = false;
            }
            return token;
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            ePrestamoEquipo unPRE = new ePrestamoEquipo();
            ePrestamoEspacio unPRES = new ePrestamoEspacio();
            ePrestamoEspontaneos unPREX = new ePrestamoEspontaneos();
             try
             {
                bool tokenCampos;
                if (cbxTipoPrestamo.Text == "De equipo(Formales)")
                {
                    tokenCampos = corroborarCampos("equipo");
                    if (tokenCampos == false)
                    {
                        
                    }
                    else
                    {
                        eEquipo unEq = new eEquipo();
                        eResponsable alumno = new eResponsable();
                        eResponsable profe = new eResponsable();
                        alumno.ci = mtxtAlumno.Text;
                        profe.ci = mtxtProfesor.Text;
                        unPRE.alumnoResponsable = alumno;
                        unPRE.profeResponsable = profe;
                        unPRE.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                        unPRE.fechaRetiro = dtptFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                        unPRE.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                        unPRE.horaRetiro = mtxtHoraRetiro.Text;
                        unPRE.estado = cbxEstado.Text;
                        unPRE.ejercicio = cbxEjercicioPEquip.Text;
                        unPRE.transporte = txtTransporte.Text;
                        unPRE.locacion = txtLocacion.Text;
                        unEq.nombre = txtEquiposId.Text;
                        unPRE.unE = unEq;

                        dPrestamoEquipo unDPRE = new dPrestamoEquipo();
                        int token = unDPRE.altaPrestamo(unPRE);

                        if (token == 0)
                        {
                            MessageBox.Show("Prestamo agregado de manera exitosa");
                        }
                        if (token == 3)
                        {
                            MessageBox.Show("Alumno no existente");


                        }
                        if (token == 2)
                        {
                            MessageBox.Show("Profesor no existente");
                        }
                        if (token == 1)
                        {
                            MessageBox.Show("Equipo no existente");
                        }
                    }

                }


                if (cbxTipoPrestamo.Text == "De espacio")
                {
                    tokenCampos = corroborarCampos("espacio");
                    if (tokenCampos == false)
                    {
                    }
                    else
                    {
                        eResponsable alumno = new eResponsable();
                        eResponsable profe = new eResponsable();
                        eEspacio unEs = new eEspacio();
                        alumno.ci = mtxtAlumno.Text;
                        profe.ci = mtxtProfesor.Text;
                        unEs.numeroEspacio = Int32.Parse(mtxtIDSalon.Text);
                        unPRES.unEs = unEs;
                        unPRES.alumnoResponsable = alumno;
                        unPRES.profeResponsable = profe;
                        unPRES.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                        unPRES.fechaRetiro = dtptFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                        unPRES.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                        unPRES.horaRetiro = mtxtHoraRetiro.Text;
                        unPRES.estado = cbxEstado.Text;
                        unPRES.ejercicio = cbxEjercicioPEquip.Text;

                        dPrestamoEspacio unDPRE = new dPrestamoEspacio();
                        int token = unDPRE.altaPrestamoEspacio(unPRES);

                        if (token == 0)
                        {
                            MessageBox.Show("Prestamo agregado de manera exitosa");
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

                if (cbxTipoPrestamo.Text == "Espontaneo")
                {
                    tokenCampos = corroborarCampos("espontaneo");
                    if (tokenCampos == false)
                    {
                    }
                    else
                    {
                    eEquipo unEq = new eEquipo();
                    eResponsable alumno = new eResponsable();
                    eResponsable profe = new eResponsable();
                    alumno.ci = mtxtAlumno.Text;
                    profe.ci = mtxtProfesor.Text;
                    unEq.nombre = txtEquiposId.Text;
                    unPREX.alumnoResponsable = alumno;
                    unPREX.profeResponsable = profe;
                    unPREX.fechaSolicitada = dtpFechaSolicitud.Value.ToString("yyyy-MM-dd"); ;
                    unPREX.fechaRetiro = dtptFechaRetiro.Value.ToString("yyyy-MM-dd"); ;
                    unPREX.fechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd"); ;
                    unPREX.horaRetiro = mtxtHoraRetiro.Text;
                    unPREX.estado = cbxEstado.Text;
                    unPREX.ejercicio = txtEjercicio.Text;
                    unPREX.unE = unEq;
                    dPrestamoExpontaneo unDPREX = new dPrestamoExpontaneo();
                        int token = unDPREX.altaPrestamoEspacio(unPREX);

                        if (token == 0 || token == 3)
                        {
                            MessageBox.Show("Prestamo agregado de manera exitosa");


                        }
                        if (token == 4)
                        {
                            MessageBox.Show("Alumno no existente");


                        }
                        if (token == 2)
                        {
                            MessageBox.Show("Profesor no existente");
                        }
                        if (token == 1)
                        {
                            MessageBox.Show("Equipo no existente");
                        }
                    }
        
                    }
                
            }catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void cbxTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPrestamo.Text == "De equipo(Formales)")
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
            if (cbxTipoPrestamo.Text == "De espacio")
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
            if (cbxTipoPrestamo.Text == "Espontaneo")
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

        private void frmAltaPrestamo_Load(object sender, EventArgs e)
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
    }
}
