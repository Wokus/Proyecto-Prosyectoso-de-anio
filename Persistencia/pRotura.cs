using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pRotura : clsPersistencia
    {
        public eRotura recrearRot(string id)
        {
            eRotura unaRot = new eRotura();
            String mySQLcommand = "Slelect * FROM rotura WERE rotura.id =";
            MySqlDataReader fila = ejecutarYdevolver(mySQLcommand);
            if (fila.Read())
            {
                unaRot.idRotura = fila.GetInt32("id");
                unaRot.descripcion = fila.GetString("descripcion ");
            }
             mySQLcommand = "Slelect * FROM rotura WERE rotura.id =";
             fila = ejecutarYdevolver(mySQLcommand);
            if (fila.Read())
            {
                unaRot.idRotura = fila.GetInt32("id");
                unaRot.descripcion = fila.GetString("descripcion ");
            }




            throw new NotImplementedException();
        }
    }
}
