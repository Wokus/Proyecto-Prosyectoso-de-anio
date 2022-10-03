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
    public class pPrestamoEspacio : clsPersistencia
    {
        public bool altaPrestamoEspacio(ePrestamoEspacio unPRE)
        {
            string consultaSQL;
            int id = 0;
            int idOcupado = 0;
            int estadoBOOLarm = 0;
            int estadoBOOLlev = 0;
            int estadoBOOLcan = 0;
            int estadoBOOLdev = 0;
            bool tokenEspacio = true;

            consultaSQL = "SELECT * FROM `espacio` WHERE `nro` = '" + unPRE.numeroEspacio + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {

            }
            else
            {
                tokenEspacio = false;
                
            }

            if (tokenEspacio == true)
            {

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
                consultaSQL = "INSERT INTO `prestamodeespacio` VALUES('" + id + "');";
                ejecutarSQL(consultaSQL);
                consultaSQL = "INSERT INTO `obtieneespaciosprestamodeespacio` (`id_PrestamoDeEspacio`, `nro_Espacio`) VALUES('" + id + "','" + unPRE.numeroEspacio + "');";
                ejecutarSQL(consultaSQL);



            }
            return tokenEspacio;



        }
        public int recrearIdPrestamo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }

        public DataTable listarPrestamoDeEspacio()
        {
            String consultaSQL = "SELECT * FROM prestamoDeEspacio;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }


    }
}

