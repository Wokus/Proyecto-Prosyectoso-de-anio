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
    public class pPrestamoEspontaneo : pPrestamo
    {
        public int altaEspacioExpontaneo(ePrestamoEspontaneos unPRESP)
        {
            String[] equipos = unPRESP.unE.nombre.Split(',');
            String consultaSQL;
            
                int token = verificarEstado(unPRESP.alumnoResponsable.ci, unPRESP.profeResponsable.ci, equipos);
            if (token == 0 || token == 3)
            {
                int id = calculoDeId();
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRESP.fechaSolicitada + "','" + unPRESP.fechaRetiro + "','" + unPRESP.horaRetiro + "','" + unPRESP.fechaDevolucion + "','" + unPRESP.estado + "','" + "0" + "','" + unPRESP.genuinoDiaDevolucion + "','" + unPRESP.ejercicio + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `prestamoEspontaneo` VALUES('" + id + "');";
                ejecutarSQL(consultaSQL);
                for (int i = 0; i < equipos.Length; i++)
                {
                    consultaSQL = "INSERT INTO `obtieneequipoprestamoespontaneo` VALUES('" + id + "','" + equipos[i] + "');";
                    ejecutarSQL(consultaSQL);
                }
                if (token == 0)
                {
                    consultaSQL = "INSERT INTO realiza VALUES ('" + unPRESP.alumnoResponsable.ci + "','" + id + "');";
                    ejecutarSQL(consultaSQL);
                }

                consultaSQL = "INSERT INTO profesorPrestamo VALUES ('" + unPRESP.profeResponsable.ci + "','" + id + "');";
                ejecutarSQL(consultaSQL);
            }       
            return token;
        }

        public int recrearIdPrestamo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }

        public DataTable listarPrestamoEspontaneo()
        {
            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion FROM prestamoEspontaneo INNER JOIN prestamo ON prestamoEspontaneo.id_Prestamo=prestamo.id;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorFechaAR()
        {

            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo ORDER BY prestamo.fechaSolicitada ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo ORDER BY prestamo.fechaSolicitada DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorEstado(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo WHERE estado='" + tuHermana + "' ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoEspontaneoPorFechaARE(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo WHERE estado='" + tuHermana + "' ORDER BY ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoEspontaneoPorFechaRAE(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado='" + tuHermana + "' ORDER BY DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorPrioridad(string prioridad)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo ORDER BY prioridad " + prioridad + ";";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorPrioridadE(string tuHermana, string prioridad)
        {

            string consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio FROM prestamo INNER JOIN prestamoEspontaneo ON prestamo.id = prestamoEspontaneo.id_Prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo WHERE estado = '" + tuHermana + "' ORDER BY prioridad " + prioridad + " ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public int bajaPrestamoEspontaneo(int idPrestamo)
        {

            string consultaSQL = "DELETE FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + " ;";
            ejecutarSQL(consultaSQL);
            return idPrestamo;

        }

        public int modificacionPrestamo(ePrestamoEspontaneos unPRESP)
        {
            int token = 69;
            string consultaSQL;
            string estado = "ICKKCK";
            int existencia = corroborarExistencia(unPRESP.id, "espo");
            if (existencia == 3)
            {
                

                String[] equipos = unPRESP.unE.nombre.Split(',');
                token = verificarEstado(unPRESP.alumnoResponsable.ci, unPRESP.profeResponsable.ci, equipos);
                if (token == 0)
                {
                    //FK down

                    string consultaFK = "ALTER TABLE prestamoEspontaneo DROP FOREIGN KEY fK_prestamoEspontaneo_prestamo;";
                    ejecutarSQL(consultaFK);

                    //FK down

                    string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada ='" + unPRESP.fechaSolicitada + "',"
                                + " fechaRetiro = '" + unPRESP.fechaRetiro + "', horaRetiro = '" + unPRESP.horaRetiro + "', fechaDevolucion = '" + unPRESP.fechaDevolucion + "', fechaGenuinaDevolucion = '" + unPRESP.genuinoDiaDevolucion
                                + "', estado ='" + unPRESP.estado + "', prioridad = '" + unPRESP.prioridad + "', ejercicio = '" + unPRESP.ejercicio + "'  WHERE prestamo.id = '" + unPRESP.id + "' ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL = "DELETE FROM `obtieneequipoprestamoespontaneo` WHERE id_PrestamoEspontaneo  ='" + unPRESP.id + "';";
                    ejecutarSQL(consultaSQL);
                    for (int i = 0; i < equipos.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `obtieneequipoprestamoespontaneo` VALUES('" + unPRESP.id + "','" + equipos[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    bool tokenPrestamoAlumno = corroborarPrestamoConAlumno(unPRESP.id);

                    consultaSQL = "DELETE FROM `realiza` WHERE id_prestamo ='" + unPRESP.id + "' ;";
                    ejecutarSQL(consultaSQL);
                    
                        consultaSQL = "INSERT INTO `realiza` VALUES('" + unPRESP.alumnoResponsable.ci + "','" + unPRESP.id + "');";
                        ejecutarSQL(consultaSQL);
                    
                    consultaSQL = "DELETE FROM `profesorprestamo` WHERE id_prestamo ='" + unPRESP.id + "' ;";
                    ejecutarSQL(consultaSQL);

                    consultaSQL = "INSERT INTO `profesorprestamo` VALUES('" + unPRESP.profeResponsable.ci + "','" + unPRESP.id + "');";
                    ejecutarSQL(consultaSQL);

                    //FK up
                    consultaFK = "ALTER TABLE prestamoEspontaneo ADD CONSTRAINT fK_prestamoEspontaneo_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
                    ejecutarSQL(consultaFK);
                    //FK up

                }


            }

            

      
            return token;

        }
        private bool corroborarEquipos(String[] equipos)
        {
            bool tokenEquipo = true;
            for (int i = 0; i < equipos.Length; i++)
            {

                string consultaSQL = "SELECT * FROM `equipo` WHERE `id` = '" + equipos[i] + "';";
                MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {

                }
                else
                {
                    tokenEquipo = false;
                    break;
                }
            }
            return tokenEquipo;

        }
        private int verificarEstado(string alumno, string profe, string[] equipos )
        {
            int token = 0;
            bool tokenAlumno = true;
            bool tokenEquipo = corroborarEquipos(equipos);
            if (tokenEquipo == true)
            {
                if (alumno == "_.___.___-_")
                {
                    tokenAlumno = false;
                }
                string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + profe + "' AND `tipo` = 'Profesor';";
                MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    if (tokenAlumno == true)
                    {
                        consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + alumno + "' AND `tipo` = 'Alumno';";
                        fila = ejecutarYdevolver(consultaSQL);
                        if (fila.Read())
                        {

                        }
                        else { token = 4; }
                    }
                    else { token = 3; }
                }
                else { token = 2; }

            }
            else { token = 1; }
            return token;
        }



    }
}
