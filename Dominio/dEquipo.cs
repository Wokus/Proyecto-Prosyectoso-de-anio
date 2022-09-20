using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using MySql.Data.MySqlClient;

namespace Dominio
{
    public class dEquipo
    {
        public bool altaEquipo(eEquipo unDE)
        {

            pEquipo unPE = new pEquipo();

           bool equipoCreado =  unPE.altaEquipo(unDE);

            return equipoCreado;
        }

        public int bajaEquipo(String id)
        {
            pEquipo unPE = new pEquipo();
            
            return unPE.bajaEquipo(id);
        }


    }
}
