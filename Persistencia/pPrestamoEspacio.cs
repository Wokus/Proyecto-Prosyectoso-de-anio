﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Persistencia
{
    public class pPrestamoEspacio : pPrestamo
    {
        public int altaPrestamoEspacio(ePrestamoEspacio unPRES)
        {
            string consultaSQL;

            int token = verificarEstado(unPRES.alumnoResponsable.ci, unPRES.profeResponsable.ci , Convert.ToInt32(unPRES.unEs.numeroEspacio));
          
            if (token == 0)
            {
                int id = calculoDeId();
                String curso = recrearCurso(unPRES.alumnoResponsable.ci);
                unPRES.prioridad = calculoPrioridad(curso, unPRES.ejercicio);
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRES.fechaSolicitada + "','" + unPRES.fechaRetiro + "','" + unPRES.horaRetiro + "','" + unPRES.fechaDevolucion + "','" + unPRES.estado + "','" + unPRES.prioridad + "','" + unPRES.genuinoDiaDevolucion + "','" + unPRES.ejercicio + "');";
                ejecutarSQL(consultaSQL);

                
                    consultaSQL = "INSERT INTO realiza VALUES ('" + unPRES.alumnoResponsable.ci + "','" + id + "');";
                    ejecutarSQL(consultaSQL);

                consultaSQL = "INSERT INTO profesorPrestamo VALUES ('" + unPRES.profeResponsable.ci + "','" + id + "');";
                ejecutarSQL(consultaSQL);

                consultaSQL = "INSERT INTO `prestamodeespacio` VALUES('" + id + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `obtieneespaciosprestamodeespacio` (`id_PrestamoDeEspacio`, `nro_Espacio`) VALUES('" + id + "','" + unPRES.unEs.numeroEspacio + "');";
                ejecutarSQL(consultaSQL);

            }
            return token;



        }

        public DataTable listarPrestamoDeEspacio()
        {
            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorFechaAR()
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio ORDER BY prestamo.fechaSolicitada ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaRA()
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio ORDER BY prestamo.fechaSolicitada DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorEstado(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio WHERE estado='" + tuHermana + "' ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaARE(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio WHERE estado='" + tuHermana + "' ORDER BY prestamo.fechaSolicitada ASC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorFechaRAE(string tuHermana)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio WHERE estado='" + tuHermana + "' ORDER BY prestamo.fechaSolicitada DESC ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarPrestamoPorPrioridad(string prioridad)
        {

            String consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio ORDER BY prestamo.prioridad " + prioridad + ";";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarPrestamoPorPrioridadE(string tuHermana, string prioridad)
        {

            string consultaSQL = "SELECT prestamo.id, realiza.ci_Solicitante AS Solicitante, prestamo.fechaSolicitada, prestamo.fechaRetiro, prestamo.horaRetiro, prestamo.fechaDevolucion, prestamo.estado, prestamo.prioridad, prestamo.fechaGenuinaDevolucion, prestamo.ejercicio, obtieneEspaciosPrestamoDeEspacio.nro_Espacio FROM prestamo INNER JOIN realiza ON prestamo.id = realiza.id_Prestamo INNER JOIN prestamoDeEspacio ON prestamo.id=prestamoDeEspacio.id_Prestamo INNER JOIN obtieneEspaciosPrestamoDeEspacio ON prestamoDeEspacio.id_Prestamo=obtieneEspaciosPrestamoDeEspacio.id_PrestamoDeEspacio WHERE estado = '" + tuHermana + "' ORDER BY prestamo.prioridad " + prioridad + " ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public int bajaPrestamoDeEspacio(int idPrestamo)
        {

            string consultaSQL = "DELETE FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + " ;";
            ejecutarSQL(consultaSQL);

            return idPrestamo;

        }

        public int modificacionPrestamo(ePrestamoEspacio unPRES)
        {
            int token = 69;
            string consultaSQL;
            int existencia = corroborarExistencia(unPRES.id, "espa");
            if (existencia == 2)
            {
                 token = verificarEstado(unPRES.alumnoResponsable.ci, unPRES.profeResponsable.ci, Convert.ToInt32(unPRES.unEs.nombreEspacio));
                if (token == 0)
                {
                    //Tirar abajo FK start
                    string consultaFK = "ALTER TABLE prestamoDeEspacio DROP FOREIGN KEY fK_prestamoDeEspacio_prestamo;";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio DROP FOREIGN KEY fK_obtieneEspaciosPrestamoDeEspacio_prestamoDeEspacio;";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio DROP FOREIGN KEY fK_obtieneEspaciosPrestamoDeEspacio_espacio;";
                    ejecutarSQL(consultaFK);
                    //Tirar abajo FK final
                    string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada ='" + unPRES.fechaSolicitada + "',"
                                + " fechaRetiro = '" + unPRES.fechaRetiro + "', horaRetiro = '" + unPRES.horaRetiro + "', fechaDevolucion = '" + unPRES.fechaDevolucion + "', fechaGenuinaDevolucion = '" + unPRES.genuinoDiaDevolucion
                                + "', estado ='" + unPRES.estado + "', prioridad = '" + unPRES.prioridad + "', ejercicio = '" + unPRES.ejercicio + "'  WHERE prestamo.id = '" + unPRES.id + "' ;";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL = "UPDATE prestamodeespacio SET id_Prestamo = '" + unPRES.id + "' WHERE id_Prestamo = '" + unPRES.id + "' ;";
                    ejecutarSQL(consultaSQL);

                    consultaSQL2 = "UPDATE obtieneEspaciosPrestamoDeEspacio SET nro_Espacio = '" + unPRES.unEs.nombreEspacio
                    + "' WHERE id_PrestamoDeEspacio = '" + unPRES.id + "' ;";
                    ejecutarSQL(consultaSQL2);

                    
                        consultaSQL2 = "UPDATE realiza SET ci_Solicitante = '" + unPRES.alumnoResponsable.ci + "' WHERE realiza.id_Prestamo = '" + unPRES.id + "' ;";
                        ejecutarSQL(consultaSQL2);
                   
                    consultaSQL2 = "UPDATE profesorprestamo SET ci_Solicitante = '" + unPRES.profeResponsable.ci + "' WHERE profesorprestamo.id_Prestamo = '" + unPRES.id + "' ;";
                    ejecutarSQL(consultaSQL2);

                    //Tirar arriba FK start
                    consultaFK = "ALTER TABLE prestamoDeEspacio ADD CONSTRAINT fK_prestamoDeEspacio_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
                    ejecutarSQL(consultaFK);
                    

                    consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio ADD CONSTRAINT fK_obtieneEspaciosPrestamoDeEspacio_prestamoDeEspacio FOREIGN KEY(id_PrestamoDeEspacio) REFERENCES prestamoDeEspacio(id_Prestamo);";
                    ejecutarSQL(consultaFK);

                    consultaFK = "ALTER TABLE obtieneEspaciosPrestamoDeEspacio ADD CONSTRAINT fK_obtieneEspaciosPrestamoDeEspacio_espacio FOREIGN KEY(nro_Espacio) REFERENCES espacio(nro);";
                    ejecutarSQL(consultaFK);
                    //Tirar arriba FK final
                }
            }
            return token;
        }
        private bool verificarEspacio(int numeroEspacio)
        {
            bool tokenEspacio = true;

            string consultaSQL = "SELECT * FROM `espacio` WHERE `nro` = '" + numeroEspacio + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {

            }
            else
            {
                tokenEspacio = false;

            }

            return tokenEspacio;
        }
        private int verificarEstado(string alumno, string profe, int numeroEspacio)
        {
            int token = 0;
            string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + alumno + "' AND `tipo` = 'Alumno';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + profe + "' AND `tipo` = 'Profesor';";
                fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    bool tokenEspacio = verificarEspacio(numeroEspacio);
                    if (tokenEspacio != true)
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

