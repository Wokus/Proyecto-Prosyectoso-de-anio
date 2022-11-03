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
    public class dPrestamoExpontaneo
    {
        public int altaPrestamoEspacio(ePrestamoEspontaneos unPRESP)
        {

          pPrestamoEspontaneo unPPREX = new pPrestamoEspontaneo();
            int token = unPPREX.altaEspacioExpontaneo(unPRESP);

            return token;
                       
        }

        public int bajaPrestamoEspontaneo(int idPrestamo)
        {
            pPrestamoEspontaneo unPPEX = new pPrestamoEspontaneo();

            return unPPEX.bajaPrestamoEspontaneo(idPrestamo);
        }

        public int modificacionPrestamo(ePrestamoEspontaneos unEPEX)
        {

            pPrestamoEspontaneo unPPEX = new pPrestamoEspontaneo();

            int confirmacion = unPPEX.modificacionPrestamo(unEPEX);
            return confirmacion;

        }

        public DataTable listarPrestamoEspontaneo()
        {

            pPrestamoEspontaneo unPE = new pPrestamoEspontaneo();

            return unPE.listarPrestamoEspontaneo();
        }
    }
}
