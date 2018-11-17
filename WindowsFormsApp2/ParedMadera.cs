using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ParedMadera : ParedVidrio
    {
        public ParedMadera(int ancho) : base(ancho)
        {
            resistencia = 25 * ancho;
            imagen = Properties.Resources.ParedMadera;
        }
    }
}
