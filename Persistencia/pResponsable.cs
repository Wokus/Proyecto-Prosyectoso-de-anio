using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;


namespace Persistencia
{
   public class pResponsable : clsPersistencia
    {
        public bool altaResponsable(eResponsable unPR)
        {
            int profesor = 0;
            int estudiante = 0;
            bool token = true;

            eResponsable elAdmin = new eResponsable();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + unPR.ci + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            while (fila.Read())
            {
                token = false;
            }

            if (token == true)
            {
                if (unPR.tipo == "Profesor")
                {
                    profesor = 1;

                }
                if (unPR.tipo == "Estudiante")
                {
                    estudiante = 1;

                }
                string consultaSQL2 = "INSERT INTO solicitante VALUES('" + unPR.ci + "','" + unPR.nombre + "','" + unPR.apellido + "');";
                ejecutarSQL(consultaSQL2);

                consultaSQL2 = "INSERT INTO solicitante VALUES('" + unPR.ci + "','" + unPR.curso + "','" + unPR.tipo + "');";
                ejecutarSQL(consultaSQL2);
            }
            return token;
        }

        public DataTable listarResponsable()
        {
            {
                String consultaSQL = "SELECT persona.ci, persona.nombre, persona.apellido, solicitante.curso, solicitante.tipo FROM persona RIGHT JOIN `solicitante` ON persona.ci = solicitante.ci; ";

                DataTable dt = listarAlgo(consultaSQL);

                return dt;
            }
        }

        public eResponsable bajaResponsable(string EliminarRes)
        {
            eResponsable elAdmin = new eResponsable();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM ` solicitante` WHERE `solicitante`.`ci` = '" + EliminarRes + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearResponsable(fila);

            }

            if (elAdmin != null)
            {
                string consultaSQL2 = "DELETE FROM solicitante WHERE ` solicitante`.`ci` = '" + EliminarRes + "';";
                ejecutarSQL(consultaSQL2);
                consultaSQL2 = "DELETE FROM persona WHERE `persona`.`ci` = '" + EliminarRes + "';";
                ejecutarSQL(consultaSQL2);

            }
            return elAdmin;
        }

        public eResponsable recrearResponsable(MySqlDataReader fila)
        {
            eResponsable unResponsable = new eResponsable();
            unResponsable.tipo = fila.GetString("tipo");
            unResponsable.curso = fila.GetString("curso");
            unResponsable.ci = fila.GetString("ci");


            return unResponsable;
        }
        public eResponsable modificarResponsable(eResponsable unDR, string oldCi)
        {
            eResponsable elAdmin = new eResponsable();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.`ci` = '" + oldCi + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearResponsable(fila);
            }

            if (elAdmin != null)
            {
               eResponsable token = new eResponsable();
                token = elAdmin;

                elAdmin = null;
                consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + unDR.ci + "';";


                fila = ejecutarYdevolver(consultaSQL);
                ejecutarSQL(consultaSQL);
                while (fila.Read())
                {
                    elAdmin = recrearResponsable(fila);
                }


                if (elAdmin == null)
                {

                    String consultaFK = "ALTER TABLE usuario DROP FOREIGN KEY fK_Solicitante_persona;";
                    ejecutarSQL(consultaFK);

                    String consultaSQL2 = "UPDATE `persona` SET `ci` ='" + unDR.ci
                    + "', `nombre` = '" + unDR.nombre + "', `apellido` = '" + unDR.apellido + "' WHERE `persona`.`ci` = '" + oldCi + "';";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE `solicitante` SET `ci` = '" + unDR.ci
                    + "', `curso` = '" + unDR.curso + "', `tipo` = '" + unDR.tipo + "' WHERE `solicitante`.`ci` = '" + oldCi + "';";
                    elAdmin = token;
                    ejecutarSQL(consultaSQL2);


                    consultaFK = "ALTER TABLE usuario ADD constraint fK_solicitante_persona  FOREIGN KEY (ci) REFERENCES persona(ci);";
                    ejecutarSQL(consultaFK);

                }
            }
            else
            {
                elAdmin = null;
            }
            return elAdmin;
        }

    }
    }

