using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApp2
{
    public class Matilda : PajaroComun
    {
        public int huevos;
   
        public Matilda(int ira, int h) : base(ira)
        {
            huevos = h;
            imagen = Properties.Resources.Matilda;
        }

        public override void enojarse()
        {
            huevos++;
        }
        public override int fuerza()
        {
            return ira * 2 + huevos * 2;
        }
        public void sucederEvento(Evento evento,int cantCerditos)
        {
            evento.Suceder(isla, cantCerditos);
        }
    }
}
