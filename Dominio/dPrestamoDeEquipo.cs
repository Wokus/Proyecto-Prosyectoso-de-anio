﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamoDeEquipo
    {

        public DataTable listarPrestamoDeEquipo()
        {

            pPrestamoEquipo unPE = new pPrestamoEquipo();

            return unPE.listarPrestamoDeEquipo();
        }

    }
}
