using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool goup, godown, goleft, goright=false;
        PictureBox[] pictureBoxes;
        Panel[] panels;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
            pictureBoxes = new PictureBox[10]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10,

            };
            panels = new Panel[2]
            {
                panel14,
                panel3

            };
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(goup) 
            {
             pacman.Top -= 5; 
            }
            if (godown)
            {
                pacman.Top += 5;
            }
            if (goright)
            {
                pacman.Left += 5;
            }
            if (goleft)
            {
                pacman.Left -= 5;
            }
            for (int i = 0; i < 10; i++)
            {
                if (pacman.Bounds.IntersectsWith(pictureBoxes[i].Bounds))
                {
                    pictureBoxes[i].Visible = false;

                }


            }
            for (int i = 0; i < 2; i++)
            {
                if (pacman.Bounds.IntersectsWith(panels[i].Bounds))
                {
                    goup = godown = goleft = goright = false;

                }


            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    goup = false;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = false;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    goleft = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goright = false;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                goup=godown=goleft=goright=false;
                if (e.KeyCode == Keys.Up)
                {
                    goup = true;
                    pacman.Image = Properties.Resources.pacmanup;
                }
                if (e.KeyCode == Keys.Down)
                {
                    godown = true;
                    pacman.Image = Properties.Resources.pacmandown;
                }
                if (e.KeyCode == Keys.Left)
                {
                    goleft = true;
                    pacman.Image = Properties.Resources.pacmanleft;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goright = true;
                    pacman.Image = Properties.Resources.pacman;

                }
            }
        }
    }
}
