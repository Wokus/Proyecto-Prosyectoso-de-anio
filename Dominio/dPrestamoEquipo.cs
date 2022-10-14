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

        public int bajaPrestamoDeEquipo(int idPrestamo)
        {
            pPrestamoEquipo unPPE = new pPrestamoEquipo();

            return unPPE.bajaPrestamoDeEquipo(idPrestamo);
        }

        public bool modificacionPrestamo(ePrestamoEquipo unEPE, String IdPrestamo)
        {

            pPrestamoEquipo unPPE = new pPrestamoEquipo();

            bool confirmacion = unPPE.modificacionPrestamo(unEPE, IdPrestamo);
            return confirmacion;
            
        }

        public DataTable listarPrestamoDeEquipo()
        {

            pPrestamoEquipo unPE = new pPrestamoEquipo();

            return unPE.listarPrestamoDeEquipo();
        }
    }
}
