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
    public class dPrestamoEquipo
    {
        public int altaPrestamo(ePrestamoEquipo unPRE)
        {
            pPrestamoEquipo unPPRE = new pPrestamoEquipo();


            int token = unPPRE.altaPrestamo(unPRE);
            return token;
        }


        public int modificacionPrestamo(ePrestamoEquipo unEPE)
        {

            pPrestamoEquipo unPPE = new pPrestamoEquipo();

            int confirmacion = unPPE.modificacionPrestamo(unEPE, Convert.ToString(unEPE.id));
            return confirmacion;
            
        }

        public DataTable listarPrestamoDeEquipo()
        {

            pPrestamoEquipo unPE = new pPrestamoEquipo();

            return unPE.listarPrestamoDeEquipo();
        }
    }
}
