using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Data;

namespace Dominio
{
    public class dPrestamoEspacio
    {
        public bool altaPrestamoEspacio(ePrestamoEspacio unPRE)
        {
            pPrestamoEspacio unEPRE = new pPrestamoEspacio();
            bool tokenEspacio = unEPRE.altaPrestamoEspacio(unPRE);

            return tokenEspacio;

        }

            public DataTable listarPrestamoDeEspacio()
        {

            pPrestamoEspacio unPE = new pPrestamoEspacio();

            return unPE.listarPrestamoDeEspacio();
        }
    }
}
