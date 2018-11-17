using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ParedVidrio : Obstaculo
    {
        public ParedVidrio(int ancho)
        {
            resistencia = 10 * ancho;
            imagen = Properties.Resources.ParedVidrio;
        }
    }
}
