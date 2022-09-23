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
   public class pResponsable : clsPersistencia
    {
        public bool altaResponsable(eResponsable unPR)
        {
            int profesor = 0;
            int estudiante = 0;
            bool token = true;

            eUsuario elAdmin = new eUsuario();
            elAdmin = null;
            string consultaSQL = "SELECT * FROM `solicitante` WHERE `solicitante`.`ci` = '" + unPR.ci + "';";


            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            while (fila.Read())
            {
                token = false;
            }

            if (token == true)
            {
                if (unPR.tipo == "Profesor")
                {
                    profesor = 1;

                }
                if (unPR.tipo == "Estudiante")
                {
                    estudiante = 1;

                }
                string consultaSQL2 = "INSERT INTO solicitante VALUES('" + unPR.ci + "','" + unPR.nombre + "','" + unPR.apellido + "');";
                ejecutarSQL(consultaSQL2);

                consultaSQL2 = "INSERT INTO solicitante VALUES('" + unPR.ci + "','" + unPR.curso + "','" + unPR.tipo + "');";
                ejecutarSQL(consultaSQL2);
            }
            return token;
        }

        public eResponsable recrearResponsable(MySqlDataReader fila)
        {
            eResponsable unResponsable = new eResponsable();
            unResponsable.nombre = fila.GetString("Nombre");
            unResponsable.ci = fila.GetString("ci");


            return unResponsable;
        }

    }
}
