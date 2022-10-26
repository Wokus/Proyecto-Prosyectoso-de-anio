using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamoEquipo : ePrestamo
    {
  
        public int prioridad { get; set; }
        public string transporte { get; set; }
        public string ejercicio { get; set; }
        public string locacion { get; set; }
     
        public eEquipo unE { get; set; }


        public ePrestamoEquipo(int idPrestamo, int prioridad, string transporte, string ejercicio, string locacion, string equipo)
        {
            

        }

        public ePrestamoEquipo()
        {


        }

    }
}
