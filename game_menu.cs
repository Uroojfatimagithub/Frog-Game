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
    public partial class game_menu : Form
    {
        public game_menu()
        {
            InitializeComponent();
            Application.OpenForms["Form1"].Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.btn_play_hover;
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.play_removebg_preview;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            level_1 l1 = new level_1();
            l1.ShowDialog();

        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.btn_exit_hover;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_removebg_preview2;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void game_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
