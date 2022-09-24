using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ePrestamo
    {

      public int id { get; set; }
      public string fechaSolicitada { get; set; }
      public string cantidadDias { get; set; }
      public string fechaRetiro { get; set; }
      public string fechaDevolucion { get; set; }
      public string horaDevolucion { get; set; }
      public string armado { get; set; }
      public string levantado { get; set; }
      public string cancelado { get; set; }
      public string devuelto { get; set; }
      public string profesorResponsable { get; set; }
      public string alumnoResponsable { get; set; }

    }
}
