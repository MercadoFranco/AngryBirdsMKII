using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class Obstaculo
    {
        protected int resistencia;
        public Image imagen; //Esto quiero hacerlo privado, no me acuerdo por qué, pero acordate, Franco del futuro!
        public int mostrarResistencia()
        {
            return resistencia;
        }
        public Image Imagen()
        {
            return imagen;
        }
        public void serDañado(int valor)
        {
            resistencia -= valor;
        }
    }
}
