using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;
using System.Data;

namespace Persistencia
{

    public class pUsuario : clsPersistencia
    {
        public eUsuario login(string userName, string pass)
        {

            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.ci` = '" + userName + "' AND `contra`='" + pass + "';";

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
            string consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.`ci` = '" + unPU.ci + "';";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);

            }
            if (elAdmin == null)
            {
                string consultaSQL2 = "INSERT INTO persona VALUES('" + unPU.ci + "','" + unPU.nombre + "','" + unPU.apellido + "');";
                ejecutarSQL(consultaSQL2);

                consultaSQL2 = "INSERT INTO usuario VALUES('" + unPU.ci + "','" + unPU.telefono + "','" + unPU.password + "');";
                ejecutarSQL(consultaSQL2);
            }
            return elAdmin;
        }

        public eUsuario modificarUsuario(eUsuario unPU, String NUAM)
        {

            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.`ci` = '" + NUAM + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            
            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);
            }

            if (elAdmin != null)
            {
                eUsuario token = new eUsuario();
                token = elAdmin;

                elAdmin = null;
                consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.`ci` = '" + unPU.ci + "';";


                fila = ejecutarYdevolver(consultaSQL);
                ejecutarSQL(consultaSQL);
                while (fila.Read())
                {
                    elAdmin = recrearUsuario(fila);
                }


                if (elAdmin == null)
                {

                    String consultaFK = "ALTER TABLE usuario DROP FOREIGN KEY fK_usuario_persona;";
                    ejecutarSQL(consultaFK);

                    String consultaSQL2 = "UPDATE `persona` SET `ci` ='" + unPU.ci
                    + "', `nombre` = '" + unPU.nombre + "', `apellido` = '" + unPU.apellido + "' WHERE `persona`.`ci` = '" + NUAM + "';";
                    ejecutarSQL(consultaSQL2);

                    consultaSQL2 = "UPDATE `usuario` SET `ci` = '" + unPU.ci
                    + "', `contra` = '" + unPU.password + "', `telefono` = '" + unPU.telefono + "' WHERE `usuario`.`ci` = '" + NUAM + "';";
                    elAdmin = token;
                    ejecutarSQL(consultaSQL2);


                    consultaFK = "ALTER TABLE usuario ADD constraint fK_usuario_persona FOREIGN KEY (ci) REFERENCES persona(ci);";
                    ejecutarSQL(consultaFK);

                }
            }
            else
            {
                elAdmin = null;
            }
            return elAdmin;
        }

        public eUsuario bajaUsuario(string username)
        {
            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `usuario` WHERE `usuario`.`ci` = '" + username + "';";

            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);

            while (fila.Read())
            {
                elAdmin = recrearUsuario(fila);

            }

            if (elAdmin != null)
            {
                string consultaSQL2 = "DELETE FROM usuario WHERE `usuario`.`ci` = '" + username + "';";
                ejecutarSQL(consultaSQL2);
                consultaSQL2 = "DELETE FROM persona WHERE `persona`.`ci` = '" + username + "';";
                ejecutarSQL(consultaSQL2);

            }
            return elAdmin;
        }

        public eUsuario recrearUsuario(MySqlDataReader fila)
        {
            eUsuario unUsuario = new eUsuario();
            unUsuario.ci = fila.GetString("ci");
            unUsuario.password = fila.GetString("contra");



            return unUsuario;
        }

        public DataTable listarUsuario()
        {
            DataTable dt = null;
            
            String consultaSQL = "SELECT persona.ci, persona.nombre, persona.apellido, usuario.contra, usuario.telefono FROM persona RIGHT JOIN `usuario` ON persona.ci = usuario.ci; ";

             dt = listarAlgo(consultaSQL);
           
            
            return dt;
        }
    }
}



