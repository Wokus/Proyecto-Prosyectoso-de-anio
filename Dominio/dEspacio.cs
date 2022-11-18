using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;
using System.Data;

namespace Dominio
{
    public class dEspacio
    {

        public DataTable listarEspacio()
        {

            pEspacio unPE = new pEspacio();

            return unPE.listarEspacio();

        }

        public eEspacio bajaEspacio(string text)
        {
            pEspacio unDE = new pEspacio();
            return unDE.bajaEspacio(text);
        }

        public int altaEspacio(eEspacio unE)
        {

            pEspacio unPE = new pEspacio();

            bool corroborarExistencia = unPE.altaEspacio(unPE);

            return corroborarExistencia;

        }
    }
}
