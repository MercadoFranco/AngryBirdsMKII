using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Bomb : PajaroComun
    {
        private int fuerzaMax;
        
        public Bomb(int ira, int fMax) : base(ira)
        {
            fuerzaMax = fMax;
            imagen = Properties.Resources.Chuck;
        }

        public void cambiarFuerza(int nuevaFuerzaMax)
        {
            fuerzaMax = nuevaFuerzaMax;
        }
        public override int fuerza()
        {
            return Math.Min(ira * 2,fuerzaMax);
        }
    }
}
