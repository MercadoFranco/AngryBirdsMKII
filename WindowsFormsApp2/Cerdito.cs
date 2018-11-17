using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Cerdito
    {
        int ResEquipo;
        int tipoCerdito;
        Cerdito(int ResEquipo,int tipoCerdito)
        {
            this.ResEquipo = ResEquipo;
            this.tipoCerdito = tipoCerdito;
        }

        public int Resistencia()
        {
           return 10 * ResEquipo;
        }
    }
}
