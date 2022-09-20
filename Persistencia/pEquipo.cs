using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;


namespace Persistencia
{
    public class pEquipo : clsPersistencia
    {
        public bool altaEquipo(eEquipo unPE)
        {
            int stock = 1;
            int id = 0;
            int idOcupado=0;
            bool NStoken = false;
            int tipoBOOLinf = 0;
            int tipoBOOLfot = 0;
            int tipoBOOLson = 0;
            int tipoBOOLotr = 0;
            if (unPE.tipo == "Informatica")
            {
                tipoBOOLinf = 1;
            }
            if (unPE.tipo == "Fotografia")
            {
                tipoBOOLfot = 1;
            }
            if (unPE.tipo == "Sonido")
            {
                tipoBOOLson = 1;
            }
            if (unPE.tipo == "Otros")
            {
                tipoBOOLotr = 1;
            }
            if (unPE.numeroSerie != null)
            {
                string consultaSQL = "SELECT * FROM `equipo` WHERE `equipo`.`numero_de_serie` = '" + unPE.numeroSerie + "'; ";
                MySqlDataReader filaNS = ejecutarYdevolver(consultaSQL);
                if (filaNS.Read() )
                {

                }else { NStoken = true; }

            }else { NStoken = true; }

            if (NStoken == true)
            {
                while (idOcupado == id)
                {
                    id++;
                    string consultaSQLid = "SELECT * FROM `equipo` WHERE `equipo`.`id` = '" + id + "'; ";
                    MySqlDataReader filaid = ejecutarYdevolver(consultaSQLid);
                    if (filaid.Read())
                    {
                        idOcupado = recrearIdEquipo(filaid);
                    }
                }


                string consultaSQL = "SELECT COUNT(*) FROM `equipo` WHERE `nombre` = '" + unPE.nombre + "' AND `precio` = '" + unPE.precio + "'; ";
                MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
                if (fila.Read())
                {
                    stock = fila.GetInt32("COUNT(*)") + 1;
                    consultaSQL = "UPDATE `equipo` SET `stock` = '" + stock + "' WHERE `equipo`.`nombre` = '" + unPE.nombre + "' AND `equipo`.`precio` = '" + unPE.precio + "';";
                    ejecutarSQL(consultaSQL);

                }
                else { stock = 1; }

                consultaSQL = "INSERT INTO `equipo` VALUES('" + id + "','" + unPE.nombre + "','" + unPE.numeroSerie + "','" + unPE.estado + "','" + unPE.fechaIngreso + "','" + unPE.asegurado + "','" + unPE.precio + "','" + tipoBOOLfot + "','" + tipoBOOLson + "','" + tipoBOOLinf + "','" + tipoBOOLotr + "','" + stock + "','" + unPE.observacion + "');";
                ejecutarSQL(consultaSQL);
            }

            return NStoken;
        }

        public int bajaEquipo(string id)
        {
            int stock;
            int id2 = 0;
            string consultaSQL = "SELECT * FROM `equipo` WHERE `equipo`.`id` = '" + id + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                id2 = Convert.ToInt32(id);
                id2 = recrearIdEquipo(fila);

            }
            if (id2 != 0)
            { 
                string consultaSQL2 = "DELETE FROM equipo WHERE `equipo`.`id` = '" + id + "';";
                ejecutarSQL(consultaSQL2);
                stock = fila.GetInt32("Stock");
                int stock2 = stock - 1; 
                consultaSQL = "UPDATE `equipo` SET `stock` = '" + stock2 + "' WHERE `equipo`.`stock` = '" + stock + "';";
                ejecutarSQL(consultaSQL);
            }

            return id2;
        }

        public int recrearIdEquipo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }

    }
}
