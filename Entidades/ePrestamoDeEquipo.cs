using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamoDeEquipo : ePrestamo
    {
        public int id_Prestamo { get; set; }
        public int prioridad { get; set; }
        public string ejercicio { get; set; }

    }
}
