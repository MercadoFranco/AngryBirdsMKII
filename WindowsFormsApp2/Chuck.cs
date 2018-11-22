using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Chuck : PajaroComun
    {
        public int velocidad;

        public Chuck(int ira, int velocidad) : base(ira)
        {
            this.velocidad = velocidad;
            imagen = Properties.Resources.Chuck;
        }

        public override void tranquilizarse() { }
        public override void enojarse()
        {
            velocidad *=2;
        }
        public override int fuerza()
        {
            return 150 + ((Math.Max(velocidad, 80) - 80) * 5);
        }
    }
}
