using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Data;
using System.Windows.Forms;

namespace Dominio
{
    public class dRotura
    {
        public eEquipo RecrearRot(String id)
        {
            eEquipo unEq = new eEquipo();
            pRotura unaRotP = new pRotura();
            unEq = unaRotP.recrearRot(id);

            return unEq;
        }

        public DataTable ListaRoturas()
        {
           
            pRotura unaRotP = new pRotura();
            DataTable dt = unaRotP.ListarRot();
            return dt;
        }

        public bool bajaRotura(String id)
        {
            pRotura unPRo = new pRotura();
            bool token = unPRo.bajaRatura(id);
            throw new NotImplementedException();


        }

        public int altaRotura(eEquipo unEq, String prestamoId)
        {
            pRotura pRot = new pRotura();
            int token = pRot.altaRotura(unEq, prestamoId);


            return token;
        }

        public int modificacionRotura(eEquipo unEq, string prestamoId)
        {
            pRotura pRot = new pRotura();
            int token = pRot.modificacionRotura(unEq, prestamoId);


            return token;
        }
    }
}
