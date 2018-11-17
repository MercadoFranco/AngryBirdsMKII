using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CerditoArmado : CerditoObrero
    {
        public CerditoArmado(int resistenciaEquipo, int tipo)//1 es con casco, 2 es con escudo
        {
            resistencia = 10 * resistenciaEquipo;
            imagen = AsignarImagen(tipo);
        }
        private Image AsignarImagen(int tipo)
        {
            return tipo == 1 ? Properties.Resources.CerdoCasco: Properties.Resources.CerdoEscudo;
        }
    }
}