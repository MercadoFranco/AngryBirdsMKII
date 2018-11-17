using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ParedPiedra : ParedVidrio
    {
        public ParedPiedra(int ancho) : base(ancho)
        {
            resistencia = 50 * ancho;
            imagen = Properties.Resources.ParedPiedra;
        }
    }
}
