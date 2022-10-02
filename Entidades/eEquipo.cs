using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eEquipo
    {
        public int id { get; set; } 
        public String nombre { get; set; }
        public String numeroSerie { get; set; }
        public String estado { get; set; }
        public String fechaIngreso { get; set; }
        public String asegurado { get; set; }
        public String precio { get; set; }
        public String tipo { get; set; }
        public String observacion { get; set; }
        public int stock { get; set; }

    }
}
