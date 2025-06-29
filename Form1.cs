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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                progressBar1.Increment(2);
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                game_menu option = new game_menu();
                option.ShowDialog();
            }
        }
    }
}
