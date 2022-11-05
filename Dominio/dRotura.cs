using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dRotura
    {
        public eRotura RecrearRot(String id)
        {
            eRotura unaRot = new eRotura();
            pRotura unaRotP = new pRotura();
           unaRot = unaRotP.recrearRot(id);

            throw new NotImplementedException();
        }
    }
}
