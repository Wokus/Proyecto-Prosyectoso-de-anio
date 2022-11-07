using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pEspacio : clsPersistencia
    {
        public int altaEspacio(eEspacio unE)
        {
            int token = 0;
            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `espacio` WHERE nro = '" + unE.nombreEspacio+ "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);

            while (fila.Read())
            {
                consultaSQL = "INSERT INTO espacio VALUES('" + unE.numeroEspacio + "','" + unE.nombreEspacio + "');";
                fila = ejecutarYdevolver(consultaSQL);

            }
    
            return token;
        }
    }
}
