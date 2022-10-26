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
            String[] equipos = unPRESP.idEquipo.Split(',');
            String consultaSQL;
            
                int token = verificarEstado(unPRESP.alumnoResponsable.ci, unPRESP.profeResponsable.ci, equipos);
            if (token == 0)
            {
                int id = calculoDeId();
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRESP.fechaSolicitada + "','" + unPRESP.cantidadDias + "','" + unPRESP.fechaRetiro + "','" + unPRESP.horaRetiro + "','" + unPRESP.fechaDevolucion + "','" + unPRESP.horaDevolucion + "','" + unPRESP.estado + "','" + unPRESP.prioridad + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `prestamoEspontaneo` VALUES('" + id + "');";
                ejecutarSQL(consultaSQL);
                for (int i = 0; i < equipos.Length; i++)
                {
                    consultaSQL = "INSERT INTO `obtieneequipoprestamoespontaneo` VALUES('" + id + "','" + equipos[i] + "');";
                    ejecutarSQL(consultaSQL);
                }
                if (unPRESP.alumnoResponsable.ci != null)
                {
                    consultaSQL = "INSERT INTO realiza VALUES (" + unPRESP.alumnoResponsable.ci + "," + unPRESP.id + ");";
                    ejecutarSQL(consultaSQL);
                }

                consultaSQL = "INSERT INTO profesorPrestamo VALUES (" + unPRESP.profeResponsable.ci + "," + unPRESP.id + ");";
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
            String consultaSQL = "SELECT * FROM prestamoEspontaneo INNER JOIN prestamo ON prestamoEspontaneo.id_Prestamo=prestamo.id;";

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

            string consultaFK = "ALTER TABLE prestamoEspontaneo DROP FOREIGN KEY fK_prestamoEspontaneo_prestamo;";
            ejecutarSQL(consultaFK);

            int existencia = corroborarExistencia(unPRESP.id, "espo");
            if (existencia == 3)
            {
                

                String[] equipos = unPRESP.unE.nombre.Split(',');
                token = verificarEstado(unPRESP.alumnoResponsable.ci, unPRESP.profeResponsable.ci, equipos);
                if (token == 0)
                {
                    string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada =" + unPRESP.fechaSolicitada + ", cantidadDias =" + unPRESP.cantidadDias
                    + ", fechaRetiro = " + unPRESP.fechaRetiro + ", horaRetiro = " + unPRESP.horaRetiro + ", fechaDevolucion = " + unPRESP.horaDevolucion
                    + ", estado =" + estado + "  WHERE prestamo.id = " + unPRESP.id + " ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL = "DELETE FROM `tiene` WHERE tiene.id_PrestamoDeEquipo =" + unPRESP.id + " ;";
                    ejecutarSQL(consultaSQL);
                    for (int i = 0; i < equipos.Length; i++)
                    {
                        consultaSQL = "INSERT INTO `tiene` VALUES('" + unPRESP.id + "','" + equipos[i] + "');";
                        ejecutarSQL(consultaSQL);
                    }

                    bool tokenPrestamoAlumno = corroborarPrestamoConAlumno(unPRESP.id);
                    if (tokenPrestamoAlumno == true)
                    {
                        consultaSQL2 = "UPDATE realiza SET ci_Solicitante = " + unPRESP.alumnoResponsable.ci + " WHERE realiza.id_Prestamo = " + unPRESP.id + " ;";
                        ejecutarSQL(consultaSQL2);
                    }
                    else
                    {
                        consultaSQL = "INSERT INTO `realiza` VALUES('" + unPRESP.alumnoResponsable + "','" + unPRESP.id + "');";
                    }
                    consultaSQL2 = "UPDATE profesorprestamo SET ci_Solicitante = " + unPRESP.profeResponsable.ci + " WHERE profesorprestamo.id_Prestamo = " + unPRESP.id + " ;";

                }


            }

            consultaFK = "ALTER TABLE prestamoEspontaneo ADD CONSTRAINT fK_prestamoEspontaneo_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
            ejecutarSQL(consultaFK);

      
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
            string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + alumno + "' AND `tipo` = alumno;";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + profe + "' AND `tipo` = profesor;";
                fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    bool tokenEquipo= corroborarEquipos(equipos);
                    if (tokenEquipo != true)
                    {
                        token = 3;
                    }
                }
                else { token = 2; }
            }
            else { token = 1; }
            return token;
        }



    }
}
