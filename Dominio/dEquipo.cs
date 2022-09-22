﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dominio
{
    public class dEquipo
    {
        public void altaEquipo(eEquipo unDE)
        {

            pEquipo unPE = new pEquipo();

            unPE.altaEquipo(unDE);
            
        }

        public int bajaEquipo(String id)
        {
            pEquipo unPE = new pEquipo();
            
            return unPE.bajaEquipo(id);
        }

        public DataTable listarEquipo()
        {

            pEquipo unPE = new pEquipo();

            return unPE.listarEquipo1();
        }

    }
}
