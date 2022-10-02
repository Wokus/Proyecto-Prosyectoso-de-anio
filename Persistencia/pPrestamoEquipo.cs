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
    public class pPrestamoEquipo : clsPersistencia
    {
        public bool altaPrestamo(ePrestamoEquipo unPRE)
        {
            string consultaSQL;
            int id = 0;
            int idOcupado = 0;
            int estadoBOOLarm = 0;
            int estadoBOOLlev = 0;
            int estadoBOOLcan = 0;
            int estadoBOOLdev = 0;
            bool tokenEquipo = true;

            String[] locaciones = unPRE.locacion.Split(',');
            String[] equipos = unPRE.equipos.Split(',');

            for (int i = 0; i < equipos.Length; i++)
            {

                consultaSQL = "SELECT * FROM `equipo` WHERE `id` = '" + equipos[i] + "';";
                MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {

                }else {
                    tokenEquipo = false;
                    break;
                }



            }

            if (tokenEquipo == true) { 
            unPRE.prioridad = 0;
            if (unPRE.estado == "Armado")
            {
                estadoBOOLarm = 1;
            }
            if (unPRE.estado == "Levantado")
            {
                estadoBOOLlev = 1;
            }
            if (unPRE.estado == "Cancelado")
            {
                estadoBOOLcan = 1;
            }
            if (unPRE.estado == "Devuelto")
            {
                estadoBOOLdev = 1;
            }




            while (idOcupado == id)
            {
                id++;
                consultaSQL = "SELECT * FROM `prestamo` WHERE `prestamo`.`id` = '" + id + "'; ";
                MySqlDataReader filaid = ejecutarYdevolver(consultaSQL);
                if (filaid.Read())
                {
                    idOcupado = recrearIdPrestamo(filaid);
                }
            }        
            consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRE.fechaSolicitada + "','" + unPRE.cantidadDias + "','" + unPRE.fechaRetiro + "','" + unPRE.horaRetiro + "','" + unPRE.fechaDevolucion + "','" + unPRE.horaDevolucion + "','" + estadoBOOLarm + "','" + estadoBOOLlev + "','" + estadoBOOLcan + "','" + estadoBOOLdev + "','" + unPRE.alumnoRespon + "','" + unPRE.profeRespon + "');";
            ejecutarSQL(consultaSQL);
            consultaSQL = "INSERT INTO `prestamodeequipo` VALUES('" + id + "','" + unPRE.prioridad + "','" + unPRE.ejercicio + "');";
            ejecutarSQL(consultaSQL);

            for (int i = 0; i<locaciones.Length; i++)
            {
                
                consultaSQL = "INSERT INTO `prestamodeequipolocacion` VALUES('" + id + "','" + locaciones[i] + "');";
                ejecutarSQL(consultaSQL);
            }
                for (int i = 0; i < equipos.Length; i++)
                {
                    consultaSQL = "INSERT INTO `tiene` VALUES('" + id + "','" + equipos[i] + "');";
                    ejecutarSQL(consultaSQL);
                }



            }
            return tokenEquipo;
        }
        public int recrearIdPrestamo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }

        public DataTable listarPrestamoDeEquipo()
        {
            String consultaSQL = "SELECT * FROM prestamoDeEquipo INNER JOIN prestamo ON prestamoDeEquipo.id_Prestamo=prestamo.id;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }
    }
}

