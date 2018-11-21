using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class IslaCerdito
    {
        private List<CerditoArmado> cerditosCasco = new List<CerditoArmado>();
        private List<CerditoArmado> cerditosEscudo = new List<CerditoArmado>();
        private List<CerditoObrero> cerditosObreros = new List<CerditoObrero>();
        private List<ParedMadera> paredesMadera = new List<ParedMadera>();
        private List<ParedPiedra> paredesPiedra = new List<ParedPiedra>();
        private List<ParedVidrio> paredesVidrio = new List<ParedVidrio>();
        private List<Obstaculo> obstaculos = new List<Obstaculo>();
        private static IslaCerdito instancia;

        public static IslaCerdito Instancia()
        {
            return instancia;
        }
        public IslaCerdito()
        {
            instancia = this;
        }

        public bool serAtacado(PajaroComun pajaro) //Se modifico el tipo del método ya que se requiere que devuelva un valor para verificar en isla pajaro si hay algun obstaculo a atacar y evitar que el pajaro ataque sin haber algun obstaculo.
        {
            if (obstaculos.Count() > 0) //Se agregó un if porque en caso de cagarse a piñas los bichos y que no haya cerditos, se rompe todo.
            {
                obstaculos.First().serDañado(pajaro.fuerza());
                if (obstaculos.First().mostrarResistencia() <= 0)
                    obstaculos.Remove(obstaculos.First());
                return true;
            }
            return false;
        }
        public List<Obstaculo> mostrarCerditos()
        {
            return obstaculos;
        }
        public void AgregarCerditoObrero()
        {
            cerditosObreros.Add(new CerditoObrero());
            obstaculos.Add(new CerditoObrero());
        }
        public void AgregarCerditoCasco(int resistEquipo)
        {
            cerditosCasco.Add(new CerditoArmado(resistEquipo,1)); //El numero es una solucion barata que se me ocurrió xd
            obstaculos.Add(new CerditoArmado(resistEquipo, 1));
        }
        public void AgregarCerditoEscudo(int resistEquipo)
        {
            cerditosEscudo.Add(new CerditoArmado(resistEquipo,2));//Sin el numero, ambos tendrían la misma imagen
            obstaculos.Add(new CerditoArmado(resistEquipo, 2));
        }
        public void AgregarParedMadera(int ancho)
        {
            paredesMadera.Add(new ParedMadera(ancho));
            obstaculos.Add(new ParedMadera(ancho));
        }
        public void AgregarParedPiedra(int ancho)
        {
            paredesPiedra.Add(new ParedPiedra(ancho));
            obstaculos.Add(new ParedPiedra(ancho));
        }
        public void AgregarParedVidrio(int ancho)
        {
            paredesVidrio.Add(new ParedVidrio(ancho));
            obstaculos.Add(new ParedVidrio(ancho));
        }
    }
}
