using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;
using System.Data;

namespace Dominio
{
    public class dUsuario
    {
        public eUsuario login(string userName, string password)
        {

            pUsuario unPU = new pUsuario();
            return unPU.login(userName, password);

        }

        public eUsuario altaUsuario(eUsuario unDU)
        {
            pUsuario unPU = new pUsuario(); 
            
            return unPU.altaUsuario(unDU);
        }

        public eUsuario bajaUsuario(String username)
        {
            pUsuario unPU = new pUsuario();
            return unPU.bajaUsuario(username);

        }

        public DataTable listarUsuario()
        {

            pUsuario unPU = new pUsuario();

            return unPU.listarUsuario();
        }

        public eUsuario modificarUsuario(eUsuario unDU, String NUAM)
        {
            pUsuario unPU = new pUsuario();
            return unPU.modificarUsuario(unDU,NUAM);
        }
    }
}
