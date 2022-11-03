using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamoEspontaneos : ePrestamo
    {
        public String idEquipo { get;  set; }
        public eEquipo unE  { get; set; }


    }
}
