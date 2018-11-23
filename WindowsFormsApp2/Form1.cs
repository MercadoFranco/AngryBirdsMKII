using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Image red = Properties.Resources.Red;
        Image bomb = Properties.Resources.Bomb;
        Image chuck = Properties.Resources.Chuck;
        Image terrence = Properties.Resources.Terence;
        Image matilda = Properties.Resources.Matilda;
        Image cerdoObrero = Properties.Resources.CerdoObrero;
        Image cerdoCasco = Properties.Resources.CerdoCasco;
        Image cerdoEscudo = Properties.Resources.CerdoEscudo;
        Image paredVidrio = Properties.Resources.ParedVidrio;
        Image paredMadera = Properties.Resources.ParedMadera;
        Image ParedPiedra = Properties.Resources.ParedPiedra;
        int huevosAcumulados = 0;

        public Form1()
        {
            InitializeComponent();
            new IslaPajaro();
            new IslaCerdito();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtacarACerdos_Click(object sender, EventArgs e)
        {
            IslaPajaro.Instancia().atacarIslaCerdito();
            ActualizarImagenes();

        }

        private void BotonEmpezar_Click(object sender, EventArgs e)
        {
            CreacionDeBichos.Visible = true;
        }
        

        private void ListaPajarosCreacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaPajarosCreacion.SelectedIndex == 1) //Bomb
            {
                PanelHuevoMaker.Visible = false;
                PictureBoxPajaroCreacion.Image = bomb;
                TextoCambiante.Text = "Tope Fuerza:"; 
                TextoCambiante.Visible = true;
                DependePajaro.Visible = true;
                LabelIra.Visible = true;
                BoxIra.Visible = true;
            }
            else
            {
                if(ListaPajarosCreacion.SelectedIndex == 2) //Chuck
                {
                    PanelHuevoMaker.Visible = false;
                    PictureBoxPajaroCreacion.Image = chuck;
                    TextoCambiante.Text = "Velocidad: ";
                    TextoCambiante.Visible = true;
                    DependePajaro.Visible = true;
                    LabelIra.Visible = true;
                    BoxIra.Visible = true;
                }
                else
                {
                    if(ListaPajarosCreacion.SelectedIndex == 3) //Terence
                    {
                        PanelHuevoMaker.Visible = false;
                        PictureBoxPajaroCreacion.Image = terrence;
                        TextoCambiante.Text = "Multiplicador: ";
                        DependePajaro.Visible = true;
                        TextoCambiante.Visible = true;
                        LabelIra.Visible = true;
                        BoxIra.Visible = true;
                    }
                    else
                    {
                        if(ListaPajarosCreacion.SelectedIndex == 4)//Matilda
                        {
                            PictureBoxPajaroCreacion.Image = matilda;
                            PanelHuevoMaker.Visible = true;
                            TextoCambiante.Visible = false;
                            DependePajaro.Visible = false;
                            LabelIra.Visible = false;
                            BoxIra.Visible = false;
                        }
                        else // Red
                        {
                            PanelHuevoMaker.Visible = false;
                            TextoCambiante.Visible = false;
                            DependePajaro.Visible = false;
                            PictureBoxPajaroCreacion.Image = red;
                            LabelIra.Visible = true;
                            BoxIra.Visible = true;
                        }
                    }
                }
            }
            huevosAcumulados = 0;
        }
        
        private void CrearPajaro_Click(object sender, EventArgs e)
        {
            
            if (ListaPajarosCreacion.SelectedIndex == 1) //Bomb
            {
                IslaPajaro.Instancia().AgregarBomb(Int32.Parse(BoxIra.Text), Int32.Parse(DependePajaro.Text));
                ListaPajarosCreados.Items.Add("Bomb");
            }
            else
            {
                if (ListaPajarosCreacion.SelectedIndex == 2) //Chuck
                {
                    IslaPajaro.Instancia().AgregarChuck(Int32.Parse(BoxIra.Text), Int32.Parse(DependePajaro.Text));
                    ListaPajarosCreados.Items.Add("Chuck");
                }
                else
                {
                    if (ListaPajarosCreacion.SelectedIndex == 3) //Terence
                    {
                        IslaPajaro.Instancia().AgregarTerence(Int32.Parse(BoxIra.Text), Int32.Parse(DependePajaro.Text));
                        ListaPajarosCreados.Items.Add("Terence");
                    }
                    else
                    {
                        if (ListaPajarosCreacion.SelectedIndex == 4)//Matilda
                        {
                            IslaPajaro.Instancia().AgregarMatilda(Int32.Parse(BoxIra.Text), huevosAcumulados);
                            ListaPajarosCreados.Items.Add("Matilda");
                        }
                        else // Red
                        {
                            IslaPajaro.Instancia().AgregarRed(Int32.Parse(BoxIra.Text));
                            ListaPajarosCreados.Items.Add("Red");
                        }
                    }
                }
            }
            huevosAcumulados = 0;
        }

        private void ListaPajarosCreados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void ListaCerditosCreacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCerditosCreacion.SelectedIndex == 1) //Cerdo casco
            {
                PictureBoxCerditoCreacion.Image = cerdoCasco;
                ResistenciaCambiante.Visible = true;
                CreacionCerditos.Visible = true;
                ResistenciaCambiante.Text = "Resistencia Casco: ";
            }
            else
            {
                if (ListaCerditosCreacion.SelectedIndex == 2) //Cerdo Escudo
                {
                    PictureBoxCerditoCreacion.Image = cerdoEscudo;
                    ResistenciaCambiante.Visible = true;
                    CajaCerdos.Visible = true;
                    ResistenciaCambiante.Text = "Resistencia Escudo: ";
                }
                else
                {
                    if (ListaCerditosCreacion.SelectedIndex == 3) //Pared Vidrio
                    {
                        PictureBoxCerditoCreacion.Image = paredVidrio;
                        ResistenciaCambiante.Visible = true;
                        CajaCerdos.Visible = true;
                        ResistenciaCambiante.Text = "Ancho de Pared: ";
                    }
                    else
                    {
                        if (ListaCerditosCreacion.SelectedIndex == 4)//Pared Madera
                        {
                            PictureBoxCerditoCreacion.Image = paredMadera;
                            ResistenciaCambiante.Visible = true;
                            CajaCerdos.Visible = true;
                            ResistenciaCambiante.Text = "Ancho de Pared: ";
                        }
                        else 
                        {
                            if(ListaCerditosCreacion.SelectedIndex == 5)//Pared Piedra
                            {
                                PictureBoxCerditoCreacion.Image = ParedPiedra;
                                ResistenciaCambiante.Visible = true;
                                CajaCerdos.Visible = true;
                                ResistenciaCambiante.Text = "Ancho de Pared: ";
                            }
                            else //Cerdo Obrero
                            {
                                PictureBoxCerditoCreacion.Image = cerdoObrero;
                                ResistenciaCambiante.Visible = false;
                                CajaCerdos.Visible = false;
                            }
                        }
                    }
                }
            }
        }
        private void ActualizarImagenes()
        {
            for (int i = 0; i < Math.Min(IslaPajaro.Instancia().mostrarPajaros().Count(), 5); i++)
            {
                if (i == 0)
                    PictureBoxPajaroActual.BackgroundImage = IslaPajaro.Instancia().mostrarPajaros()[0].Imagen();
                else if (i == 1)
                    PictureBoxPajaro1.BackgroundImage = IslaPajaro.Instancia().mostrarPajaros()[1].Imagen();
                else if (i == 2)
                    PictureBoxPajaro2.BackgroundImage = IslaPajaro.Instancia().mostrarPajaros()[2].Imagen();
                else if (i == 3)
                    PictureBoxPajaro3.BackgroundImage = IslaPajaro.Instancia().mostrarPajaros()[3].Imagen();
                else if (i == 4)
                    PictureBoxPajaro4.BackgroundImage = IslaPajaro.Instancia().mostrarPajaros()[4].Imagen();
            }
            for (int i = 0; i < Math.Min(IslaCerdito.Instancia().mostrarCerditos().Count(), 6); i++)
            {
                if (i == 0)
                    PictureBoxCerditoActual.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[0].Imagen();
                else if (i == 1)
                    PictureBoxCerdito1.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[1].Imagen();
                else if (i == 2)
                    PictureBoxCerdito2.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[2].Imagen();
                else if (i == 3)
                    PictureBoxCerdito3.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[3].Imagen();
                else if (i == 4)
                    PictureBoxCerdito4.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[4].Imagen();
                else if (i == 5)
                    PictureBoxCerdito5.BackgroundImage = IslaCerdito.Instancia().mostrarCerditos()[5].Imagen();
            }
            if (Math.Min(IslaPajaro.Instancia().mostrarPajaros().Count(), 5) != 5)
            {
                for (int i = IslaPajaro.Instancia().mostrarPajaros().Count(); i < 5; i++)
                {
                    if (i == 0)
                        PictureBoxPajaroActual.BackgroundImage = null;
                    else if (i == 1)
                        PictureBoxPajaro1.BackgroundImage = null;
                    else if (i == 2)
                        PictureBoxPajaro2.BackgroundImage = null;
                    else if (i == 3)
                        PictureBoxPajaro3.BackgroundImage = null;
                    else if (i == 4)
                        PictureBoxPajaro4.BackgroundImage = null;
                }
            }
            if (Math.Min(IslaCerdito.Instancia().mostrarCerditos().Count(), 6) != 6)
            {
                for (int i = IslaCerdito.Instancia().mostrarCerditos().Count(); i < 6; i++)
                {
                    if (i == 0)
                        PictureBoxCerditoActual.BackgroundImage = null;
                    else if (i == 1)
                        PictureBoxCerdito1.BackgroundImage = null;
                    else if (i == 2)
                        PictureBoxCerdito2.BackgroundImage = null;
                    else if (i == 3)
                        PictureBoxCerdito3.BackgroundImage = null;
                    else if (i == 4)
                        PictureBoxCerdito4.BackgroundImage = null;
                    else if (i == 5)
                        PictureBoxCerdito5.BackgroundImage = null;
                }
            }
            if (IslaCerdito.Instancia().mostrarCerditos().Count() > 0)
                LabelVidaCerdito.Text = IslaCerdito.Instancia().mostrarCerditos()[0].mostrarResistencia().ToString();
            if (IslaPajaro.Instancia().mostrarPajaros().Count() > 0) 
            {
                LabelVidaPajaro.Text = IslaPajaro.Instancia().mostrarPajaros()[0].fuerza().ToString();
            }
        }
        private void IrPelearDesdeCerditos_Click(object sender, EventArgs e)
        {
            MenuCombate.Visible = true;
            ActualizarImagenes();
        }

        private void MenuCombate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IrCerdosDesdePajaros_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = true;
            MenuCombate.Visible = false;
        }

        public void BoxIra_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarHuevo_Click(object sender, EventArgs e)
        {
            huevosAcumulados += Int32.Parse(PesoHuevos.Text);
        }

        private void BotonCrearCerdo_Click(object sender, EventArgs e)
        {
            if (ListaCerditosCreacion.SelectedIndex == 1) //Cerdo casco
            {
                IslaCerdito.Instancia().AgregarCerditoCasco(Int32.Parse(CajaCerdos.Text));
                ListaCreacionCerdos.Items.Add("Cerdo Casco");
            }
            else
            {
                if (ListaCerditosCreacion.SelectedIndex == 2) //Cerdo Escudo
                {
                    IslaCerdito.Instancia().AgregarCerditoEscudo(Int32.Parse(CajaCerdos.Text));
                    ListaCreacionCerdos.Items.Add("Cerdo Escudo");
                }
                else
                {
                    if (ListaCerditosCreacion.SelectedIndex == 3) //Pared Vidrio
                    {
                        IslaCerdito.Instancia().AgregarParedVidrio(Int32.Parse(CajaCerdos.Text));
                        ListaCreacionCerdos.Items.Add("Pared Vidrio");
                    }
                    else
                    {
                        if (ListaCerditosCreacion.SelectedIndex == 4)//Pared Madera
                        {
                            IslaCerdito.Instancia().AgregarParedMadera(Int32.Parse(CajaCerdos.Text));
                            ListaCreacionCerdos.Items.Add("Pared Madera");
                        }
                        else
                        {
                            if (ListaCerditosCreacion.SelectedIndex == 5)//Pared Piedra
                            {
                                IslaCerdito.Instancia().AgregarParedPiedra(Int32.Parse(CajaCerdos.Text));
                                ListaCreacionCerdos.Items.Add("Pared Piedra");
                            }
                            else //Cerdo Obrero
                            {
                                IslaCerdito.Instancia().AgregarCerditoObrero();
                                ListaCreacionCerdos.Items.Add("Cerdito Obrero");
                            }
                        }
                    }
                }
            }
        }
        private void IrPajarosDesdeCerditos_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = false;
            CreacionDeBichos.Visible = true;
        }

        private void IrPelearDesdePajaros_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = true;
            MenuCombate.Visible = true;
        }

        private void IrCerdosDesdeCombate_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = true;
            MenuCombate.Visible = false;
        }

        private void IrPajarosDesdeCombate_Click(object sender, EventArgs e)
        {

            CreacionCerditos.Visible = false;
            MenuCombate.Visible = false;
        }
    }
}
