using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class SerieEventosDesafortunados : Evento
    {
        private List<Evento> eventos;

        public void agregarEvento(Evento evento)
        {
            eventos.Add(evento);
        }
        public void Suceder(IslaPajaro isla, int CantCerditos)
        {
            eventos.ForEach(P => P.Suceder(isla,CantCerditos));
        }
    }
}
