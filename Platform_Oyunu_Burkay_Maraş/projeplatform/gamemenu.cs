using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeplatform
{
    public partial class gamemenu : Form
    {
        public gamemenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            level1 lv1 = new level1();
            

            lv1.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            playbutton.Image = Properties.Resources.playbuttonhover;

        }

        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.Image = Properties.Resources.playbutton;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            exitbutton.Image = Properties.Resources.exitbuttonhover;
        }

        private void exitbutton_MouseLeave(object sender, EventArgs e)
        {
            exitbutton.Image = Properties.Resources.exitbutton;
        }
    }
}
