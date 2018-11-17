using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class FiestaSorpresa : Evento
    {
        public void Suceder(IslaPajaro isla, int CantCerditos)
        {
            ((List<PajaroComun>) isla.mostrarPajaros().Where(P => P.estaHomenajeado() == true)).ForEach(P=>P.enojarse());
        }
    }
}
