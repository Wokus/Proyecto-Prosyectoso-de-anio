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
        public int cantidadDias { get; set; }
        public String fechaRetiro { get; set; }
        public String horaRetiro { get; set; }
        public String fechaDevolucion { get; set; }
        public String horaDevolucion { get; set; }
        public String estado { get; set; }
        public String alumnoRespon { get; set; }
        public String profeRespon { get; set; }

    }
}
