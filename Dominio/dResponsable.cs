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

        public object ListarResponsabletipoP()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsabletipoP();
        }

        public object ListarResponsabletipoA()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsabletipoA();
        }

        public object ListarResponsableCP()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableCP();
        }

        public object ListarResponsableCS()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableCS();
        }

        public object ListarResponsableCT()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableCT();
        }

        public object ListarResponsableFT()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableFT();
        }

        public object ListarResponsableTT()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableTT();

        }

        public object ListarResponsableTTT()
        {
            pResponsable unPR = new pResponsable();
            return unPR.listarResponsableTTT();
        }
    }
}
