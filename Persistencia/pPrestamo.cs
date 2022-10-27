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
            String consultaSQL = "SELECT * FROM prestamo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }
        public int bajaPrestamo(int idPrestamo)
        {
            int id1 = 0;
            int id2 = 0;
            int id3 = 0;
            int id5 = 0;
            string consultaSQL2;
            string consultaSQL = "SELECT * FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            while (fila.Read())
            {

                id1 = (idPrestamo);
                id1 = recrearIdPrestamo(fila);

            }
            if (id1 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + " ;";
                ejecutarSQL(consultaSQL);

            }

            consultaSQL = "SELECT * FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila2 = ejecutarYdevolver(consultaSQL);
            while (fila2.Read())
            {

                id2 = (idPrestamo);
                id2 = recrearIdPrestamo(fila2);

            }
            if (id2 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);

            }

            consultaSQL = "SELECT * FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila3 = ejecutarYdevolver(consultaSQL);
            while (fila3.Read())
            {

                id3 = (idPrestamo);
                id3 = recrearIdPrestamo(fila3);

            }
            if (id3 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);

            }

            consultaSQL = "SELECT * FROM prestamo WHERE prestamo.id = " + idPrestamo + ";";
            MySqlDataReader fila5 = ejecutarYdevolver(consultaSQL);
            while (fila5.Read())
            {

                id5 = (idPrestamo);
                id5 = recrearIdPrestamo(fila5);

            }
            if (id5 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamo WHERE prestamo.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);

            }

            return idPrestamo;
        }



        public bool corroborarPrestamoConAlumno(int idPrestamo)
        {
            bool tokenPrestamoAlumno = true;
            string consultaSQL = "SELECT * FROM `realiza` WHERE `id_Prestamo ` = '" + idPrestamo + "';";

            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {

            }
            else
            {
                tokenPrestamoAlumno = false;

            }

            return tokenPrestamoAlumno;
        }
        public int corroborarExistencia(int idPrestamo, String tipo)
        {
            int token = 0;
            string consultaSQL = "SELECT * FROM `prestamodeequipo` WHERE `id_Prestamo` = '" + idPrestamo + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                token = 1;
            }

            if (token == 0)
            {
                 consultaSQL = "SELECT * FROM `prestamodeespacio` WHERE `id_Prestamo` = '" + idPrestamo + "';";
                 fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    token = 2;
                }
            }

            if (token == 0)
            {
                consultaSQL = "SELECT * FROM `prestamoespontaneo` WHERE `id_Prestamo` = '" + idPrestamo + "';";
                fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    token = 3;
                }

            
            }
            if (token == 1 && tipo != "equi" )
            {
                token = 10;
            }
            if (token == 2 && tipo != "espa")
            {
                token = 20;
            }
            if (token == 3 && tipo != "espo")
            {
                token = 30;
            }
            return token;

        }
        public int calculoDeId()
        {
            int id = 0;
            int idOcupado = 0;
            while (idOcupado == id)
            {
                id++;
                string consultaSQL = "SELECT * FROM `prestamo` WHERE `prestamo`.`id` = '" + id + "'; ";
                MySqlDataReader filaid = ejecutarYdevolver(consultaSQL);
                if (filaid.Read())
                {
                    idOcupado = recrearIdPrestamo(filaid);
                }
            }
            return id;
        }
        public int recrearIdPrestamo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }



    }
}
