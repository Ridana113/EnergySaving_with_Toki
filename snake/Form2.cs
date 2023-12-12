using Microsoft.DirectX.AudioVideoPlayback;
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

namespace snake
{
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
            Start.Visible = false;
            Rules.Visible = false;
            Instruction.Visible = false;
            Fact.Visible = false;
            History.Visible = false;
            label2.Visible = false;
            pictureBox1.Visible = false;
            Yess.Visible = false;
            No.Visible = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.Stop();
            Form1 newForm = new Form1(); 
            newForm.ShowInTaskbar = false;
            newForm.Show();

        }

        private void Rules_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.ShowInTaskbar = false;
            newForm.Show();
        }

        private void Instruction_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.ShowInTaskbar = false;
            newForm.Show();
            
        }

        private void Fact_Click(object sender, EventArgs e)
        {
            fact newForm = new fact();
            newForm.ShowInTaskbar = false;
            newForm.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            History newForm = new History();
            newForm.ShowInTaskbar = false;
            newForm.Show();
        }

        private void Toki_Click(object sender, EventArgs e)
        {
            About_Toki newForm = new About_Toki();
            newForm.ShowInTaskbar = false;
            newForm.Show();
        }


        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yess_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.PlayLooping();
            Start.Visible = true;
            Rules.Visible = true;
            Instruction.Visible = true;
            Fact.Visible = true;
            History.Visible = true;
            label2.Visible = true;
            pictureBox1.Visible = true;
            intro.Visible = false; ;
            intro2.Visible = false;
            No.Visible = false;
            Yess.Visible = false;
            label1.Visible = true;
            Skip.Visible = false;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.PlayLooping();
            Start.Visible = true;
            Rules.Visible = true;
            Instruction.Visible = true;
            Fact.Visible = true;
            History.Visible = true;
            label2.Visible = true;
            pictureBox1.Visible = true;
            intro.Visible = false; ;
            intro2.Visible = false;
            No.Visible = false;
            Yess.Visible = false;
            label1.Visible = true;
            Skip.Visible = false;
            Next_story.Visible = false;
        }

        private void Next_story_Click(object sender, EventArgs e)
        {
            intro.Visible= false;
            intro2.Visible= true;
            Yess.Visible= true;
            No.Visible= true;
            Next_story.Visible = false;
        }
    }
}
