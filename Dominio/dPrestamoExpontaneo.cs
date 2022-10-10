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
        public bool altaPrestamoEspacio(ePrestamoEspontaneos unPRESP)
        {

          pPrestamoExpontaneo unPPREX = new pPrestamoExpontaneo();
            bool tokenEquipo = unPPREX.altaEspacioExpontaneo(unPRESP);

            return tokenEquipo;
            


            
        }

        public int bajaPrestamoEspontaneo(int idPrestamo)
        {
            pPrestamoExpontaneo unPPEX = new pPrestamoExpontaneo();

            return unPPEX.bajaPrestamoEspontaneo(idPrestamo);
        }

        public bool modificacionPrestamo(ePrestamoEspontaneos unEPEX, String IdPrestamo)
        {

            pPrestamoExpontaneo unPPEX = new pPrestamoExpontaneo();

            bool confirmacion = unPPEX.modificacionPrestamo(unEPEX, IdPrestamo);
            return confirmacion;

        }

        public DataTable listarPrestamoEspontaneo()
        {

            pPrestamoExpontaneo unPE = new pPrestamoExpontaneo();

            return unPE.listarPrestamoEspontaneo();
        }
    }
}
