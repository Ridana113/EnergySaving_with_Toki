using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace snake
{
    public partial class History : Form
    {
        public int n = 1;
        public History()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.PlayLooping();
            this.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.PlayLooping();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            n += 1;
            pictureBox1.ImageLocation = @"D:\Snake 2.0\smal.icon_and_others\pages\" + n + ".jpg";
            if(n==2) Back_page.Visible = true;
            if (n == 8) 
            {
                Back.Visible = true;
                Next.Visible = false;
            } 
        }

        private void Back_page_Click(object sender, EventArgs e)
        {
            n -= 1;
            Back.Visible = false;
            Next.Visible = true;
            pictureBox1.ImageLocation = @"D:\Snake 2.0\smal.icon_and_others\pages\" + n + ".jpg";
            if (n == 1)
            {
                Back_page.Visible = false;    
            }
        }
    }
}
