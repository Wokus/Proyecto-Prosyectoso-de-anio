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
            int Alumno = 0;
            int Primero = 0;
            int Segundo = 0;
            int Tercero = 0;
            bool token = true;

            eResponsable elAdmin = new eResponsable();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM solicitante WHERE solicitante.ci = '" + unPR.ci + "';";


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
                    Alumno = 1;

                }
                if (unPR.curso == "Primero")
                {
                    Primero = 1;
                }
                if (unPR.curso == "Segundo")
                {
                    Segundo = 1;
                }
                if (unPR.curso == "Tercero")
                {
                    Tercero = 1;
                }
                string consultaSQL3 = "INSERT INTO persona VALUES('" + unPR.ci + "','" + unPR.nombre + "','" + unPR.apellido + "');";
                ejecutarSQL(consultaSQL3);
                string consultaSQL2 = "INSERT INTO solicitante VALUES('" + unPR.ci + "','" + unPR.curso + "','" + unPR.tipo + "');";
                ejecutarSQL(consultaSQL2);
            }
            return token;
        }

        public DataTable listarResponsable()
        {     
            string consultaSQL = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci;";
            DataTable dt = listarAlgo(consultaSQL);
            return dt;
        }



        public DataTable listarResponsabletipoP()
        {
            string consultaSQL = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE tipo = 'Profesor';";
            DataTable dat = listarAlgo(consultaSQL);
            return dat;
        }

        public DataTable listarResponsabletipoA()
        {
            string aaaaaaaaa = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE tipo = 'Alumno';";
            DataTable hee = listarAlgo(aaaaaaaaa);
            return hee;
        }

        public DataTable listarResponsableCP()
        {
            string CP = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Audiovisual 1';";
            DataTable heehee = listarAlgo(CP);
            return heehee;
        }

        public DataTable listarResponsableCS()
        {
            string CS = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Audiovisual 2';";
            DataTable boys = listarAlgo(CS);
            return boys;
        }

        public DataTable listarResponsableCT()
        {
            string CT = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Audiovisual 3';";
            DataTable women = listarAlgo(CT);
            return women;
        }
        public object listarResponsableTT()
        {
            string FT = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Tecnicatura 1';";
            DataTable finest = listarAlgo(FT);
            return finest;
        }

        public object listarResponsableTTT()
        {
            string TT = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Tecnicatura 2';";
            DataTable tec = listarAlgo(TT);
            return tec;
        }

        public object listarResponsableFT()
        {
            string TTT = "SELECT persona.ci,nombre,apellido,curso,tipo FROM persona INNER JOIN solicitante on persona.ci = solicitante.ci WHERE Curso = 'Finest';";
            DataTable tec2 = listarAlgo(TTT);
            return tec2;
        }
        public eResponsable bajaResponsable(string EliminarRes)
        {
            eResponsable elAdmin = new eResponsable();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM solicitante WHERE solicitante.ci = '" + EliminarRes + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearResponsable(fila);

            }

            if (elAdmin != null)
            {
                string consultaSQL2 = "DELETE FROM solicitante WHERE solicitante.ci = '" + EliminarRes + "';";
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
            string consultaSQL = "SELECT * FROM solicitante WHERE solicitante.ci = '" + oldCi + "';";

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
                consultaSQL = "SELECT * FROM solicitante WHERE solicitante.ci = '" + unDR.ci + "';";

                fila = ejecutarYdevolver(consultaSQL);
                ejecutarSQL(consultaSQL);
                while (fila.Read())
                {
                    elAdmin = recrearResponsable(fila);
                }


                if (elAdmin == null)
                {
                    String consultaFK = "ALTER TABLE solicitante DROP FOREIGN KEY fK_Solicitante_persona;";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE realiza DROP FOREIGN KEY fk_realiza_solicitante;";
                    ejecutarSQL(consultaFK);

                    String consultaSQL2 = "UPDATE persona SET ci ='" + unDR.ci
                    + "',nombre = '" + unDR.nombre + "', apellido = '" + unDR.apellido + "' WHERE persona.ci = '" + oldCi + "';";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE solicitante SET ci = '" + unDR.ci
                    + "', curso = '" + unDR.curso + "', tipo = '" + unDR.tipo + "' WHERE solicitante.ci = '" + oldCi + "';";
                    elAdmin = token;
                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE realiza SET ci_solicitante = '" + unDR.ci + "'WHERE ci_solicitante ='" + oldCi + "';";
                    ejecutarSQL(consultaSQL2);

                    consultaFK = "ALTER TABLE solicitante ADD CONSTRAINT fK_solicitante_persona FOREIGN KEY (ci) REFERENCES persona (ci);";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE realiza ADD CONSTRAINT fk_realiza_solicitante FOREIGN KEY(ci_Solicitante) REFERENCES solicitante(ci);";
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

