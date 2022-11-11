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
                elAdmin = recrearResponsable(fila);

            }

            if (elAdmin != null)
            {



            }
        }

        public eEspacio recrearResponsable(MySqlDataReader fila)
        {
            eEspacio unEspacio = new eEspacio();
            unEspacio.numeroEspacio = fila.GetString();

         }

        public int altaEspacio(eEspacio unE, int troken)
        {
            bool token = queNoEsista(unE.numeroEspacio);

            troken = 0;

            if (token = false)
            {
                string consultaSQL = "INSERT INTO espacio VALUES('" + unE.numeroEspacio + "', '" + unE.nombreEspacio + "');";

                ejecutarSQL(consultaSQL);

            }else
            {

                troken = 1;

            }
          

            return troken;
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
            else
            {

            }

            return token;

        }
    }
}
