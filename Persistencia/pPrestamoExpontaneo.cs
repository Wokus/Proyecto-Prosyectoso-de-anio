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
    public class pPrestamoExpontaneo : clsPersistencia
    {
        public bool altaEspacioExpontaneo(ePrestamoEspontaneos unPRESP)
        {
            String[] equipos = unPRESP.idEquipo.Split(',');

            string consultaSQL;
            int id = 0;
            int idOcupado = 0;
            int estadoBOOLarm = 0;
            int estadoBOOLlev = 0;
            int estadoBOOLcan = 0;
            int estadoBOOLdev = 0;
            bool tokenEquipo = true;

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

                if (unPRESP.estado == "Armado")
                {
                    estadoBOOLarm = 1;
                }
                if (unPRESP.estado == "Levantado")
                {
                    estadoBOOLlev = 1;
                }
                if (unPRESP.estado == "Cancelado")
                {
                    estadoBOOLcan = 1;
                }
                if (unPRESP.estado == "Devuelto")
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
                consultaSQL = "INSERT INTO `prestamo` VALUES('" + id + "','" + unPRESP.fechaSolicitada + "','" + unPRESP.cantidadDias + "','" + unPRESP.fechaRetiro + "','" + unPRESP.horaRetiro + "','" + unPRESP.fechaDevolucion + "','" + unPRESP.horaDevolucion + "','" + estadoBOOLarm + "','" + estadoBOOLlev + "','" + estadoBOOLcan + "','" + estadoBOOLdev + "','" + unPRESP.alumnoRespon + "','" + unPRESP.profeRespon + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `prestamoespontaneo` VALUES('" + id + "');";
                ejecutarSQL(consultaSQL);


                for (int i = 0; i < equipos.Length; i++)
                {
                    consultaSQL = "INSERT INTO `obtieneequipoprestamoespontaneo` VALUES('" + id + "','" + equipos[i] + "');";
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

        public bool modificacionPrestamo(ePrestamoEspontaneos unEPEX, String IdPrestamo)
        {

            string consultaSQL;
            string estado = "ICKKCK";
            bool tokenEquipo = true;

            if (tokenEquipo == true)
            {
                if (unEPEX.estado == "Armado")
                {
                    estado = "Armado";
                }
                if (unEPEX.estado == "Levantado")
                {
                    estado = "Levantado";
                }
                if (unEPEX.estado == "Cancelado")
                {
                    estado = "Cancelado";
                }
                if (unEPEX.estado == "Devuelto")
                {
                    estado = "Devuelto";
                }

            }

            string consultaFK = "ALTER TABLE prestamoEspontaneo DROP FOREIGN KEY fK_prestamoEspontaneo_prestamo;";
            ejecutarSQL(consultaFK);

            string consultaSQL2 = "UPDATE prestamo SET fechaSolicitada =" + unEPEX.fechaSolicitada + ", cantidadDias =" + unEPEX.cantidadDias
            + ", fechaRetiro = " + unEPEX.fechaRetiro + ", horaRetiro = " + unEPEX.horaRetiro + ", fechaDevolucion = " + unEPEX.horaDevolucion
            + ", tipo =" + estado + " profesorResponsable = " + unEPEX.profeRespon + ", alumnoResponsable = " + unEPEX.alumnoRespon + "  WHERE prestamo.id = " + IdPrestamo + " ;";
            ejecutarSQL(consultaSQL2);

            consultaFK = "ALTER TABLE prestamoEspontaneo ADD CONSTRAINT fK_prestamoEspontaneo_prestamo FOREIGN KEY (id_Prestamo) REFERENCES prestamo(id);";
            ejecutarSQL(consultaFK);

            bool confirmacion = tokenEquipo;
            return confirmacion;

        }
    }
}
