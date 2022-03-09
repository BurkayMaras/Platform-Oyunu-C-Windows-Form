using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace projeplatform
{
    public partial class level2 : Form
    {
        public level2()
        {
            InitializeComponent();


        }
        SoundPlayer coin_sesi = new SoundPlayer();
        string coindizin = Application.StartupPath + "\\coinsound.wav";
        SoundPlayer flag_sesi = new SoundPlayer();
        string flagdizin = Application.StartupPath + "\\flagvoice.wav";

        bool right, left, jump, rep = false, flag1 = false, door1 = false, game = false;
        int speed = 3;
        int force;
        int jumping;
        int score = 0;
        public void restart_game()//restart
        {

            restart_menu.Visible = true;
            Movement.Stop();
            Animation.Stop();
            
            
        }
        public void gameover()
        {
            game = true;
            level3 lv3 = new level3();
            lv3.ShowDialog();
        }
        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "base")
                {
                    if (x != null)
                    {
                        PictureBox temp2 = new PictureBox();
                        temp2.Bounds = x.Bounds;
                        temp2.SetBounds(temp2.Location.X, temp2.Location.Y + temp2.Height, temp2.Width, 1);
                        if (tar.Bounds.IntersectsWith(temp2.Bounds))
                            return true;
                    }
                }

            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            level2 lv2 = new level2();
            lv2.ShowDialog();
            this.Close();
            restart_menu.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            gamemenu lv1 = new gamemenu();
            lv1.ShowDialog();
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Yellow;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.DeepPink;
           
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Yellow;
           
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.DeepPink;
           
        }

        private void returnlv1_MouseEnter(object sender, EventArgs e)
        {
            returnlv1.ForeColor = System.Drawing.Color.Yellow;
        }

        private void returnlv1_MouseLeave(object sender, EventArgs e)
        {
            returnlv1.ForeColor = System.Drawing.Color.DeepPink;
        }

        private void returnlv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            level1 lv1 = new level1();
            lv1.ShowDialog();
            this.Close();
            restart_menu.Visible = false;
        }

        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "base")
                {
                    if (x != null)
                    {
                        PictureBox temp2 = new PictureBox();
                        temp2.Bounds = x.Bounds;
                        temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                        if (tar.Bounds.IntersectsWith(temp2.Bounds))
                            return true;
                    }
                }

            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "base")
                {
                    if (x != null)
                    {
                        PictureBox temp1 = new PictureBox();
                        temp1.Bounds = x.Bounds;
                        temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                        if (tar.Bounds.IntersectsWith(temp1.Bounds))
                            return true;
                    }
                }

            }
            return false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true; break;
                case Keys.Up:
                    jump = true; rep = true; break;
                case Keys.Left:
                    left = true; break;
            }
        }

        private void Animation_Tick_1(object sender, EventArgs e)
        {
            if (right == true && jump == false)
            {
                player.Image = Properties.Resources.walkinggirl;
            }
            if (left == true)
            {
                player.Image = Properties.Resources.walkingleftgirl;


            }
            if (jump == true && right == false && left == false)
            {
                player.Image = Properties.Resources.jumpinggirl;
            }
            if (jump == true && right == true)
            {
                player.Image = Properties.Resources.jumpinggirl;
            }
            if (jump == true && left == true)
            {
                player.Image = Properties.Resources.jumpingleftgirl;
            }
            if (jump == false)
            {

            }
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false; player.Image = Properties.Resources.standinggirl; break;
                case Keys.Up:
                    jump = false; rep = false; player.Image = Properties.Resources.standinggirl; break;
                case Keys.Left:
                    left = false; player.Image = Properties.Resources.standinggirl; break;
            }
        }

        private void Movement_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {

                if (player.Bounds.IntersectsWith(x.Bounds) && (string)x.Tag == "coin" && x.Visible == true)
                {
                    x.Visible = false;
                    coin_sesi.SoundLocation = coindizin;
                    coin_sesi.Stop();
                    coin_sesi.Play(); 
                    
                    score++;
                    score_label.Text = "Score:" + score;
                  


                }
            }
            if (player.Bounds.IntersectsWith(flag.Bounds) && score == 14 && flag1 == false)
            {

                flag.Image = Properties.Resources.upflag;
                flag_sesi.SoundLocation = flagdizin;
                flag_sesi.Play();
                flag1 = true;

            }
            else if (player.Bounds.IntersectsWith(flag.Bounds) && score != 14 && flag1 == false)
            {
                label4.Text = "you need " + (14 - score) + " coins more";
                label4.Visible = true;
            }
            else if (!player.Bounds.IntersectsWith(flag.Bounds))
            {
                
                label4.Visible = false;
            }
            if (flag1 == true)
            {
                door.Image = Properties.Resources.opened_door;
                door1 = true;
            }
            if (player.Bounds.IntersectsWith(door.Bounds) && door1 == true && game == false)
            {
                gameover();
            }




            if (right == true)
            {
                if (player.Left < 1000 && !Collision_Left(player))
                {
                    foreach (Control x in this.Controls)
                    {
                        if ((string)x.Tag == "base" || (string)x.Tag == "coin" || (string)x.Name == "door" || (string)x.Name == "flag" || (string)x.Tag == "ice_thorn")
                        {
                            x.Left -= speed;
                        }
                    }
                    player.Left += speed;

                }

            }

            if (left == true)
            {
                if (player.Left > 0 && !Collision_Right(player))
                {
                    foreach (Control x in this.Controls)
                    {
                        if ((string)x.Tag == "base" || (string)x.Tag == "coin" || (string)x.Name == "door" || (string)x.Name == "flag" || (string)x.Tag == "ice_thorn")
                        {
                            x.Left += speed;
                        }
                    }
                    player.Left -= speed;
                }

            }

            if (Collision_Bottom(player))
            {
                jump = false;
            }
            if (jump == true && !Collision_Bottom(player))
            {
                jumping += 1;
                player.Top -= 3;
                force = 7;
                if (jumping > 20)
                {
                    jump = false;
                }

            }
            if (jump == false)
            {
                player.Top += force;


            }

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ice_thorn")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && game == false)
                    {
                        restart_game();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "base")
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = x.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (player.Bounds.IntersectsWith(temp1.Bounds))
                    {
                        player.Top = x.Top - player.Height;

                        force = 0;

                    }
                    if (player.Bounds.IntersectsWith(temp1.Bounds) && !rep)
                    {
                        jumping = 0;
                    }
                    if (!player.Bounds.IntersectsWith(x.Bounds) && right || left)
                    {
                        force = 3;
                    }
                }

            }

        }
    }
}
