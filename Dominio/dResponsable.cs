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
   public class  dResponsable 
    {
        public bool altaResponsable(eResponsable unDR)
        {
            pResponsable unPR = new pResponsable();

            return unPR.altaResponsable(unDR);
        }

        public eResponsable bajaResponsable(string EliminarRes)
        {
            pResponsable unPR = new pResponsable();
            return unPR.bajaResponsable(EliminarRes);

        }
        public eResponsable modificarResponsable(eResponsable unDR, String OldCi)
        {
            pResponsable unPR = new pResponsable();
            return unPR.modificarResponsable(unDR, OldCi);
        }

        public DataTable ListarResponsable()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsable();
        }
    }
}
