using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Persistencia
{
    public class pEspacio : clsPersistencia
    {

        public DataTable listarEspacio()
        {

            string consultaSQL = "SELECT * FROM espacio;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

    }
}
