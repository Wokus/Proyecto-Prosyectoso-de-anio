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
  
        public class pUsuario : clsPersistencia
        {
            public eUsuario login(string userName, string pass)
            {
            
            eUsuario elAdmin = new eUsuario();
                elAdmin = null;
                string consultaSQL = "SELECT * FROM `administradores` WHERE `administradores`.`Nombre de Usuario` = '" + userName + "' AND `Clave`='" + pass + "';";

                MySqlDataReader fila = ejecutarYdevolver(consultaSQL);

                

                while (fila.Read())
                {
                    elAdmin = recrearUsuario(fila);

                }
                return elAdmin;
            }

        public eUsuario altaUsuario(eUsuario unPU)
        {
            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `administradores` WHERE `administradores`.`Nombre de Usuario` = '" + unPU.username + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            //ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);

            }
            

            if (elAdmin == null)
            {
                string consultaSQL2 = "INSERT INTO administradores VALUES('" + unPU.username + "','" + unPU.password + "','" + unPU.nombreCompleto + "','" + unPU.telefono + "');"; 
                ejecutarSQL(consultaSQL2);
            }
                return elAdmin;
        }

        public eUsuario modificarUsuario(eUsuario unPU, String NUAM)
        {
            
            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `administradores` WHERE `administradores`.`Nombre de Usuario` = '" + NUAM + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);
            }

            

            if (elAdmin != null)
            {
                eUsuario token = new eUsuario();
                token = elAdmin;

                elAdmin = null;
                consultaSQL = "SELECT * FROM `administradores` WHERE `administradores`.`Nombre de Usuario` = '" + unPU.username + "';";


                 fila = ejecutarYdevolver(consultaSQL);
                ejecutarSQL(consultaSQL);
                while (fila.Read())
                {
                    elAdmin = recrearUsuario(fila);
                }

                
                if (elAdmin == null)
                {
                    String consultaSQL2 = "UPDATE `administradores` SET `Nombre de Usuario` = '" + unPU.username + "', `Clave` = '" + unPU.password + "', `Nombre y Apellido` = '" + unPU.nombreCompleto + "', `Telefono` = '" + unPU.telefono + "' WHERE `administradores`.`Nombre de Usuario` = '" + NUAM + "';";
                    ejecutarSQL(consultaSQL2);
                    elAdmin = token;
                }



            }else
            {
                elAdmin = null;
            }
            return elAdmin;
        }

        public eUsuario bajaUsuario(string username, string password)
        {
            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `administradores` WHERE `administradores`.`Nombre de Usuario` = '" + username + "' AND `Clave`='" + password + "';";
            

            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            ejecutarSQL(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);

            }

            if (elAdmin!=null)
            { //"DELETE FROM administradores WHERE `administradores`.`Nombre de Usuario` = 'Pepe'"
                string consultaSQL2 = "DELETE FROM administradores WHERE `administradores`.`Nombre de Usuario` = '" + username +"';";
                
                ejecutarSQL(consultaSQL2);
                
            }
            return elAdmin;
        }

        public eUsuario recrearUsuario(MySqlDataReader fila)
            {
            eUsuario unUsuario = new eUsuario();
                unUsuario.password = fila.GetString("Clave");
                unUsuario.username = fila.GetString("Nombre de Usuario");


                return unUsuario;
            }

        public DataTable listarUsuario()
        {
            String consultaSQL = "SELECT * FROM administradores;";
            
            DataTable dt = listarAlgo(consultaSQL);

            return dt;  
        }




        }
}
