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
    public class pPrestamoDeEspacio :clsPersistencia
    {

        public DataTable listarPrestamoDeEspacio()
        {
            String consultaSQL = "SELECT * FROM prestamoDeEspacio;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

    }
}
