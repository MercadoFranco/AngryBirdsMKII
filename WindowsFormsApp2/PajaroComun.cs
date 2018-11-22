using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace WindowsFormsApp2
{
    public abstract class PajaroComun
    {
        public int ira;
        public bool homenaje;
        [JsonIgnore]
        public IslaPajaro isla;
        [JsonIgnore]
        public Image imagen; //Esto quiero hacerlo privado, no me acuerdo por qué, pero acordate, Franco del futuro!

        public PajaroComun(int ira)
        {
            this.ira = ira;
            homenaje = true;
            isla = IslaPajaro.Instancia();
        }
        public Image Imagen()
        {
            return imagen;
        }
        public void homenajear()
        {
            homenaje = true;
        }
        public bool estaHomenajeado()
        {
            return homenaje;
        }
        virtual public void tranquilizarse()
        {
            ira -= 5;
        }
        virtual public void enojarse()
        {
            ira *= 2;
        }
        virtual public int fuerza()
        {
            return ira * 2;
        }
    }
}
