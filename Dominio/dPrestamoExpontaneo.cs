using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

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
    }
}
