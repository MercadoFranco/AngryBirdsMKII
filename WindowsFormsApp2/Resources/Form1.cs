using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BotonEmpezar_Click(object sender, EventArgs e)
        {
            CreacionDeBichos.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                    }
                    else
                    {
                        if(ListaPajarosCreacion.SelectedIndex == 4)//Matilda
                        {
                            PictureBoxPajaroCreacion.Image = matilda;
                            PanelHuevoMaker.Visible = true;
                            TextoCambiante.Visible = false;
                            DependePajaro.Visible = false;
                        }
                        else // Red
                        {
                            PanelHuevoMaker.Visible = false;
                            TextoCambiante.Visible = false;
                            DependePajaro.Visible = false;
                            PictureBoxPajaroCreacion.Image = red;
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BoxListaHuevos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CrearPajaro_Click(object sender, EventArgs e)
        {
            //Crear nuevo pájaro, usando los cosos. Pero no hay isla, así que todavía no xdXDXDXDxdXDXdxxdDXdxxdXDdxxdxd
        }

        private void ListaPajarosCreados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonIrCerdos_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = true;
            CreacionDeBichos.Visible = false;
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

        private void BotonPelear_Click(object sender, EventArgs e)
        {
            MenuCombate.Visible = true;
        }

        private void MenuCombate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IrCerdos_Click(object sender, EventArgs e)
        {
            CreacionCerditos.Visible = true;
        }
    }
}
