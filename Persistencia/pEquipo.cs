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
    public class pEquipo : clsPersistencia
    {
        public bool altaEquipo(eEquipo unPE)
        {
            
            int id = 0;
      
            bool NStoken = false;
       
            String consultaSQL;
           
            if (unPE.numeroSerie != null)
            {
                 consultaSQL = "SELECT * FROM `equipo` WHERE `equipo`.`numero_de_serie` = '" + unPE.numeroSerie + "'; ";
                MySqlDataReader filaNS = ejecutarYdevolver(consultaSQL);
                if (filaNS.Read())
                {

                }
                else { NStoken = true; }

            }
            else { NStoken = true; }

            if (NStoken == true)
            {
                id = calculoID();

               int stock = calculoStock(unPE.nombre, unPE.precio);

                consultaSQL = "INSERT INTO `equipo` VALUES('" + id + "','" + unPE.nombre + "','" + unPE.numeroSerie + "','" + unPE.estado + "','" + unPE.fechaIngreso + "','" + unPE.asegurado + "','" + unPE.precio + "','" + stock + "','" + unPE.observacion + "','" + unPE.tipo + "');";
                ejecutarSQL(consultaSQL);
            }

            return NStoken;
        }

        public bool modificarEquipo(eEquipo unE)
        {
            bool token = true;
            if (unE.asegurado == "Si")
            {
                unE.asegurado = "1";
            }else {  unE.asegurado = "0"; }

            string consultaSQL = "SELECT * FROM `equipo` WHERE `equipo`.`id` = '" + unE.id + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
               
                    consultaSQL = "UPDATE `equipo` SET `nombre` = '" + unE.nombre
                    + "', `numero_de_serie` = '" + unE.numeroSerie + "', `estado` = '" + unE.estado
                    + "', `ingreso` = '" + unE.fechaIngreso + "', `asegurado` = '" + unE.asegurado
                    + "', `precio` = '" + unE.precio + "', `tipo` = '" + unE.tipo
                    + "', `stock` = '" + unE.stock
                    + "' WHERE `equipo`.`id` = '" + unE.id + "';";
                    ejecutarSQL(consultaSQL);

                

            }else { token = false; }


            return token;
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

        public DataTable listarEquipo1()
        {
            String consultaSQL = "SELECT * FROM equipo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

        public DataTable listarEquipoT(string tipo)
        {

            string consultaSQL = "SELECT * FROM equipo WHERE tipo = '" + tipo + "' ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public DataTable listarEquipoE(string estado)
        {

            string consultaSQL = "SELECT * FROM equipo WHERE estado = '" + estado + "' ;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;

        }

        public int calculoID()
        {
            int id = 0;
            int idOcupado = 0;
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
            return id;

        }
        public int calculoStock(String nombre, String precio)
        {
            int stock;
            string consultaSQL = "SELECT COUNT(*) FROM `equipo` WHERE `nombre` = '" + nombre + "' AND `precio` = '" + precio + "'; ";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                
                stock = fila.GetInt32("COUNT(*)") + 1;
                consultaSQL = "UPDATE `equipo` SET `stock` = '" + stock + "' WHERE `equipo`.`nombre` = '" + nombre + "' AND `equipo`.`precio` = '" + precio + "';";
                ejecutarSQL(consultaSQL);

            }
            else { stock = 1; }
            return stock;
        }
        

    }
}
