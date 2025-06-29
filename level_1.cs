using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class level_1 : Form
    {
        public level_1()
        {
            InitializeComponent();
            lbl_over.Visible = false;
        }
        bool right, left, jump, hold;
        int jump_speed = 1;
        int enemy_speed = 1;
        Random rnd = new Random(); 
        int spide_speed = 1, spd;

        private void level_1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int frog_score, spider_score, p;
        void Game_logic()
        {
            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && string.Equals(x.Tag as string, "fly"))
            //    {
            //        x.Top -= 1;
            //        if (x.Top < 200)
            //        {
            //            x.Top = 200;
            //        }
            //    }
            //}
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString().Contains("fly"))
                {
                    if (x.Tag.ToString().EndsWith("up"))
                    {
                        x.Top -= 2;
                        if (x.Top <= 200)
                            x.Tag = "fly_down";
                    }
                    else if (x.Tag.ToString().EndsWith("down"))
                    {
                        x.Top += 2;
                        if (x.Top >= 200)
                            x.Tag = "fly_up";
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        frog_score += 1;
                        lbl_frog_score.Text = "Frog : " + frog_score;
                        p = rnd.Next(100, 1200);
                        x.Location = new Point(p, 500);
                    }
                    if (spider.Bounds.IntersectsWith(x.Bounds))
                    {
                        spider_score += 5;
                        lbl_spider_score.Text = "Spider : " + spider_score;
                        p = rnd.Next(100, 1200);
                        x.Location = new Point(p, 500);
                    }
                    if (player.Bounds.IntersectsWith(enemy.Bounds) || player.Bounds.IntersectsWith(spider.Bounds))
                    {

                        timer1.Stop();
                        lbl_over.Visible = true;
                        lbl_over.BringToFront();
                    }
                }
            }
        }
        void Enemies_movement ()
        {
        if(enemy.Left>500)
        {
        enemy_speed -= 1;
        }
        if(enemy.Left<50)
        {
        enemy_speed= 1;
        }
        enemy. Left += enemy_speed;
            if(spider.Top>10)
            {
            spide_speed -= 2;
            }
            if (spider.Top < -200)
            {
                spd = rnd.Next(0, 450);
                spider.Location = new Point(spd, -200);
                spide_speed = 2;
            }
            spider. Top+= spide_speed;
        }

        void player_movement()
        {

            if (right == true)
            {
                player.Left += 2;
                player.Image = Properties.Resources.ideal_right_img;
            }
            if (left == true)
            {
                player.Left -= 2;
                player.Image = Properties.Resources.ideal_left_img;
            }
            if (jump == true && right)
            {
                player.Top -= 4;
                player.Left += 3;
                player.Image = Properties.Resources.ideal_right_img;
                jump_speed = 3;
            }
            if (jump == true && left)
            {
                player.Top -= 4;
                player.Left -= 3;
                player.Image = Properties.Resources.ideal_left_img;
                jump_speed = 3;
            }
            if(jump==false)
                {
                player.Top += jump_speed;
                if(player.Bounds. IntersectsWith(ground. Bounds))
                {
                    player. Top= ground. Top - player.Height; 
                    jump_speed= 0;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void level_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys. Right)
            {
            right = true;
            }

            if (e.KeyCode==Keys.Left)
            {
            left = true;
            }
            if (e.KeyCode==Keys.Space&hold)
            {
            jump = true;
            hold = false;
            }
        }

        private void level_1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void level_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space & ! hold)
            {
                jump = false;
                hold = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player_movement();
            Enemies_movement();
            Game_logic();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
