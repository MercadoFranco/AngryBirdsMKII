using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class EventoManejoIra : Evento
    {
        public void Suceder(IslaPajaro isla,int CantCerditos)
        {
            isla.mostrarPajaros().ForEach(P => P.tranquilizarse());
        }
    }
}
