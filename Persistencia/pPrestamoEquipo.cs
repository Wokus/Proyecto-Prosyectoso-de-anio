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

                }
                else
                {
                    tokenEquipo = false;
                    break;
                }



            }

            if (tokenEquipo == true)
            {
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

        public int bajaPrestamoDeEquipo(int idPrestamo)
        {
            int id1 = 0;
            int id2 = 0;
            int id3 = 0;
            int id5 = 0;
            string consultaSQL2;
            string consultaSQL = "SELECT * FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            while (fila.Read())
            {

                id1 = (idPrestamo);
                id1 = recrearIdPrestamo(fila);

            }
            if (id1 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoDeEquipo WHERE prestamoDeEquipo.id_Prestamo = " + idPrestamo + " ;";
                ejecutarSQL(consultaSQL);

            }

            consultaSQL = "SELECT * FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila2 = ejecutarYdevolver(consultaSQL);
            while (fila2.Read())
            {

                id2 = (idPrestamo);
                id2 = recrearIdPrestamo(fila2);

            }
            if (id2 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoDeEspacio WHERE prestamoDeEspacio.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);

            }

            consultaSQL = "SELECT * FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
            MySqlDataReader fila3 = ejecutarYdevolver(consultaSQL);
            while (fila3.Read())
            {

                id3 = (idPrestamo);
                id3 = recrearIdPrestamo(fila3);

            }
            if (id3 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamoEspontaneo WHERE prestamoEspontaneo.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);
                
            }

            consultaSQL = "SELECT * FROM prestamo WHERE prestamo.id = " + idPrestamo + ";";
            MySqlDataReader fila5 = ejecutarYdevolver(consultaSQL);
            while (fila5.Read())
            {

                id5 = (idPrestamo);
                id5 = recrearIdPrestamo(fila5);

            }
            if (id5 != 0)
            {

                consultaSQL2 = "DELETE FROM prestamo WHERE prestamo.id_Prestamo = " + idPrestamo + ";";
                ejecutarSQL(consultaSQL2);

            }
            
            return idPrestamo;
        }

        public bool modificacionPrestamo(ePrestamoEquipo unEPE, String IdPrestamo)
        {

            string consultaSQL;
            string estado = "ICKKCK";
            bool tokenEquipo = true;

            String[] locaciones = unEPE.locacion.Split(',');
            String[] equipos = unEPE.equipos.Split(',');

            for (int i = 0; i < equipos.Length; i++)
            {

                consultaSQL = "SELECT * FROM `equipo` WHERE `id` = '" + equipos[i] + "';";
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

            if (tokenEquipo == true)
            {
                unEPE.prioridad = 0;
                if (unEPE.estado == "Armado")
                {
                    estado = "Armado";
                }
                if (unEPE.estado == "Levantado")
                {
                    estado = "Levantado";
                }
                if (unEPE.estado == "Cancelado")
                {
                    estado = "Cancelado";
                }
                if (unEPE.estado == "Devuelto")
                {
                    estado = "Devuelto";
                }

            }

            string consultaFK = "ALTER TABLE prestamoDeEquipo DROP FOREIGN KEY fK_prestamoDeEquipo_prestamo;";
            ejecutarSQL(consultaFK);

            string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada =" + unEPE.fechaSolicitada + ", cantidadDias =" + unEPE.cantidadDias 
            + ", fechaRetiro = " + unEPE.fechaRetiro + ", horaRetiro = " + unEPE.horaRetiro + ", fechaDevolucion = " + unEPE.horaDevolucion 
            + ", tipo =" + estado + " profesorResponsable = " + unEPE.profeRespon + ", alumnoResponsable = " + unEPE.alumnoRespon + "  WHERE prestamo.id = " + IdPrestamo + " ;";
            ejecutarSQL(consultaSQL2);

            consultaSQL2 = "UPDATE prestamoDeEquipo SET prioridad = " + unEPE.prioridad + ", ejercicio = " + unEPE.ejercicio 
            + " WHERE prestamoDeEquipo.id_Prestamo = " + IdPrestamo + " ;";
            ejecutarSQL(consultaSQL2);

            consultaFK = "ALTER TABLE prestamoDeEquipoLocacion DROP FOREIGN KEY fK_prestamoDeEquipoLocacion_PrestamoDeEquipo;";
            ejecutarSQL(consultaFK);

            consultaSQL2 = "UPDATE prestamoDeEquipoLocacion SET locacion = " + unEPE.locacion + " WHERE id_PrestamoDeEquipo = " + IdPrestamo + " ;";

            consultaFK = "ALTER TABLE prestamoDeEquipo ADD CONSTRAINT fK_prestamoDeEquipo_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
            ejecutarSQL(consultaFK);

            consultaFK = "ALTER TABLE prestamoDeEquipoLocacion ADD CONSTRAINT fK_prestamoDeEquipoLocacion_prestamoDeEquipo FOREIGN KEY (id_PrestamoDeEquipo) REFERENCES prestamoDeEquipo(id_Prestamo);";
            ejecutarSQL(consultaFK);

            bool confirmacion = tokenEquipo;
            return confirmacion;

            }
    }
}

