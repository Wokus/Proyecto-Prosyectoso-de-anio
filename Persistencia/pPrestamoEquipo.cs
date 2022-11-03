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
                int id = calculoDeId();
                String curso = recrearCurso(unPRE.alumnoResponsable.ci);
                unPRE.prioridad = calculoPrioridad(curso, unPRE.ejercicio);
                
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRE.fechaSolicitada + "','" + unPRE.fechaRetiro + "','" + unPRE.horaRetiro + "','" + unPRE.fechaDevolucion + "','" + unPRE.estado + "','" + unPRE.prioridad + "','" + unPRE.genuinoDiaDevolucion + "','" + unPRE.ejercicio + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `prestamodeequipo` VALUES('" + id + "','" + unPRE.transporte + "');";  
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
                if (token != 4)
                {
                    consultaSQL = "INSERT INTO realiza VALUES ('" + unPRE.alumnoResponsable.ci + "'," + id + ");";
                    ejecutarSQL(consultaSQL);
                }
               
                consultaSQL = "INSERT INTO profesorPrestamo VALUES ('" + unPRE.profeResponsable.ci + "'," + id + ");";
                ejecutarSQL(consultaSQL);


               


            }
            return token;
        }
       
        public DataTable listarPrestamoDeEquipo()
        {
            String consultaSQL = "SELECT * FROM prestamoDeEquipo INNER JOIN prestamo ON prestamoDeEquipo.id_Prestamo=prestamo.id;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public int modificacionPrestamo(ePrestamoEquipo unPRE, String IdPrestamo)
        {
            int token = 69;
            string consultaSQL;
           
            int existencia = corroborarExistencia(unPRE.id,"equi");
            if (existencia == 1 )
            {
                String[] locaciones = unPRE.locacion.Split(',');
                String[] equipos = unPRE.unE.nombre.Split(',');

               token = verificarEstado(unPRE.alumnoResponsable.ci, unPRE.profeResponsable.ci, equipos);

                if (token == 0)
                {
                    String curso = recrearCurso(unPRE.alumnoResponsable.ci);
           
                    unPRE.prioridad = calculoPrioridad(curso, unPRE.ejercicio);

                    //Tirar abajo as FK start
                    string consultaFK = "ALTER TABLE prestamoDeEquipo DROP FOREIGN KEY fK_prestamoDeEquipo_prestamo;";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE prestamoDeEquipoLocacion DROP FOREIGN KEY fK_prestamoDeEquipoLocacion_PrestamoDeEquipo;";
                    ejecutarSQL(consultaFK);

                    //Tirar abajo as FK final
                    string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada ='" + unPRE.fechaSolicitada + "',"
                                + " fechaRetiro = '" + unPRE.fechaRetiro + "', horaRetiro = '" + unPRE.horaRetiro + "', fechaDevolucion = '" + unPRE.fechaDevolucion + "', fechaGenuinaDevolucion = '" + unPRE.genuinoDiaDevolucion
                                + "', estado ='" + unPRE.estado + "', prioridad = '" + unPRE.prioridad + "', ejercicio = '" + unPRE.ejercicio + "'  WHERE prestamo.id = '" + unPRE.id + "' ;";

                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE prestamoDeEquipo SET transporte = '" + unPRE.transporte
                     + "' WHERE prestamoDeEquipo.id_Prestamo = '" + unPRE.id + "' ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL = "DELETE FROM `prestamodeequipolocacion` WHERE prestamodeequipolocacion.id_PrestamoDeEquipo ='" + unPRE.id + "' ;";
                    ejecutarSQL(consultaSQL);

                    for (int i = 0; i < locaciones.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `prestamodeequipolocacion` VALUES('" + unPRE.id + "','" + locaciones[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    consultaSQL = "DELETE FROM `tiene` WHERE tiene.id_PrestamoDeEquipo ='" + unPRE.id + "' ;";
                    ejecutarSQL(consultaSQL);
                    for (int i = 0; i < equipos.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `tiene` VALUES('" + unPRE.id + "','" + equipos[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    bool tokenPrestamoAlumno = corroborarPrestamoConAlumno(unPRE.id);
                    if (tokenPrestamoAlumno == true)
                    {
                        consultaSQL2 = "UPDATE realiza SET ci_Solicitante = '" + unPRE.alumnoResponsable.ci + "' WHERE realiza.id_Prestamo = '" + unPRE.id + "' ;";
                        ejecutarSQL(consultaSQL);
                    }
                    else
                    {
                        consultaSQL = "INSERT INTO `realiza` VALUES('" + unPRE.alumnoResponsable.ci + "','" + unPRE.id + "');";
                        ejecutarSQL(consultaSQL);
                    }
                    consultaSQL2 = "UPDATE profesorprestamo SET ci_Solicitante = '" + unPRE.profeResponsable.ci + "' WHERE profesorprestamo.id_Prestamo = '" + unPRE.id + "' ;";
                    ejecutarSQL(consultaSQL2);
                    if (unPRE.estado == "Devuelto")
                    {
                        DateTime thisDay = DateTime.Today;
                        consultaSQL = "UPDATE prestamo SET fechaGenuinaDevolucion = '" + thisDay.ToString("yyyy-MM-dd") + "' WHERE prestamo.id = '" + unPRE.id + "';";
                        ejecutarSQL(consultaSQL);
                    }


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

            bool tokenEquipo = corroborarEquipos(equipos);
            if (tokenEquipo == true)
            {
                String consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + profe + "' AND `tipo` = 'Profesor';";
                MySqlDataReader  fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                     consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + alumno + "' AND `tipo` = 'Alumno';";
                     fila = ejecutarYdevolver(consultaSQL);
                    if (fila.Read())
                    {

                    }
                    else {
                        
                            token = 3;
                    } 
                }
                else { token = 2; }
            }else { token = 1; }
            return token;
        }

        public ePrestamoEquipo recrearDatosPrestamo(String prestamoID)
        {
            ePrestamoEquipo unPRE = new ePrestamoEquipo();
            ePrestamo unPRES = new ePrestamo();
            eResponsable profesor = new eResponsable();
            eResponsable alumno = new eResponsable();

            unPRES =  recrearPrestamo(prestamoID);
            unPRE.id = unPRES.id;
            unPRE.fechaSolicitada = unPRES.fechaSolicitada;
            unPRE.fechaRetiro = unPRES.fechaRetiro;
            unPRE.horaRetiro = unPRES.horaRetiro;
            unPRE.fechaDevolucion = unPRES.fechaDevolucion;
            unPRE.estado = unPRES.estado;
            unPRE.genuinoDiaDevolucion = unPRES.genuinoDiaDevolucion;

            alumno = unPRES.alumnoResponsable;
            profesor = unPRES.profeResponsable;

            unPRE.alumnoResponsable = alumno;
            unPRE.profeResponsable = profesor;

            String consultaSQL = "Select * FROM prestamodeequipo WHERE id_Prestamo  = '" + prestamoID + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                unPRE.prioridad = fila.GetInt32("prioridad");
                unPRE.transporte = fila.GetString("transporte");
            }

            // LOCACION

            consultaSQL = "Select * FROM prestamodeequipolocacion WHERE id_PrestamoDeEquipo  = '" + prestamoID + "';";
             fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                unPRE.locacion = unPRE.locacion + fila.GetString("locacion");
            }
            while (fila.Read())
            {
                unPRE.locacion = unPRE.locacion + "," + fila.GetString("locacion");

            }
            // LOCACION

            // Ejercicios
            eEquipo equipos = new eEquipo();
            consultaSQL = "Select * FROM tiene WHERE id_PrestamoDeEquipo = '" + prestamoID + "';";
            fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
               equipos.nombre = equipos.nombre + fila.GetString("equipo");
            }
            while (fila.Read())
            {
                equipos.nombre = equipos.nombre + "," + fila.GetString("equipo");

            }

            unPRE.unE = equipos;
            // Ejercicios
            return unPRE;
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

