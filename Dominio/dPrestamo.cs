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
             
        public int bajaPrestamoDeEquipo(int idPrestamo)
        {
            pPrestamo unPP = new pPrestamo();

            return unPP.bajaPrestamo(idPrestamo);
        }
    }
}
