using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Red);
            SolidBrush drawbrush = new SolidBrush(Color.Yellow);
            SolidBrush drawbrush1 = new SolidBrush(Color.Black);
            Font drawFont = new Font("Courier New", 16, FontStyle.Bold);
            g.DrawString("player 1 get ready!",drawFont,drawbrush,10,50);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //declaration of Vars
            Graphics g = this.CreateGraphics();
            SolidBrush pacmanbrush = new SolidBrush(Color.Yellow);
            SolidBrush pathbrush = new SolidBrush(Color.Blue);
            SoundPlayer chomp = new SoundPlayer(Properties.Resources.chomp);
            SoundPlayer begin = new SoundPlayer(Properties.Resources.begin);

            //play game intro sound
            begin.Play();
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);

            //delay drawing packman till after intro song
            Thread.Sleep(5000);
            g.FillPie(pacmanbrush, 40, 85, 70, 70, 30, 300);
            chomp.Play();
            Thread.Sleep(500);
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);

            //draw packman in new position with alternated mouth position and then play chomp.wav for sound
            g.FillEllipse(pacmanbrush, 135, 85, 70, 70);
            chomp.Play();
            Thread.Sleep(500);

            //delay movement by 1/2 secconds to allow for smooth visual then clear screen for new frame
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);

            //use same formula
            g.FillPie(pacmanbrush, 230, 85, 70, 70, 30, 300);
            chomp.Play();
            Thread.Sleep(500);
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);

            //use same formula
            g.FillEllipse(pacmanbrush, 325, 85, 70, 70);
            chomp.Play();
            Thread.Sleep(500);
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);

            //use same formula
            g.FillPie(pacmanbrush, 423, 85, 70, 70, 30, 300);
            chomp.Play();
            Thread.Sleep(500);

            //use same formula
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);
            g.FillEllipse(pacmanbrush, 522, 85, 70, 70);
            chomp.Play();
            Thread.Sleep(500);

            //use same formula
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);
            g.FillPie(pacmanbrush, 615, 85, 70, 70, 30, 300);
            chomp.Play();
            Thread.Sleep(500);

            //use same formula
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);
            g.FillPie(pacmanbrush, 615, 185, 70, 70, 120, 300);
            chomp.Play();
            Thread.Sleep(500);

            //use same formula
            g.Clear(Color.Black);
            g.FillRectangle(pathbrush, 40, 60, 650, 20);
            g.FillRectangle(pathbrush, 40, 160, 550, 20);
            g.FillRectangle(pathbrush, 690, 60, 20, 420);
            g.FillRectangle(pathbrush, 590, 160, 20, 300);
            g.FillEllipse(pacmanbrush, 615, 285, 70, 70);
            chomp.Play();
        }
    }
}
