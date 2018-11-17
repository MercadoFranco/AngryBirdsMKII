using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Terence : Red
    {
        private int multiplicador;

        public Terence(int ira, int multi) : base(ira)
        {
            multiplicador = multi;
            imagen = Properties.Resources.Terence;
        }

        public override int fuerza()
        {
            return ira * Math.Max(1, cantEnojado * multiplicador);
        }
    }
}
