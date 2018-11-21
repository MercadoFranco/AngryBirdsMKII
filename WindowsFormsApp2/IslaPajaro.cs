using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class IslaPajaro
    {
        private List<Red> pajarosRed = new List<Red>();
        private List<Bomb> pajarosBomb = new List<Bomb>();
        private List<Matilda> pajarosMatilda = new List<Matilda>();
        private List<Chuck> pajarosChuck = new List<Chuck>();
        private List<Terence> pajarosTerence = new List<Terence>();
        private List<PajaroComun> pajaros = new List<PajaroComun>();
        private static IslaPajaro instancia;

        public static IslaPajaro Instancia()
        {
            return instancia;
        }

        public IslaPajaro()
        {
            instancia = this;
        }

        public List<PajaroComun> mostrarPajarosFuertes()
        {
            return (List<PajaroComun>)pajaros.Where(P => P.fuerza() > 50);
        }

        public List<PajaroComun> mostrarPajaros()
        {
            return pajaros;
        }
        public int fuerza()
        {
            return pajaros.Sum(P => P.fuerza());
        }
        public void atacarIslaCerdito()
        {
            if (pajaros.Count() > 0) //Se agregó un if porque en caso de cagarse a piñas los bichos y que no haya pajaros, se rompe todo.
            {
                if (IslaCerdito.Instancia().serAtacado(pajaros.First()))
                    pajaros.Remove(pajaros.First());
            }
        }

        public void AgregarBomb(int ira, int tope)
        {
            pajarosBomb.Add(new Bomb(ira, tope));
            pajaros.Add(new Bomb(ira, tope));
        }
        public void AgregarChuck(int ira, int velocidad)
        {
            pajarosChuck.Add(new Chuck(ira, velocidad));
            pajaros.Add(new Chuck(ira, velocidad));
        }
        public void AgregarTerence(int ira, int multiplicador)
        {
            pajarosTerence.Add(new Terence(ira, multiplicador));
            pajaros.Add(new Terence(ira, multiplicador));
        }
        public void AgregarRed(int ira)
        {
            pajarosRed.Add(new Red(ira));
            pajaros.Add(new Red(ira));
        }
        public void AgregarMatilda(int ira, int pesoHuevos)
        {
            pajarosMatilda.Add(new Matilda(ira,pesoHuevos));
            pajaros.Add(new Matilda(ira, pesoHuevos));
        }
    }
}
