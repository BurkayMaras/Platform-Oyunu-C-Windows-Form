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
    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
            

        }
        SoundPlayer coin_sesi = new SoundPlayer();
        string coindizin = Application.StartupPath + "\\coinsound.wav";
        SoundPlayer flag_sesi = new SoundPlayer();
        string flagdizin = Application.StartupPath + "\\flagvoice.wav";
        
        bool right, left, jump, rep=false, flag1=false ,door1=false, game=false;
        int speed = 2;
        int force;
        int jumping;
        int score = 0;
        
        public void nextlevel()
        {
            this.Hide();
            game = true;
            level2 level2 = new level2();

            level2.ShowDialog();
           
            this.Close();
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
                    right = true;  break;
                case Keys.Up:
                    jump = true; rep = true; break;
                case Keys.Left:
                    left = true;   break;
            }
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (right == true&&jump==false)
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
            if (jump == true && right==true)
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

        private void timer1_Tick(object sender, EventArgs e)
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
                if (player.Bounds.IntersectsWith(flag.Bounds) && score==12 && flag1==false)
                {
                        
                        flag.Image = Properties.Resources.upflag;
                        flag_sesi.SoundLocation = flagdizin;
                        flag_sesi.Play();
                        flag1 = true;
                    
                }
                if (flag1==true)
                {
                    door.Image = Properties.Resources.opened_door;
                door1 = true;
                }
                if(player.Bounds.IntersectsWith(door.Bounds)&& door1==true && game==false)
                {
                    nextlevel();
                }



            
            if (right == true)
            {
                if (player.Left < 800 && !Collision_Left(player)&&door.Left>=685)
                {
                    foreach(Control x in this.Controls)
                    {
                        if ((string)x.Tag == "base"||(string)x.Tag=="coin" || (string)x.Name == "door"||(string)x.Name=="flag")
                        {
                            x.Left -= speed;
                        }
                    }
                    player.Left += speed;

                }
                else if(door.Left <= 685)
                {
                    player.Left += speed;
                }

            }
            
            if (left == true)
            {
                if (player.Left > 0 && !Collision_Right(player))
                {
                    foreach (Control x in this.Controls)
                    {
                        if ((string)x.Tag == "base" || (string)x.Tag == "coin"||(string)x.Name=="door" || (string)x.Name == "flag")
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
