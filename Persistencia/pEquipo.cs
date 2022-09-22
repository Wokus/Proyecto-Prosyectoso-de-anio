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
        public void altaEquipo(eEquipo unPE)
        {
            int stock = 1;
            int id = 0;
            int idOcupado=0;


                while (idOcupado == id) 
                {
                    id++;
                    string consultaSQLid = "SELECT * FROM `inventario` WHERE `inventario`.`id` = '" + id + "'; ";
                    MySqlDataReader filaid = ejecutarYdevolver(consultaSQLid);
                     filaid = ejecutarYdevolver(consultaSQLid);
                    if (filaid.Read())
                    {
                        idOcupado = recrearIdEquipo(filaid);
                    }else {  }
                } 
      

             string consultaSQL = "SELECT COUNT(*) FROM `inventario` WHERE `Nombre` = '" + unPE.nombre + "' AND `Numero de Serie` = '" + unPE.numeroSerie + "' AND `Precio` = '" + unPE.precio + "' AND `Tipo` = '" + unPE.tipo + "'; ";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            if (fila.Read())
            {
                stock = fila.GetInt32("COUNT(*)") + 1;
               consultaSQL= "UPDATE `inventario` SET `Stock` = '" + stock + "' WHERE `inventario`.`Numero de Serie` = '" + unPE.numeroSerie + "' AND `inventario`.`Precio` = '" + unPE.precio + "' AND `inventario`.`Tipo` = '" + unPE.tipo + "';";
                ejecutarSQL(consultaSQL);

            }
            else { stock = 1; }

            consultaSQL = "INSERT INTO `inventario` VALUES('" + id + "','" + unPE.nombre + "','" + unPE.numeroSerie + "','" + unPE.estado + "','" + unPE.fechaIngreso + "','" + unPE.asegurado + "','" + unPE.precio + "','" + unPE.observacion + "','" + unPE.tipo + "','" + stock + "');";
            ejecutarSQL(consultaSQL);

        }

        public int bajaEquipo(string id)
        {
            int stock;
            int id2 = 0;
            string consultaSQL = "SELECT * FROM `inventario` WHERE `inventario`.`id` = '" + id + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                id2 = Convert.ToInt32(id);
                id2 = recrearIdEquipo(fila);

            }
            if (id2 != 0)
            { 
                string consultaSQL2 = "DELETE FROM inventario WHERE `inventario`.`id` = '" + id + "';";
                ejecutarSQL(consultaSQL2);
                stock = fila.GetInt32("Stock");
                int stock2 = stock - 1; 
                consultaSQL = "UPDATE `inventario` SET `Stock` = '" + stock2 + "' WHERE `inventario`.`Stock` = '" + stock + "';";
                ejecutarSQL(consultaSQL);
            }

            return id2;
        }

        public int recrearIdEquipo(MySqlDataReader fila)
        {
            int id = fila.GetInt32("id");
            return id;
        }

        public List<eEquipo> listarEquipo()
        {

            List<eEquipo> colEquipo = new List<eEquipo>();
            string consultaSQL = "SELECT * FROM equipo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);

            while (resultado.Read())
            {

                colEquipo.Add(recrearEquipo(resultado));

            }

            return colEquipo;

        }

        private eEquipo recrearEquipo(MySqlDataReader fila)
        {

            eEquipo unEquipo = new eEquipo();

            unEquipo.id = fila.GetInt16("id");
            unEquipo.nombre = fila.GetString("nombre");
            unEquipo.numeroSerie = fila.GetString("numero_de_serie");
            unEquipo.estado = fila.GetString("estado");
            unEquipo.fechaIngreso = fila.GetString("ingreso");
            unEquipo.asegurado = fila.GetString("asegurado");
            unEquipo.precio = fila.GetInt16("precio");
            unEquipo.fotografia = fila.GetString("fotografia");
            unEquipo.sonido = fila.GetString("sonido");
            unEquipo.informatica = fila.GetString("informatica");
            unEquipo.varios = fila.GetString("varios");
            unEquipo.stock = fila.GetInt16("stock");
            unEquipo.observacion = fila.GetString("observaciones");
            
            return unEquipo;

        }

    }
}
