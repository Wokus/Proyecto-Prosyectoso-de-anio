using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dEspacio
    {
        public int  altaEspacio(eEspacio unE)
        {
            pEspacio p = new pEspacio();
            int token = p.altaEspacio(unE);
        }
    }
}
