using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pRotura : clsPersistencia
    {
        public eEquipo recrearRot(string id)
        {

            eEquipo unEqui = new eEquipo();
            String mySQLcommand = "Slelect nombre FROM equipo WERE id ='" + id + "';";
            MySqlDataReader fila = ejecutarYdevolver(mySQLcommand);
            if (fila.Read())
            {
                unEqui.nombre = fila.GetString("nombre");
            }
            return unEqui;
        }

        public DataTable ListarRot()
        {
            String mySQLcommand = "SELECT presenta.id_Equipo AS idEquipo, equipo.nombre AS Equipo,rotura.id AS idRotura,rotura.detalleDesperfecto AS Descripcion,rotura.id_Prestamo AS idPrestamo, profesorprestamo.ci_Solicitante AS Profesor,realiza.ci_Solicitante AS Alumno FROM `rotura` INNER JOIN presenta ON presenta.id_rotura = rotura.id INNER JOIN equipo ON presenta.id_Equipo = equipo.id LEFT JOIN realiza ON realiza.id_Prestamo = rotura.id_Prestamo LEFT JOIN profesorprestamo ON profesorprestamo.id_Prestamo = rotura.id_Prestamo;";
            DataTable dt = listarAlgo(mySQLcommand);
            return dt;
        }
        public int calculoDeId()
        {
            int id = 0;
            int idOcupado = 0;
            while (idOcupado == id)
            {
                id++;
                string consultaSQL = "SELECT * FROM `rotura` WHERE `rotura`.`id` = '" + id + "'; ";
                MySqlDataReader filaid = ejecutarYdevolver(consultaSQL);
                if (filaid.Read())
                {
                    idOcupado = recrearId(filaid);
                }
            }
            return id;
        }

        public int modificacionRotura(eEquipo unEq, string prestamoId)
        {
            int token = 69;
            string consultaSQL = "SELECT * FROM `rotura` WHERE `rotura`.`id` = '" + unEq.id + "'; ";
            MySqlDataReader filaid = ejecutarYdevolver(consultaSQL);
            if (filaid.Read())
            {
                token = corroborarEstado(unEq, prestamoId);
                if (token == 0)
                {
                    consultaSQL = "UPDATE rotura SET id = '" + unEq.rotu.idRotura + "', detalleDesperfecto = '" + unEq.rotu.descripcion + "', id_Prestamo = '" + prestamoId
                     + "' WHERE rotura.id = '" + unEq.rotu.idRotura + "' ;";
                    ejecutarSQL(consultaSQL);

                     consultaSQL = "DELETE FROM `presenta` WHERE id_rotura = '" + unEq.rotu.idRotura + "'; ";
                     filaid = ejecutarYdevolver(consultaSQL);
                    consultaSQL = "INSERT INTO `presenta` VALUES('" + unEq.id + "','" + unEq.rotu.fecha + "','" + unEq.rotu.idRotura + "');";
                    filaid = ejecutarYdevolver(consultaSQL);
                }

            }

            return token;
        }

        private int recrearId(MySqlDataReader filaid)
        {
            int id = filaid.GetInt32("id");


            return id;
        }

        public int altaRotura(eEquipo unEq, String prestamoId)
        {
            int token = corroborarEstado(unEq, prestamoId);
            if (token == 0)
                {
                int id = calculoDeId();
                String consultaSQL = "INSERT INTO `rotura` VALUES('" + id + "','" + unEq.rotu.descripcion + "','" + prestamoId + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `presenta` VALUES('" + unEq.id + "','" + unEq.rotu.fecha + "','" + id + "');";
                ejecutarSQL(consultaSQL);
            }
            return token;
        }
        private int corroborarEstado(eEquipo unEq, String prestamoId)
        {
            int token = 0;
            String consultaSQL = "SELECT * FROM `equipo` WHERE `equipo`.`id` = '" + unEq.id + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                 consultaSQL = "SELECT * FROM `prestamo` WHERE `prestamo`.`id` = '" + prestamoId + "';";
                 fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {


                }else { token = 2; }
            }
            else { token = 1; }
            
            return token;
        }
        
        public bool bajaRatura(string id)
        {
            bool token = true;
            String mySQLcommand = "Slelect * FROM rotura WERE id ='" + id + "';";
            MySqlDataReader fila = ejecutarYdevolver(mySQLcommand);
            if (fila.Read())
            {
                mySQLcommand = "DELETE FROM rotura WHERE id = " + id + ";";
                fila = ejecutarYdevolver(mySQLcommand);
                if (fila.Read())
                {

                }else { token = false ; }
            }
            else token = false;
            return token;
        }
    }
}
