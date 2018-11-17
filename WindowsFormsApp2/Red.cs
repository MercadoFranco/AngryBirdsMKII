using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Red : PajaroComun
    {
        protected int cantEnojado;

        public Red(int ira) : base(ira)
        {
            cantEnojado = 0;
            imagen = Properties.Resources.Red;
        }

        public override int fuerza()
        {
            return ira * 10 * Math.Max(1, cantEnojado);
        }
    }
}
