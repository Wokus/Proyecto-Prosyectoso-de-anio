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
    public class dPrestamoEspontaneo
    {

        public DataTable listarPrestamoEspontaneo()
        {

            pPrestamoEspontaneo unPE = new pPrestamoEspontaneo();

            return unPE.listarPrestamoEspontaneo();
        }

    }
}
