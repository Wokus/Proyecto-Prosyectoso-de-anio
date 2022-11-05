using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamo
    {

        public int id { get; set; }
        public String fechaSolicitada { get; set; }
        public int prioridad { get; set; }
        public String fechaRetiro { get; set; }
        public String horaRetiro { get; set; }
        public String fechaDevolucion { get; set; }
        
        public String estado { get; set; }
        
        public eResponsable alumnoResponsable { get; set; }
        public eResponsable profeResponsable { get; set; }
      
        public string genuinoDiaDevolucion { get; set; }
        public string ejercicio { get; set; }

    }
}
