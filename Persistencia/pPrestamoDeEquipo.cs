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
    public class pPrestamoDeEquipo : clsPersistencia
    {

        public DataTable listarPrestamoDeEquipo()
        {
            String consultaSQL = "SELECT * FROM prestamoDeEquipo EQUI JOIN prestamo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

    }
}
