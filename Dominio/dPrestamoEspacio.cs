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

        public int bajaPrestamoDeEspacio(int idPrestamo)
        {
            pPrestamoEspacio unPPES = new pPrestamoEspacio();

            return unPPES.bajaPrestamoDeEspacio(idPrestamo);
        }

        public bool modificacionPrestamo(ePrestamoEspacio unEPES, String IdPrestamo)
        {

            pPrestamoEspacio unPPES = new pPrestamoEspacio();

            bool confirmacion = unPPES.modificacionPrestamo(unEPES, IdPrestamo);
            return confirmacion;

        }

        public DataTable listarPrestamoDeEspacio()
        {

            pPrestamoEspacio unPE = new pPrestamoEspacio();

            return unPE.listarPrestamoDeEspacio();
        }
    }
}
