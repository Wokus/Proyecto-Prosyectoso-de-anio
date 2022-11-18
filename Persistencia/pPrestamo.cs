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
            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorFechaAR()
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo ORDER BY fechaSolicitada ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo ORDER BY fechaSolicitada DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorEstado(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado= '" + tuHermana + "' ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaARE(String tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado = '" + tuHermana + "' ORDER BY fechaSolicitada ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorFechaRAE(String tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado = '" + tuHermana + "' ORDER BY fechaSolicitada DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorPrioridad(string prioridad)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo ORDER BY prioridad " + prioridad + ";";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorPrioridadE(string tuHermana, string prioridad)
        {

            string consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado = '" + tuHermana + "' ORDER BY prestamo.prioridad " + prioridad + " ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public int bajaPrestamo(int idPrestamo)
        {
            int token = 0;
            string consultaSQL2;
            string consultaSQL = "SELECT * FROM prestamo WHERE prestamo.id = " + idPrestamo + ";";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);

            if (fila.Read())
            {
                consultaSQL = "DELETE FROM realiza WHERE id_Prestamo  = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL);
                consultaSQL = "DELETE FROM profesorPrestamo WHERE id_Prestamo  = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL);

                consultaSQL = "SELECT * FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + ";";
                fila = ejecutarYdevolver(consultaSQL);
               
                //Prestamo de equipo
                if (fila.Read())
                {
                    consultaSQL = "DELETE FROM tiene WHERE id_PrestamoDeEquipo  =" + idPrestamo + " ;" ;
                    ejecutarSQL(consultaSQL);
                    consultaSQL = "DELETE FROM prestamodeequipolocacion WHERE id_PrestamoDeEquipo  =" + idPrestamo + " ;";
                    ejecutarSQL(consultaSQL);

                    consultaSQL = "DELETE FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + " ;";
                    ejecutarSQL(consultaSQL);
                }
                consultaSQL = "SELECT * FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
                MySqlDataReader fila2 = ejecutarYdevolver(consultaSQL);
                //Prestamo de equipo

                //Prestamo de espacio
                if (fila2.Read())
                {
                    consultaSQL = "DELETE FROM obtieneespaciosprestamodeespacio WHERE id_PrestamoDeEspacio  =" + idPrestamo + " ;";
                    ejecutarSQL(consultaSQL);
                    consultaSQL = "DELETE FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
                    ejecutarSQL(consultaSQL);
                }
                //Prestamo de espacio

                consultaSQL = "SELECT * FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
                MySqlDataReader fila3 = ejecutarYdevolver(consultaSQL);

                //Prestamo espontaneo
                if (fila3.Read())
                {
                    consultaSQL = "DELETE FROM obtieneequipoprestamoespontaneo WHERE id_PrestamoEspontaneo  =" + idPrestamo + " ;";
                    ejecutarSQL(consultaSQL);
                    consultaSQL = "DELETE FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
                    ejecutarSQL(consultaSQL);
                }
                //Prestamo espontaneo
                consultaSQL = "DELETE FROM prestamo WHERE prestamo.id = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL);
                token = 1;
            }

            return token;
        }
        public bool corroborarPrestamoConAlumno(int idPrestamo)
        {
            bool tokenPrestamoAlumno = true;
            string consultaSQL = "SELECT * FROM `realiza` WHERE `id_Prestamo` = '" + idPrestamo + "';";

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
          /*  if (token == 1 && tipo != "equi" )
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
            }*/
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
        public ePrestamo recrearPrestamo(string id)
        {

            ePrestamo unPRE = new ePrestamo();
            String consultaSQL = "Select * FROM prestamo WHERE id = '" + id + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
           if(fila.Read())
            {

            
            unPRE.id = fila.GetInt32("id");
            unPRE.fechaSolicitada= fila.GetString("fechaSolicitada");
            unPRE.fechaRetiro = fila.GetString("fechaRetiro");
            unPRE.horaRetiro = fila.GetString("horaRetiro");
            unPRE.fechaDevolucion = fila.GetString("fechaDevolucion");
            unPRE.estado = fila.GetString("estado");
            unPRE.genuinoDiaDevolucion = fila.GetString("fechaGenuinaDevolucion");

            }
            consultaSQL = "Select * FROM realiza WHERE id_Prestamo = '" + id + "';";

            fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                eResponsable alumno = new eResponsable();
            alumno.ci = fila.GetString("ci_Solicitante");


            consultaSQL = "Select * FROM profesorPrestamo WHERE id_Prestamo = '" + id + "';";
                unPRE.alumnoResponsable = alumno;
            }

            fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                eResponsable profe = new eResponsable();
            profe.ci = fila.GetString("ci_Solicitante");

            
            unPRE.profeResponsable = profe;
            }
            return unPRE;
        }
        public int calculoPrioridad(string curso, String actividad)
        {
            int prioridad = 0;

            if (actividad == "Rodaje")
            {
                prioridad = 7;
            }
            else // osea si es == Practica de Rodaje
            {
                prioridad = 1;
            }

            if (curso == "Audiovisual 1")
            {
                prioridad = prioridad + 1;
            }
            if (curso == "Audiovisual 2")
            {
                prioridad = prioridad + 2;
            }
            if (curso == "Finest")
            {
                prioridad = prioridad + 3;
            }
            if (curso == "Audiovisual 3")
            {
                prioridad = prioridad + 4;
            }
            if (curso == "Tecnicatura 1")
            {
                prioridad = prioridad + 5;
            }
            if (curso == "Tecnicatura 2")
            {
                prioridad = prioridad + 6;
            }
            return prioridad;
        }
        public String recrearCurso(String alumnoCI)
        {
            String consultaSQL = "Select solicitante.curso FROM solicitante WHERE solicitante.ci = '" + alumnoCI + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            fila.Read();

            String curso = fila.GetString("curso");

            return curso;
        }

    }
}

