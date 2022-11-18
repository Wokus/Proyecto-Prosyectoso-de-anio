using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;
using System.Data;
using System.Windows.Forms;

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

        public bool altaEspacio(eEspacio unE)
        {

            pEspacio unPE = new pEspacio();

            bool corroborarExistencia = unPE.altaEspacio(unE);

            return corroborarExistencia;

        }

        public int modificarEspacio(eEspacio unE, String nmroMod)
        {
            pEspacio unPE = new pEspacio();
           return unPE.modificarEspacio(unE,nmroMod)

        }
    }
}
