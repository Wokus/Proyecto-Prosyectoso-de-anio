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

    }
}
