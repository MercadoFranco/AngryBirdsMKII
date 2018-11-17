using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class InvasionCerdos : Evento
    {
        private int cantCerditos;

        public void Suceder(IslaPajaro isla, int cantCerditos)
        {
            this.cantCerditos += cantCerditos;
            if (this.cantCerditos > 99)
            {
                isla.mostrarPajaros().ForEach(P => P.enojarse());
                cantCerditos -= 100;
            }
        }
    }
}
