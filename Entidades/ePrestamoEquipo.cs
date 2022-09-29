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
        public string equipos { get; set; }
    }
}
