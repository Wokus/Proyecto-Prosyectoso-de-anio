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
    public class pEspacio : clsPersistencia
    {

        public DataTable listarEspacio()
        {

            string consultaSQL = "SELECT * FROM espacio;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public eEspacio bajaEspacio(string text)
        {
            eEspacio elAdmin = new eEspacio();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM espacio WHERE espacio.nro='" + text + "';";

            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearespacio(fila);

            }

            if (elAdmin != null)
            {

                string consultaSQL2 = "SELECT * FROM espacio WHERE espacio.nro='" + text + "';";
                ejecutarSQL(consultaSQL2);
            }
            return elAdmin;
        }

        public int modificarEspacio(eEspacio unE, String nmroMod)
        {
            int token = 0;
            bool tokenEx = queNoEsista(Convert.ToInt32(nmroMod));
            if (tokenEx == true)
            {
                tokenEx = queNoEsista(Convert.ToInt32(unE.numeroEspacio));
                if (tokenEx == false)
                {
                    //Sacar FK
                    String consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio DROP FOREIGN KEY fK_obtieneEspaciosPrestamoDeEspacio_espacio;";
                    ejecutarSQL(consultaFK);
                    //Sacar FK

                    String consultaSQL = "UPDATE espacio SET nro = '" + unE.numeroEspacio + "', `nombre` = '" + unE.nombreEspacio + "' WHERE nro = '" + nmroMod + "' ;";
                    ejecutarSQL(consultaSQL);

                    consultaSQL = "UPDATE obtieneEspaciosPrestamoDeEspacio SET nro_Espacio = '" + unE.numeroEspacio
                    + "' WHERE nro_Espacio = '" + nmroMod + "' ;";
                    ejecutarSQL(consultaSQL);

                    //Poner FK
                    consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio ADD CONSTRAINT fK_obtieneEspaciosPrestamoDeEspacio_espacio FOREIGN KEY(nro_Espacio) REFERENCES espacio(nro);";
                    ejecutarSQL(consultaFK);
                    //Poner FK

                }else { token = 2; }
            }else { token = 1; }
            return token;
        }


        public eEspacio recrearespacio(MySqlDataReader fila)
        {
            eEspacio unEspacio = new eEspacio();
            unEspacio.numeroEspacio = fila.GetString("nro");
            unEspacio.nombreEspacio = fila.GetString("nombre");

            return unEspacio;
         }

        public bool altaEspacio(eEspacio unE)
        {
            bool token = queNoEsista(Convert.ToInt32(unE.numeroEspacio));
            if (token == false)
            {
                string consultaSQL = "INSERT INTO espacio VALUES('" + unE.numeroEspacio + "', '" + unE.nombreEspacio + "');";
                ejecutarSQL(consultaSQL);

            }else
            {

                token = true;

            }
          

            return token;
        }

        public bool queNoEsista(int numeroEspacio)
        {

            bool token = false;

            string consultaSQL = "SELECT * FROM `espacio` WHERE `nro` = '" + numeroEspacio + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {

                token = true;

            }

            return token;

        }
    }
}
