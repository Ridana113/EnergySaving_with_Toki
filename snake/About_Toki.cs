using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class About_Toki : Form
    {
        public About_Toki()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hranitel_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = true;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = true;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void Water_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = true;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void Nature_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = true;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void Ancient_Rule_Click(object sender, EventArgs e)
        {
            rule.Visible = true;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible= false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void mag_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = true;
            snake_vid.Visible = false;
            wind_story.Visible = false;
        }

        private void Toki_story_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = true;
            wind_story.Visible = false;
        }

        private void Wind_Click(object sender, EventArgs e)
        {
            rule.Visible = false;
            Adam.Visible = false;
            Akva_story.Visible = false;
            Fire_story.Visible = false;
            pictureBox1.Visible = false;
            Hranitel_story.Visible = false;
            snake_mag.Visible = false;
            snake_vid.Visible = false;
            wind_story.Visible = true;
        }
    }
}
