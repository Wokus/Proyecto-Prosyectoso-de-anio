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
        public bool altaPrestamo(ePrestamoEquipo unPRE)
        {
            pPrestamoEquipo unPPRE = new pPrestamoEquipo();


            bool tokenEquipo = unPPRE.altaPrestamo(unPRE);
            return tokenEquipo;
        }



        public DataTable listarPrestamoDeEquipo()
        {

            pPrestamoEquipo unPE = new pPrestamoEquipo();

            return unPE.listarPrestamoDeEquipo();
        }
    }
}
