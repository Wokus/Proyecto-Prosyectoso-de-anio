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
    public partial class frmAltaPrestamoEquipo : Form
    {
        public frmAltaPrestamoEquipo()
        {
            
            InitializeComponent();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            ePrestamoEquipo unPRE = new ePrestamoEquipo();

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
            unPRE.cantidadDias =          69;

            dPrestamoEquipo unDPRE = new dPrestamoEquipo();
           bool tokenEquipo =  unDPRE.altaPrestamo(unPRE);

            if (tokenEquipo == true)
            {
                MessageBox.Show("Prestamo agregado de manera exitosa");


            }else { MessageBox.Show("Equipo no exitente"); }


        }

        private void frmAltaPrestamo_Load(object sender, EventArgs e)
        {
            string eee;
        }
    }
}
