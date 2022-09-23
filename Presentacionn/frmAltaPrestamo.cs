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

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            ePrestamoEquipo unPRE = new ePrestamoEquipo();
            ePrestamoEspacio unPRES = new ePrestamoEspacio();
            ePrestamoEspontaneos unPREX = new ePrestamoEspontaneos();

            if (cbxTipoPrestamo.Text == "De equipo(Formales)")
            {
                unPRE.alumnoRespon = txtAlumno.Text;
                unPRE.profeRespon = txtProfesor.Text;
                unPRE.fechaSolicitada = mtxtFechaSolicitud.Text;
                unPRE.fechaRetiro = mtxtFechaRetiro.Text;
                unPRE.fechaDevolucion = mtxtFechaDevolucion.Text;
                unPRE.horaRetiro = mtxtHoraRetiro.Text;
                unPRE.estado = cbxEstado.Text;
                unPRE.ejercicio = txtEjercicio.Text;
                unPRE.transporte = txtTransporte.Text;
                unPRE.locacion = txtLocacion.Text;
                unPRE.equipos = txtEquipoID.Text;
                unPRE.horaDevolucion = "Sex:ooo";
                unPRE.cantidadDias = 69;

                dPrestamoEquipo unDPRE = new dPrestamoEquipo();
                bool tokenEquipo = unDPRE.altaPrestamo(unPRE);

                if (tokenEquipo == true)
                {
                    MessageBox.Show("Prestamo agregado de manera exitosa");


                }
                else { MessageBox.Show("Equipo no exitente"); }
            }


            if (cbxTipoPrestamo.Text == "De espacio")
            {
                unPRES.alumnoRespon = txtAlumno.Text;
                unPRES.profeRespon = txtProfesor.Text;
                unPRES.fechaSolicitada = mtxtFechaSolicitud.Text;
                unPRES.fechaRetiro = mtxtFechaRetiro.Text;
                unPRES.fechaDevolucion = mtxtFechaDevolucion.Text;
                unPRES.horaRetiro = mtxtHoraRetiro.Text;
                unPRES.estado = cbxEstado.Text;
                unPRES.numeroEspacio = Int32.Parse(txtIDSalon.Text);
                

                unPRES.horaDevolucion = "Sex:ooo";
                unPRES.cantidadDias = 69;

                dPrestamoEspacio unDPRE = new dPrestamoEspacio();
                bool tokenEspacio = unDPRE.altaPrestamoEspacio(unPRES);

                if (tokenEspacio == true)
                {
                    MessageBox.Show("Prestamo agregado de manera exitosa");
                }
                else { MessageBox.Show("Espacio no exitente"); }
            }

            if (cbxTipoPrestamo.Text == "Expontaneo")
            {
                unPREX.alumnoRespon = txtAlumno.Text;
                unPREX.profeRespon = txtProfesor.Text;
                unPREX.fechaSolicitada = mtxtFechaSolicitud.Text;
                unPREX.fechaRetiro = mtxtFechaRetiro.Text;
                unPREX.fechaDevolucion = mtxtFechaDevolucion.Text;
                unPREX.horaRetiro = mtxtHoraRetiro.Text;
                unPREX.estado = cbxEstado.Text;

                unPREX.horaDevolucion = "Sex:ooo";
                unPREX.cantidadDias = 69;
                unPREX.idEquipo = txtEquipoID.Text; 

                dPrestamoExpontaneo unDPREX = new dPrestamoExpontaneo();
                bool tokenEspacio = unDPREX.altaPrestamoEspacio(unPREX);

                if (tokenEspacio == true)
                {
                    MessageBox.Show("Prestamo agregado de manera exitosa");
                }
                else { MessageBox.Show("Espacio no exitente"); }
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
                txtIDSalon.Visible = false;
                
                lblIDSalon.Visible = false;
                
               

                txtTransporte.Visible = true;
                txtEjercicio.Visible = true;
                txtEquipoID.Visible = true;
                txtLocacion.Visible = true;

                lblTransporte.Visible = true;
                lblEjercicio.Visible = true;
                lblEquipoID.Visible = true;
                lblLocacion.Visible = true;



            }
            if (cbxTipoPrestamo.Text == "De espacio")
            {
                txtTransporte.Visible = false;
                txtEjercicio.Visible = false;
                txtEquipoID.Visible = false;
                txtLocacion.Visible = false;

                lblTransporte.Visible = false;
                lblEjercicio.Visible = false;
                lblEquipoID.Visible = false;
                lblLocacion.Visible = false;



                txtIDSalon.Visible = true;
                
                lblIDSalon.Visible = true;
                

            }
            if (cbxTipoPrestamo.Text == "Expontaneo")
            {
                txtIDSalon.Visible = false;
                lblIDSalon.Visible = false;

                txtTransporte.Visible = false;
                txtEjercicio.Visible = false;
              
                txtLocacion.Visible = false;

                lblTransporte.Visible = false;
                lblEjercicio.Visible = false;
                
                lblLocacion.Visible = false;



            }





        }
    }
}
