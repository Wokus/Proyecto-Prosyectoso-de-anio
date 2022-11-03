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
    public class pPrestamoEquipo : pPrestamo
    {
        public int altaPrestamo(ePrestamoEquipo unPRE)
        {
            string consultaSQL;
            
            int idOcupado = 0;
            

            String[] locaciones = unPRE.locacion.Split(',');
            String[] equipos = unPRE.unE.nombre.Split(',');

           
            int token = verificarEstado(unPRE.alumnoResponsable.ci, unPRE.profeResponsable.ci, equipos);


            if (token == 0)
            {
                unPRE.prioridad = 0;
                
                int id = calculoDeId();
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRE.fechaSolicitada + "','" + unPRE.fechaRetiro + "','" + unPRE.horaRetiro + "','" + unPRE.fechaDevolucion + "','" + unPRE.estado + "','" + unPRE.prioridad + "','" + unPRE.genuinoDiaDevolucion + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `prestamodeequipo` VALUES('" + id + "','" + unPRE.ejercicio + "','" + unPRE.transporte + "');";  
                ejecutarSQL(consultaSQL);
                for (int i = 0; i < locaciones.Length; i++)
                {
                    consultaSQL = "INSERT INTO `prestamodeequipolocacion` VALUES('" + id + "','" + locaciones[i] + "');";
                    ejecutarSQL(consultaSQL);
                }
                for (int i = 0; i < equipos.Length; i++)
                {
                    consultaSQL = "INSERT INTO `tiene` VALUES('" + id + "','" + equipos[i] + "');";
                    ejecutarSQL(consultaSQL);
                }
                if (unPRE.alumnoResponsable.ci != null)
                {
                    consultaSQL = "INSERT INTO realiza VALUES (" + unPRE.alumnoResponsable.ci + "," + unPRE.id + ");";
                    ejecutarSQL(consultaSQL);
                }
               
                consultaSQL = "INSERT INTO profesorPrestamo VALUES (" + unPRE.profeResponsable.ci + "," + unPRE.id + ");";
                ejecutarSQL(consultaSQL);


               


            }
            return token;
        }
       
        public DataTable listarPrestamoDeEquipo()
        {
            String consultaSQL = "SELECT prestamo.id, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, tiene.id_Equipo FROM prestamo INNER JOIN prestamoDeEquipo ON prestamo.id=prestamoDeEquipo.id_Prestamo INNER JOIN tiene ON prestamoDeEquipo.id_Prestamo=tiene.id_PrestamoDeEquipo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public int modificacionPrestamo(ePrestamoEquipo unPRE, String IdPrestamo)
        {
            int token = 69;
            string consultaSQL;
            string estado = "ICKKCK";
            int existencia = corroborarExistencia(unPRE.id,"equi");
            if (existencia == 1 )
            {
                String[] locaciones = unPRE.locacion.Split(',');
                String[] equipos = unPRE.unE.nombre.Split(',');
               token = verificarEstado(unPRE.alumnoResponsable.ci, unPRE.profeResponsable.ci, equipos);

                if (token == 0)
                {
                    //Tirar abajo as FK start
                    string consultaFK = "ALTER TABLE prestamoDeEquipo DROP FOREIGN KEY fK_prestamoDeEquipo_prestamo;";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE prestamoDeEquipoLocacion DROP FOREIGN KEY fK_prestamoDeEquipoLocacion_PrestamoDeEquipo;";
                    ejecutarSQL(consultaFK);

                    //Tirar abajo as FK final
                    string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada =" + unPRE.fechaSolicitada + ", cantidadDias ="
                                + ", fechaRetiro = " + unPRE.fechaRetiro + ", horaRetiro = " + unPRE.horaRetiro + ", fechaDevolucion = " + unPRE.fechaDevolucion + ", fechaGenuinaDevolucion = " + unPRE.genuinoDiaDevolucion
                                +
                                 ", estado =" + estado + "  WHERE prestamo.id = " + unPRE.id + " ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE prestamoDeEquipo SET prioridad = " + unPRE.prioridad + ", ejercicio = " + unPRE.ejercicio
                     + " WHERE prestamoDeEquipo.id_Prestamo = " + unPRE.id + " ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL = "DELETE FROM `prestamodeequipolocacion` WHERE prestamodeequipolocacion.id_PrestamoDeEquipo =" + unPRE.id + " ;";
                    ejecutarSQL(consultaSQL);

                    for (int i = 0; i < locaciones.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `prestamodeequipolocacion` VALUES('" + unPRE.id + "','" + locaciones[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    consultaSQL = "DELETE FROM `tiene` WHERE tiene.id_PrestamoDeEquipo =" + unPRE.id + " ;";
                    ejecutarSQL(consultaSQL);
                    for (int i = 0; i < equipos.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `tiene` VALUES('" + unPRE.id + "','" + equipos[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    bool tokenPrestamoAlumno = corroborarPrestamoConAlumno(unPRE.id);
                    if (tokenPrestamoAlumno == true)
                    {
                        consultaSQL2 = "UPDATE realiza SET ci_Solicitante = " + unPRE.alumnoResponsable.ci + " WHERE realiza.id_Prestamo = " + unPRE.id + " ;";
                        ejecutarSQL(consultaSQL2);
                    }
                    else
                    {
                        consultaSQL = "INSERT INTO `realiza` VALUES('" + unPRE.alumnoResponsable + "','" + unPRE.id + "');";
                    }
                    consultaSQL2 = "UPDATE profesorprestamo SET ci_Solicitante = " + unPRE.profeResponsable.ci + " WHERE profesorprestamo.id_Prestamo = " + unPRE.id + " ;";

                    //Tirar arriba(?) las FK start
                    consultaFK = "ALTER TABLE prestamoDeEquipo ADD CONSTRAINT fK_prestamoDeEquipo_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
                    ejecutarSQL(consultaFK);
                    consultaFK = "ALTER TABLE prestamoDeEquipoLocacion ADD CONSTRAINT fK_prestamoDeEquipoLocacion_prestamoDeEquipo FOREIGN KEY (id_PrestamoDeEquipo) REFERENCES prestamoDeEquipo(id_Prestamo);";
                    ejecutarSQL(consultaFK);
                    //Tirar arriba(?) las FK final

                }
            }
           
            return token;

            }

        private int verificarEstado(string alumno, string profe, String[] equipos)
        {
            int token = 0;
            string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + alumno + "' AND `tipo` = alumno;";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                 consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + profe + "' AND `tipo` = profesor;";
                 fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    bool tokenEquipo = corroborarEquipos(equipos);
                    if (tokenEquipo != true)
                    {
                        token = 3;
                    }
                }else { token = 2; }
            }else { token = 1; }
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
        
        


    }
}

