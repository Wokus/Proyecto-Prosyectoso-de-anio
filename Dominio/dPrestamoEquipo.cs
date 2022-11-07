﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Data;

namespace Dominio
{
    public class dPrestamoEquipo
    {
        public int altaPrestamo(ePrestamoEquipo unPRE)
        {
            pPrestamoEquipo unPPRE = new pPrestamoEquipo();


            int token = unPPRE.altaPrestamo(unPRE);
            return token;
        }


        public int modificacionPrestamo(ePrestamoEquipo unEPE)
        {

            pPrestamoEquipo unPPE = new pPrestamoEquipo();

            int confirmacion = unPPE.modificacionPrestamo(unEPE);
            return confirmacion;

        }

        public DataTable listarPrestamoDeEquipo()
        {

            pPrestamoEquipo unPE = new pPrestamoEquipo();

            return unPE.listarPrestamoDeEquipo();

        }

        public DataTable listarPrestamoPorFechaAR()
        {

            pPrestamoEquipo unPEF = new pPrestamoEquipo();

            return unPEF.listarPrestamoPorFechaAR();

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            pPrestamoEquipo unPEF = new pPrestamoEquipo();

            return unPEF.listarPrestamoPorFechaRA();

        }

        public DataTable listarPrestamoPorEstado(String tuHermana)
        {

            pPrestamoEquipo unPEE = new pPrestamoEquipo();

            return unPEE.listarPrestamoPorEstado(tuHermana);

        }

        public DataTable listarPrestamoPorFechaRAE(string tuHermana)
        { 
            pPrestamoEquipo unPPFE = new pPrestamoEquipo();

            return unPPFE.listarPrestamoPorFechaRAE(tuHermana);

        }

        public DataTable listarPrestamoPorFechaARE(string tuHermana)
        {
            pPrestamoEquipo unPPFE = new pPrestamoEquipo();

            return unPPFE.listarPrestamoPorFechaARE(tuHermana);

        }

        public DataTable listarPrestamoPorPrioridad(string prioridad)
        {

            pPrestamoEquipo unPPP = new pPrestamoEquipo();

            return unPPP.listarPrestamoPorPrioridad(prioridad);

        }

        public DataTable listarPrestamoPorPrioridadE(string prioridad, string tuHermana)
        {

            pPrestamoEquipo unPPPE = new pPrestamoEquipo();

            return unPPPE.listarPrestamoPorPrioridadE(prioridad, tuHermana);

        }
    }
}
