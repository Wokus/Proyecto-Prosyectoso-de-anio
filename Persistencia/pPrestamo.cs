using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pPrestamo : clsPersistencia
    {

        public DataTable listarPrestamo()
        {
            String consultaSQL = "SELECT * FROM prestamo, prestamoDeEquipo, prestamoDeEspacio, prestamoEspontaneo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

    }
}
