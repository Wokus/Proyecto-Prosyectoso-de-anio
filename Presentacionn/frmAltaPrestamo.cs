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

        private bool corroborarCampos()
        {
            bool token = false;
            if (cbxEstado.SelectedIndex != -1 && cbxTipoPrestamo.SelectedIndex != -1
                && mtxtHoraRetiro.MaskFull && cbxEjercicioPEquip.SelectedIndex != -1
                && mtxtProfesor.MaskFull)
            {
                for (int i = 0; i < txtEquiposId.Text.Length; i++)
                {
                    char c = txtEquiposId.Text[i];
                    String cc = Convert.ToString(c);
                    if (cc != "1" && cc != "2" && cc != "3" && cc != "4" && cc != "5" && cc != "6" && cc != "7" && cc != "8" && cc != "9" && cc != "0")
                    {
                        token = false;
                        break;
                    }
                    else { token = true; }
                }
            
            }


            return token;
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            ePrestamoEquipo unPRE = new ePrestamoEquipo();
            ePrestamoEspacio unPRES = new ePrestamoEspacio();
            ePrestamoEspontaneos unPREX = new ePrestamoEspontaneos();
            bool tokenCampos = corroborarCampos();
            if (tokenCampos == false)
            {
                MessageBox.Show("Hay campos vacios, imcompletos o con informacion incorrecta");
            }
            else
            {


           
            try
            {
                if (cbxTipoPrestamo.Text == "De equipo(Formales)")
            {
                  
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
                unPRE.unE.nombre = txtEquiposId.Text;
                
                

               
                dPrestamoEquipo unDPRE = new dPrestamoEquipo();
                int token = unDPRE.altaPrestamo(unPRE);

                if (token == 0)
                {
                    MessageBox.Show("Prestamo agregado de manera exitosa");


                }
                if (token == 1){
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


                if (cbxTipoPrestamo.Text == "De espacio")
            {
                   
                    unPRES.unEs.numeroEspacio= Int32.Parse(mtxtIDSalon.Text);

                  
                unPRES.alumnoResponsable.ci= mtxtAlumno.Text;
                unPRES.profeResponsable.ci = mtxtProfesor.Text;
                unPRES.fechaSolicitada = dtpFechaSolicitud.Text;
                unPRES.fechaRetiro = dtptFechaRetiro.Text;
                unPRES.fechaDevolucion = dtpFechaDevolucion.Text;
                unPRES.horaRetiro = mtxtHoraRetiro.Text;
                unPRES.estado = cbxEstado.Text;
                
                

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

            if (cbxTipoPrestamo.Text == "Expontaneo")
            {
                unPREX.alumnoResponsable.ci = mtxtAlumno.Text;
                unPREX.profeResponsable.ci = mtxtProfesor.Text;
                unPREX.fechaSolicitada = dtpFechaSolicitud.Text;
                unPREX.fechaRetiro = dtptFechaRetiro.Text;
                unPREX.fechaDevolucion = dtpFechaDevolucion.Text;
                unPREX.horaRetiro = mtxtHoraRetiro.Text;
                unPREX.estado = cbxEstado.Text;
                

         
                unPREX.idEquipo = txtEquiposId.Text; 

                dPrestamoExpontaneo unDPREX = new dPrestamoExpontaneo();
                    int token = unDPREX.altaPrestamoEspacio(unPREX);

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
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
        }

        

        private void frmAltaPrestamo_Load(object sender, EventArgs e)
        {
            string eee;
        }

        private void txtEjercicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTransporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLocacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEquipoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtFechaDevolucion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtFechaRetiro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtFechaSolicitud_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblAsegurado_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaIgreso_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroSerie_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtxtHoraRetiro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPrestamo.Text == "De equipo(Formales)")
            {
                mtxtIDSalon.Visible = false;
                txtEquiposId.Visible = false;
                lblIDSalon.Visible = false;
                
               

                txtTransporte.Visible = true;
                txtEquiposId.Visible = true;
                txtLocacion.Visible = true;

                lblTransporte.Visible = true;
                lblEjercicio.Visible = true;
                lblEquipoID.Visible = true;
                lblLocacion.Visible = true;
                cbxEjercicioPEquip.Visible = true;


            }
            if (cbxTipoPrestamo.Text == "De espacio")
            {
                txtTransporte.Visible = false;
                cbxEjercicioPEquip.Visible = false;
                txtEquiposId.Visible = false;
                txtLocacion.Visible = false;

                lblTransporte.Visible = false;
                lblEjercicio.Visible = false;
                lblEquipoID.Visible = false;
                lblLocacion.Visible = false;



                mtxtIDSalon.Visible = true;
                
                lblIDSalon.Visible = true;
                

            }
            if (cbxTipoPrestamo.Text == "Expontaneo")
            {
                mtxtIDSalon.Visible = false;
                lblIDSalon.Visible = false;

                txtTransporte.Visible = false;
                cbxEjercicioPEquip.Visible = false;
              
                txtLocacion.Visible = false;

                lblTransporte.Visible = false;
                lblEjercicio.Visible = false;
                
                lblLocacion.Visible = false;



            }





        }

        private void lblIDSalon_Click(object sender, EventArgs e)
        {

        }

        private void txtIDSalon_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtIDSalon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
