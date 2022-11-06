using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamo
    {

        public DataTable listarPrestamo()
        {

            pPrestamo unPE = new pPrestamo();

            return unPE.listarPrestamo();
        }

        public DataTable listarPrestamoPorFechaAR()
        {

            pPrestamo unPEF = new pPrestamo();

            return unPEF.listarPrestamoPorFechaAR();

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            pPrestamo unPEF = new pPrestamo();

            return unPEF.listarPrestamoPorFechaRA();

        }

        public DataTable listarPrestamoPorEstado(String tuHermana)
        {

            pPrestamo unPEE = new pPrestamo();

            return unPEE.listarPrestamoPorEstado(tuHermana);

        }

        public DataTable listarPrestamoPorFechaARE(String tuHermana)
        {

            pPrestamo unPPFE = new pPrestamo();

            return unPPFE.listarPrestamoPorFechaARE(tuHermana);

        }

        public DataTable listarPrestamoPorFechaRAE(String tuHermana)
        {

            pPrestamo unPPFE = new pPrestamo();

            return unPPFE.listarPrestamoPorFechaRAE(tuHermana);

        }

        public DataTable listarPrestamoPorPrioridad(string prioridad)
        {

            pPrestamo unPPP = new pPrestamo();

            return unPPP.listarPrestamoPorPrioridad(prioridad);

        }

        public DataTable listarPrestamoPorPrioridadE(string prioridad, string tuHermana)
        {

            pPrestamo unPPPE = new pPrestamo();

            return unPPPE.listarPrestamoPorPrioridadE(prioridad, tuHermana);

        }

        public int bajaPrestamoDeEquipo(int idPrestamo)
        {
            pPrestamo unPP = new pPrestamo();

            return unPP.bajaPrestamo(idPrestamo);
        }
    }
}
