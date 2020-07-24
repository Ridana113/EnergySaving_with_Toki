using ImTools;
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
    public partial class Form1 : Form
    {
        private PictureBox[] snake = new PictureBox[300];
        private int dirtX;
        private int dirtY;
        private int sizeOfSides = 20;
        private int rI;
        private int rJ;
        private int rI1;
        private int rJ1;
        private int rX;
        private int rZ;
        private int rP;
        private int rQ;
        private int score = 0;
        private Label labelScore;
        public Form1()
        {
            InitializeComponent();
            dirtX = 1;
            dirtY = 0;
            labelScore = new Label
            {
                Text = "Score: 0",
                Location = new Point(550, 10),
                BackColor = Color.Transparent
            };
            this.Controls.Add(labelScore);
            snake[0] = new PictureBox
            {
                Location = new Point(200, 200),
                Size = new Size(sizeOfSides, sizeOfSides),
                BackColor = Color.Yellow
            };
            this.Controls.Add(snake[0]);
            GenerateBird();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(OKP);
            timer.Tick += new EventHandler(Update);
            timer.Interval = 200;


        }
        private void OKP(object sender, KeyEventArgs e)
        {
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
            }
        }
        private void Update(Object myObject, EventArgs eventArgs)
        {
            MoveSnake();
            EatBird();
            Border();
            EatBird_2();
            EatBird_3();
            int i = score;
            EatSkull();
            if (i >= 150)
            {
                label3.Visible = true;
                label4.Visible = true;
                Yess.Visible = true;
                No.Visible = true;
                timer.Stop();
                AddBird_2.Stop();
                DeleteBird_2.Stop();
                AddBird_3.Stop();
                DeleteBird_3.Stop();
                AddSkull.Stop();
                label2.Visible = true;
            }
        }
        private void GenerateBird()
        {
            Random r = new Random();
            rI = r.Next(0, 632 - sizeOfSides);
            int tempI = rI % sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, 642 - sizeOfSides);
            int tempJ = rJ % sizeOfSides;
            rJ -= tempJ;
            bird.Location = new Point(rI, rJ);
            this.Controls.Add(bird);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rI && snake[_i].Location.Y == rJ)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateBird();
                }
            }
        }
        private void GenerateBird_2()
        {
            Random r2 = new Random();
            rI1 = r2.Next(0, 632 - sizeOfSides);
            int tempI1 = rI1 % sizeOfSides;
            rI1 -= tempI1;
            rJ1 = r2.Next(0, 642 - sizeOfSides);
            int tempJ1 = rJ1 % sizeOfSides;
            rJ1 -= tempJ1;
            bird_2.Location = new Point(rI1, rJ1);
            this.Controls.Add(bird_2);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rI1 && snake[_i].Location.Y == rJ1)
                {
                     this.Controls.Add(snake[_i]);
                     GenerateBird_2();
                }
            }
        }
    
        private void GenerateBird_3()
        {
            Random r3 = new Random();
            rX = r3.Next(0, 632 - sizeOfSides);
            int tempX = rX % sizeOfSides;
            rX -= tempX;
            rZ = r3.Next(0, 642 - sizeOfSides);
            int tempZ = rZ % sizeOfSides;
            rZ -= tempZ;
            bird_3.Location = new Point(rX, rZ);
            this.Controls.Add(bird_3);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rX && snake[_i].Location.Y == rZ)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateBird_3();
                }
            }
        }

        private void GenerateSkull()
        {
            Random r4 = new Random();
            rP = r4.Next(0, 642 - sizeOfSides);
            int tempP = rP % sizeOfSides;
            rP -= tempP;
            rQ = r4.Next(0, 642 - sizeOfSides);
            int tempQ = rQ % sizeOfSides;
            rQ -= tempQ;
            skull.Location = new Point(rP, rQ);
            this.Controls.Add(skull);
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[_i].Location.X == rP && snake[_i].Location.Y == rQ)
                {
                    this.Controls.Add(snake[_i]);
                    GenerateSkull();
                }
            }
        }
            private void EatBird()
        {
            if(snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                labelScore.Text = "Score: " + ++score;
                PictureBox pictureBox = new PictureBox();
                snake[score] = pictureBox;
                snake[score].Location = new Point(snake[score - 1].Location.X+20*dirtX, snake[score - 1].Location.Y - 20 * dirtY);
                snake[score].Size = new Size(sizeOfSides, sizeOfSides);
                snake[score].BackColor = Color.Gold;
                this.Controls.Add(snake[score]);
                GenerateBird();
                AddSkull.Start();
                DeleteSkull.Start();
                AddBird_2.Start();
                DeleteBird_2.Start();
                AddBird_3.Start();
                DeleteBird_3.Start();
            }
        }
        private void EatBird_2()
        {
            if (snake[0].Location.X == rI1 && snake[0].Location.Y == rJ1)
            {
                for (int i = 0; i < 5; i++)
                {
                    labelScore.Text = "Score: " + ++score;
                    snake[score] = new PictureBox
                    {
                        Location = new Point(snake[score - 1].Location.X + 20 * dirtX, snake[score - 1].Location.Y - 20 * dirtY),
                        Size = new Size(sizeOfSides, sizeOfSides),
                        BackColor = Color.Gold
                    };
                    this.Controls.Add(snake[score]);
                }
                this.Controls.Remove(bird_2);
            }
        }
        private void EatBird_3()
        {
            if (snake[0].Location.X == rX && snake[0].Location.Y == rZ)
            {
                labelScore.Text = "Score: " + --score;
                this.Controls.Remove(snake[score+1]);
                this.Controls.Remove(bird_3);
            }
        }
        private void EatSkull()
        {
            if (snake[0].Location.X == rP && snake[0].Location.Y == rQ)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score: " + score;
                timer.Stop();
                AddBird_2.Stop();
                DeleteBird_2.Stop();
                AddBird_3.Stop();
                DeleteBird_3.Stop();
                AddSkull.Stop();
                label1.Visible = true;
                label2.Visible = true;
                Yess.Visible = true;
                No.Visible = true;
                this.Controls.Remove(skull);
                rP = 700;
                rQ = 600;
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
            for( int _i=1; _i< score; _i++)
            {
                if(snake[0].Location == snake[_i].Location)
                {
                    for (int _j = _i; _j <= score; _j++)
                        this.Controls.Remove(snake[_j]);
                    score -= (score - _i + 1);
                }
            }
        }
        private void Border()
        {
            if (snake[0].Location.X < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score: " + score;
                dirtX = 1;
            }
            if (snake[0].Location.X > 615)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score: " + score;
                dirtX = -1;
            }
            if (snake[0].Location.Y < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score: " + score;
                dirtY = 1;
            }
            if (snake[0].Location.Y > 615)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score: " + score;
                dirtY = -1;
            }
        }
        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBird_2_Tick(object sender, EventArgs e)
        {
            GenerateBird_2();
        }

        private void DeleteBird_2_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(bird_2);
            rJ1 = 666;
            rI1 = 700;
        }

        private void AddBird_3_Tick(object sender, EventArgs e)
        {
            GenerateBird_3();
        }

        private void DeleteBird_3_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(bird_3);
            rX = 700;
            rZ = 606;
        }

        private void AddSkull_Tick(object sender, EventArgs e)
        {
            GenerateSkull();
        }

        private void DeleteSkull_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(skull);
            rP = 700;
            rQ = 600;
        }

        private void Yess_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
