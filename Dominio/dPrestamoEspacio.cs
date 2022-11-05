using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Data;

namespace Dominio
{
    public class dPrestamoEspacio
    {
        public int altaPrestamoEspacio(ePrestamoEspacio unPRE)
        {
            pPrestamoEspacio unEPRE = new pPrestamoEspacio();
            int token = unEPRE.altaPrestamoEspacio(unPRE);

            return token;

        }

        public int bajaPrestamoDeEspacio(int idPrestamo)
        {
            pPrestamoEspacio unPPES = new pPrestamoEspacio();

            return unPPES.bajaPrestamoDeEspacio(idPrestamo);
        }

        public int modificacionPrestamo(ePrestamoEspacio unEPES)
        {

            pPrestamoEspacio unPPES = new pPrestamoEspacio();

            int confirmacion = unPPES.modificacionPrestamo(unEPES);
            return confirmacion;

        }

        public DataTable listarPrestamoDeEspacio()
        {

            pPrestamoEspacio unPE = new pPrestamoEspacio();

            return unPE.listarPrestamoDeEspacio();
        }

        public DataTable listarPrestamoPorFechaAR()
        {

            pPrestamoEspacio unPEF = new pPrestamoEspacio();

            return unPEF.listarPrestamoPorFechaAR();

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            pPrestamoEspacio unPEF = new pPrestamoEspacio();

            return unPEF.listarPrestamoPorFechaRA();

        }

        public DataTable listarPrestamoPorEstado(String tuHermana)
        {

            pPrestamoEspacio unPEE = new pPrestamoEspacio();

            return unPEE.listarPrestamoPorEstado(tuHermana);

        }

        public DataTable listarPrestamoPorFechaARE(string tuHermana)
        {

            pPrestamoEspacio unPPFE = new pPrestamoEspacio();

            return unPPFE.listarPrestamoPorFechaARE(tuHermana);

        }

        public DataTable listarPrestamoPorFechaRAE(string tuHermana)
        {

            pPrestamoEspacio unPPFE = new pPrestamoEspacio();

            return unPPFE.listarPrestamoPorFechaRAE(tuHermana);

        }

    }
}
