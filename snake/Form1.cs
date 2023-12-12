using ImTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace snake
{
    public partial class Form1 : Form
    {
        private PictureBox[] snake = new PictureBox[300];
        private int dirtX;
        private int dirtY;
        private int sizeOfSides = 40;
        private int rI;
        private int rJ;
        private int rX;
        private int rY;
        private int rA;
        private int rB;
        private int rN;
        private int rM;
        private int rV;
        private int rC;
        private int rP;
        private int rQ;
        private int score = 0;
        private int score_start = 300;
        TimeSpan totalTime;
        public Form1()
        {
            InitializeComponent();
            dirtX = 1;
            dirtY = 0;
            Lumi.Visible = false;
            LED.Visible = false;
            Gas.Visible = false;
            Nacal.Visible = false;
            Sun_batary.Visible = false;
            Wind.Visible = false;
            totalTime = new TimeSpan(0, 0, 5, 0);
            this.Controls.Add(labelScore);
            snake[0] = new PictureBox
            {
                Location = new Point(200, 200),
                Size = new Size(sizeOfSides, sizeOfSides),
                BackColor = Color.Yellow
            };
            this.Controls.Add(snake[0]);
            GenerateLumi();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(OKP);
            timer.Tick += new EventHandler(Update);
            timer.Interval = 150;
            Taimer.Text = "Оставшееся время: " + totalTime.ToString();
            Score_time.Tick += Score_time_Tick;
            Score_time.Start();
            speed_score.Start();
        }

        private void Score_time_Tick(object sender, EventArgs e)
        {
            Score_time.Interval = 1000;
            totalTime = totalTime.Subtract(new TimeSpan(0, 0, 0, 1));
            Taimer.Text = "Оставшееся время: " + totalTime.ToString();
            if (totalTime.Minutes == 0 && totalTime.Seconds == 0)
            {
                System.Reflection.Assembly win = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = win.GetManifestResourceStream(@"snake.vin.wav");
                SoundPlayer win1 = new SoundPlayer(resorsestream);
                win1.Play();
                speed_score.Stop();
                Score_time.Stop();
                timer.Stop();
                AddLED.Stop();
                DeleteLED.Stop();
                AddNacal.Stop();
                DeleteNacal.Stop();
                AddGas.Stop();
                DeleteGas.Stop();
                AddSunBatary.Stop();
                DeleteSunBatary.Stop();
                AddWind.Stop();
                DeleteWind.Stop();
                label3.Visible = true;
                label4.Visible = true;
                label2.Visible = true;  
                Rezalt.Visible = true;
                Yess.Visible = true;
                No.Visible = true;
                Lumi.Visible = false;
                LED.Visible = false;
                Gas.Visible = false;
                Nacal.Visible = false;
                Sun_batary.Visible = false;
                Wind.Visible = false;
                snake[0].Dispose();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                Rezalt.Text = "Вам удалось сохранить: " + score_start + " баллов энергии!";
                Toki.Visible = true;
                if (score_start >= 50)
                {
                    Snake_text.Visible = true;
                }
                else if (score_start >= 25)
                {
                    Snake_text2.Visible = true;
                }
                else Snake_text3.Visible = true;
            }
        }
        private void OKP(object sender, KeyEventArgs e)
        {
            System.Reflection.Assembly pause = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = pause.GetManifestResourceStream(@"snake.pause.wav");
            SoundPlayer pause1 = new SoundPlayer(resorsestream);
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirtX = 1;
                    dirtY = 0;
                    break;
                case "Left":
                    dirtX = -1;
                    dirtY = 0;
                    break;
                case "Up":
                    dirtY = -1;
                    dirtX = 0;
                    break;
                case "Down":
                    dirtY = 1;
                    dirtX = 0;
                    break;
                case "Escape":
                    labelStop.Visible = true;
                    Score_time.Stop();
                    timer.Stop();
                    AddLED.Stop();
                    DeleteLED.Stop();
                    AddNacal.Stop();
                    DeleteNacal.Stop();
                    AddGas.Stop();
                    DeleteGas.Stop();
                    AddSunBatary.Stop();
                    DeleteSunBatary.Stop();
                    AddWind.Stop();
                    DeleteWind.Stop();
                    speed_score.Stop();
                    pause1.Play();
                    break;
                case "Space":
                    labelStop.Visible = false;
                    Score_time.Start();
                    timer.Start();
                    AddLED.Start();
                    speed_score.Start();
                    DeleteLED.Start();
                    AddNacal.Start();
                    DeleteNacal.Start();
                    AddGas.Start();
                    DeleteGas.Start();
                    AddSunBatary.Start();
                    DeleteSunBatary.Start();
                    AddWind.Start();
                    DeleteWind.Start();
                    break;

            }
        }
        private void Update(Object myObject, EventArgs eventArgs)
        {
            MoveSnake();
            Border();
            EatLumi();
            EatNacal();
            EatGas();
            EatSunBatary();
            EatWind();
            EatLED();
            int i = score_start;
            if (i < 0)
            {
                System.Reflection.Assembly badfin = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = badfin.GetManifestResourceStream(@"snake.badfin.wav");
                SoundPlayer badfin1 = new SoundPlayer(resorsestream);
                badfin1.Play();
                label5.Visible = true;
                Yess.Visible = true;
                No.Visible = true;
                timer.Stop();
                Score_time.Stop();
                AddLED.Stop();
                DeleteLED.Stop();
                AddNacal.Stop();
                DeleteNacal.Stop();
                AddGas.Stop();
                DeleteGas.Stop();
                AddLED.Stop();
                DeleteLED.Stop();
                AddSunBatary.Stop();
                DeleteSunBatary.Stop();
                AddWind.Stop();
                speed_score.Stop();
                DeleteWind.Stop();
                Lumi.Visible = false;
                LED.Visible = false;
                Gas.Visible = false;
                Nacal.Visible = false;
                Sun_batary.Visible = false;
                Wind.Visible = false;
                snake[0].Dispose();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                label2.Visible = true;
                label1.Visible = true;
            }
        }


        private void GenerateLumi()
        {
            Lumi.Visible = true;
            Random r = new Random();
            rI = r.Next(0, this.Width - sizeOfSides-10);
            int tempI = rI % sizeOfSides;
            rI -= tempI;
            rJ = r.Next(60, this.Height - sizeOfSides-140);
            int tempJ = rJ % sizeOfSides;
            rJ -= tempJ;
            Lumi.Location = new Point(rI, rJ);
            this.Controls.Add(Lumi);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rI && snake[_i].Location.Y == rJ)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateLumi();
                }
            }
        }
        private void GenerateNacal()
        {
            Nacal.Visible = true;
            Random r3 = new Random();
            rX = r3.Next(0, this.Width - sizeOfSides - 10);
            int tempX = rX % sizeOfSides;
            rX -= tempX;
            rY = r3.Next(60, this.Height - sizeOfSides - 140);
            int tempY = rY % sizeOfSides;
            rY -= tempY;
            Nacal.Location = new Point(rX, rY);
            this.Controls.Add(Nacal);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rX && snake[_i].Location.Y == rY)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateNacal();
                }
            }
        }
        private void GenerateGas()
        {
            Gas.Visible = true;
            Random r4 = new Random();
            rP = r4.Next(0, this.Width - sizeOfSides - 10);
            int tempP = rP % sizeOfSides;
            rP -= tempP;
            rQ = r4.Next(60, this.Height - sizeOfSides - 140);
            int tempQ = rQ % sizeOfSides;
            rQ -= tempQ;
            Gas.Location = new Point(rP, rQ);
            this.Controls.Add(Gas);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rP && snake[_i].Location.Y == rQ)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateGas();
                }
            }
        }
        private void GenerateLED()
        {
            LED.Visible = true;
            Random r8 = new Random();
            rM = r8.Next(0, this.Width - sizeOfSides - 10);
            int tempM = rM % sizeOfSides;
            rM -= tempM;
            rN = r8.Next(60, this.Height - sizeOfSides - 140);
            int tempN = rN % sizeOfSides;
            rN -= tempN;
            LED.Location = new Point(rM, rN);
            this.Controls.Add(LED);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rM && snake[_i].Location.Y == rN)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateLED();
                }
            }
        }
        private void GenerateSunBatary()
        {
            Sun_batary.Visible = true;
            Random r5 = new Random();
            rA = r5.Next(0, this.Width - sizeOfSides - 10);
            int tempA = rA % sizeOfSides;
            rA -= tempA;
            rB = r5.Next(60, this.Height - sizeOfSides - 140);
            int tempB = rB % sizeOfSides;
            rB -= tempB;
            Sun_batary.Location = new Point(rA, rB);
            this.Controls.Add(Sun_batary);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rA && snake[_i].Location.Y == rB)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateSunBatary();
                }
            }
        }
        private void GenerateWind()
        {
            Wind.Visible = true;
            Random r7 = new Random();
            rV = r7.Next(0, this.Width - sizeOfSides - 10);
            int tempV = rV % sizeOfSides;
            rV -= tempV;
            rC = r7.Next(60, this.Height - sizeOfSides - 140);
            int tempC = rC % sizeOfSides;
            rC -= tempC;
            Wind.Location = new Point(rV, rC);
            this.Controls.Add(Wind);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rV && snake[_i].Location.Y == rC)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateWind();
                }
            }
        }


        private void EatLumi()
        {
            if(snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                System.Reflection.Assembly good = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = good.GetManifestResourceStream(@"snake.good.wav");
                SoundPlayer good1 = new SoundPlayer(resorsestream);
                good1.Play();
                score_start = ++score_start ;
                labelScore.Text = "Баллы: " + score_start;
                ++score;
                PictureBox pictureBox = new PictureBox();
                snake[score] = pictureBox;
                snake[score].Location = new Point(snake[score - 1].Location.X+25*dirtX, snake[score - 1].Location.Y - 25 * dirtY);
                snake[score].Size = new Size(sizeOfSides, sizeOfSides);
                snake[score].BackColor = Color.Gold;
                this.Controls.Add(snake[score]);
                GenerateLumi();
                AddGas.Start();
                DeleteGas.Start();
                AddLED.Start();
                DeleteLED.Start();
                AddNacal.Start();
                DeleteNacal.Start();
                AddSunBatary.Start();
                DeleteSunBatary.Start();
                AddWind.Start();
                DeleteWind.Start();
            }
        }
        private void EatLED()
        {
            if (snake[0].Location.X == rM && snake[0].Location.Y == rN)
            {
                ++score;
                for (int i = 0; i < 3; i++)
                {
                    score_start = ++score_start;
                    labelScore.Text = "Баллы: " + score_start;
                }
                PictureBox pictureBox = new PictureBox();
                snake[score] = pictureBox;
                snake[score].Location = new Point(snake[score - 1].Location.X + 25 * dirtX, snake[score - 1].Location.Y - 25 * dirtY);
                snake[score].Size = new Size(sizeOfSides, sizeOfSides);
                snake[score].BackColor = Color.Gold;
                this.Controls.Add(snake[score]);
                System.Reflection.Assembly good = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = good.GetManifestResourceStream(@"snake.good.wav");
                SoundPlayer good1 = new SoundPlayer(resorsestream);
                good1.Play();
                rM = 0;
                rN = 0;
                this.Controls.Remove(LED);
                good1.Stop();
            }
        }
        private void EatNacal()
        {
            if (snake[0].Location.X == rX && snake[0].Location.Y == rY)
            {
                System.Reflection.Assembly bad = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = bad.GetManifestResourceStream(@"snake.bad.wav");
                SoundPlayer bad1 = new SoundPlayer(resorsestream);
                bad1.Play();
                for (int i = 0; i < 15; i++)
                {
                    score_start = --score_start;
                    labelScore.Text = "Баллы: " + score_start;
                    this.Controls.Remove(snake[score + 1]);
                }
                rX= 0;
                rY= 0;
                this.Controls.Remove(Nacal);
            }
        }
        private void EatGas()
        {
            if (snake[0].Location.X == rP && snake[0].Location.Y == rQ)
            {
                System.Reflection.Assembly bad = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = bad.GetManifestResourceStream(@"snake.bad.wav");
                SoundPlayer bad1 = new SoundPlayer(resorsestream);
                bad1.Play();
                for (int i = 0; i < 50; i++)
                {
                    score_start = --score_start;
                    labelScore.Text = "Баллы: " + score_start;
                    this.Controls.Remove(snake[score + 1]);
                }
                rP = 0;
                rQ = 0;
               this.Controls.Remove(Gas);
            }
        }
        private void EatSunBatary()
        {
            if (snake[0].Location.X == rA && snake[0].Location.Y == rB)
            {
                ++score;
                PictureBox pictureBox = new PictureBox();
                snake[score] = pictureBox;
                snake[score].Location = new Point(snake[score - 1].Location.X + 25 * dirtX, snake[score - 1].Location.Y - 25 * dirtY);
                snake[score].Size = new Size(sizeOfSides, sizeOfSides);
                snake[score].BackColor = Color.Gold;
                this.Controls.Add(snake[score]);
                System.Reflection.Assembly good = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = good.GetManifestResourceStream(@"snake.good.wav");
                SoundPlayer good1 = new SoundPlayer(resorsestream);
                good1.Play();
                for (int i = 0; i < 10; i++)
                {
                    score_start = ++score_start;
                    labelScore.Text = "Баллы: " + score_start;
                }
                rA = 0;
                rB = 0;
                this.Controls.Remove(Sun_batary);
            }
        }
        private void EatWind()
        {
            if (snake[0].Location.X == rV && snake[0].Location.Y == rC)
            {
                ++score;
                PictureBox pictureBox = new PictureBox();
                snake[score] = pictureBox;
                snake[score].Location = new Point(snake[score - 1].Location.X + 25 * dirtX, snake[score - 1].Location.Y - 25 * dirtY);
                snake[score].Size = new Size(sizeOfSides, sizeOfSides);
                snake[score].BackColor = Color.Gold;
                this.Controls.Add(snake[score]);
                System.Reflection.Assembly good = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resorsestream = good.GetManifestResourceStream(@"snake.good.wav");
                SoundPlayer good1 = new SoundPlayer(resorsestream);
                good1.Play();
                for (int i = 0; i < 15; i++)
                {
                    score_start = ++score_start;
                    labelScore.Text = "Баллы: " + score_start;
                }
                rV = 0;
                rC = 0;
                this.Controls.Remove(Wind);
            }
        }




        private void MoveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirtX * (sizeOfSides), snake[0].Location.Y + dirtY * (sizeOfSides));
            EatItSelf();
        }
        private void EatItSelf()
        {
            System.Reflection.Assembly ups = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = ups.GetManifestResourceStream(@"snake.ups.wav");
            SoundPlayer ups1 = new SoundPlayer(resorsestream);
            for ( int _i=1; _i< score; _i++)
            {
                if(snake[0].Location == snake[_i].Location)
                {
                    ups1.Play();
                    for (int _j = _i; _j <= score; _j++)
                        this.Controls.Remove(snake[_j]);
                    
                    score_start -= (score - _i + 1);
                    score -= (score - _i + 1);
                }
            }
        }
        private void Border()
        {
            System.Reflection.Assembly ups = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = ups.GetManifestResourceStream(@"snake.ups.wav");
            SoundPlayer ups1 = new SoundPlayer(resorsestream);
            if (snake[0].Location.X <0)
            {
                ups1.Play();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                for (int i = 1; i <= 50; i++)
                {
                    labelScore.Text = "Баллы: " + --score_start;
                }
                
                dirtX = 1;
            }
            if (snake[0].Location.X > this.Width-45)
            {
                ups1.Play();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                for (int i = 1; i <= 50; i++)
                {
                    labelScore.Text = "Баллы: " + --score_start;
                }
                dirtX = -1;
            }
            if (snake[0].Location.Y < 40)
            {
                ups1.Play();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                for (int i = 1; i <= 50; i++)
                {
                    labelScore.Text = "Баллы: " + --score_start;
                }
                dirtY = 1;
            }
            if (snake[0].Location.Y > this.Height-50)
            {
                ups1.Play();
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                for (int i = 1; i <= 50; i++)
                {
                    labelScore.Text = "Баллы: " + --score_start;
                }
                dirtY = -1;
            }
        }
        private void No_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly menu = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = menu.GetManifestResourceStream(@"snake.menu.wav");
            SoundPlayer menu1 = new SoundPlayer(resorsestream);
            menu1.PlayLooping();
            this.Close();
        }
        private void Yess_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly badfin = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resorsestream = badfin.GetManifestResourceStream(@"snake.badfin.wav");
            SoundPlayer badfin1 = new SoundPlayer(resorsestream);
            badfin1.Stop();
            this.Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void AddNacal_Tick(object sender, EventArgs e)
        {
            GenerateNacal();
        }
        private void DeleteNacal_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(Nacal);
            rX = 1030;
            rY = 290;
        }

        private void AddLED_Tick(object sender, EventArgs e)
        {
            GenerateLED();
        }
        private void DeleteLED_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(LED);
            rX = 1030;
            rY = 450;
        }

        private void AddGas_Tick(object sender, EventArgs e)
        {
            GenerateGas();
        }
        private void DeleteGas_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(Gas);
            rP = 1030;
            rQ = 455;
        }

        private void AddSunBatary_Tick(object sender, EventArgs e)
        {
            GenerateSunBatary();
        }
        private void DeleteSunBatary_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(Sun_batary);
            rA = 1030;
            rB = 60;
        }

        private void AddWind_Tick(object sender, EventArgs e)
        {
            GenerateWind();
        }
        private void DeleteWind_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(Wind);
            rV = 1030;
            rC = 175;
        }

        private void speed_score_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Баллы: " + --score_start;
        }

    }
}
