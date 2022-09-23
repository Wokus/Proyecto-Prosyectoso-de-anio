using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
   public class  dResponsable 
    {
        public bool altaResponsable(eResponsable unDR)
        {
            pResponsable unPR = new pResponsable();

            return unPR.altaResponsable(unDR);
        }


    }
}
