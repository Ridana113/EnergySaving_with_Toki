namespace snake
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Lumi = new System.Windows.Forms.PictureBox();
            this.Nacal = new System.Windows.Forms.PictureBox();
            this.Gas = new System.Windows.Forms.PictureBox();
            this.Yess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.AddNacal = new System.Windows.Forms.Timer(this.components);
            this.DeleteNacal = new System.Windows.Forms.Timer(this.components);
            this.AddGas = new System.Windows.Forms.Timer(this.components);
            this.DeleteGas = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sun_batary = new System.Windows.Forms.PictureBox();
            this.Wind = new System.Windows.Forms.PictureBox();
            this.AddSunBatary = new System.Windows.Forms.Timer(this.components);
            this.DeleteSunBatary = new System.Windows.Forms.Timer(this.components);
            this.AddWind = new System.Windows.Forms.Timer(this.components);
            this.DeleteWind = new System.Windows.Forms.Timer(this.components);
            this.Score_time = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Taimer = new System.Windows.Forms.Label();
            this.LED = new System.Windows.Forms.PictureBox();
            this.AddLED = new System.Windows.Forms.Timer(this.components);
            this.Rezalt = new System.Windows.Forms.Label();
            this.DeleteLED = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.speed_score = new System.Windows.Forms.Timer(this.components);
            this.Toki = new System.Windows.Forms.PictureBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.Snake_text = new System.Windows.Forms.PictureBox();
            this.Snake_text2 = new System.Windows.Forms.PictureBox();
            this.Snake_text3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lumi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nacal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun_batary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // Lumi
            // 
            this.Lumi.BackColor = System.Drawing.Color.Transparent;
            this.Lumi.Image = ((System.Drawing.Image)(resources.GetObject("Lumi.Image")));
            this.Lumi.Location = new System.Drawing.Point(1014, 316);
            this.Lumi.Name = "Lumi";
            this.Lumi.Size = new System.Drawing.Size(40, 40);
            this.Lumi.TabIndex = 2;
            this.Lumi.TabStop = false;
            // 
            // Nacal
            // 
            this.Nacal.BackColor = System.Drawing.Color.Transparent;
            this.Nacal.Image = ((System.Drawing.Image)(resources.GetObject("Nacal.Image")));
            this.Nacal.Location = new System.Drawing.Point(1014, 404);
            this.Nacal.Name = "Nacal";
            this.Nacal.Size = new System.Drawing.Size(40, 40);
            this.Nacal.TabIndex = 5;
            this.Nacal.TabStop = false;
            // 
            // Gas
            // 
            this.Gas.BackColor = System.Drawing.Color.Transparent;
            this.Gas.Image = ((System.Drawing.Image)(resources.GetObject("Gas.Image")));
            this.Gas.Location = new System.Drawing.Point(1014, 459);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(40, 40);
            this.Gas.TabIndex = 6;
            this.Gas.TabStop = false;
            // 
            // Yess
            // 
            this.Yess.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Yess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yess.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Yess.Location = new System.Drawing.Point(496, 386);
            this.Yess.Name = "Yess";
            this.Yess.Size = new System.Drawing.Size(81, 44);
            this.Yess.TabIndex = 7;
            this.Yess.Text = "ДА";
            this.Yess.UseVisualStyleBackColor = false;
            this.Yess.Visible = false;
            this.Yess.Click += new System.EventHandler(this.Yess_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(514, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 77);
            this.label1.TabIndex = 8;
            this.label1.Text = "GAME OVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // No
            // 
            this.No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.No.AutoSize = true;
            this.No.BackColor = System.Drawing.SystemColors.ControlLight;
            this.No.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.No.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No.Location = new System.Drawing.Point(709, 386);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(72, 44);
            this.No.TabIndex = 9;
            this.No.Text = "НЕТ";
            this.No.UseVisualStyleBackColor = false;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // AddNacal
            // 
            this.AddNacal.Enabled = true;
            this.AddNacal.Interval = 35000;
            this.AddNacal.Tick += new System.EventHandler(this.AddNacal_Tick);
            // 
            // DeleteNacal
            // 
            this.DeleteNacal.Enabled = true;
            this.DeleteNacal.Interval = 45000;
            this.DeleteNacal.Tick += new System.EventHandler(this.DeleteNacal_Tick);
            // 
            // AddGas
            // 
            this.AddGas.Enabled = true;
            this.AddGas.Interval = 50000;
            this.AddGas.Tick += new System.EventHandler(this.AddGas_Tick);
            // 
            // DeleteGas
            // 
            this.DeleteGas.Enabled = true;
            this.DeleteGas.Interval = 60000;
            this.DeleteGas.Tick += new System.EventHandler(this.DeleteGas_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(484, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = " Начать игру заново?";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(548, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 77);
            this.label3.TabIndex = 12;
            this.label3.Text = "VICTORY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(450, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Поздравляю! Вы победили!";
            this.label4.Visible = false;
            // 
            // Sun_batary
            // 
            this.Sun_batary.BackColor = System.Drawing.Color.Transparent;
            this.Sun_batary.Image = ((System.Drawing.Image)(resources.GetObject("Sun_batary.Image")));
            this.Sun_batary.Location = new System.Drawing.Point(1076, 346);
            this.Sun_batary.Name = "Sun_batary";
            this.Sun_batary.Size = new System.Drawing.Size(40, 40);
            this.Sun_batary.TabIndex = 14;
            this.Sun_batary.TabStop = false;
            // 
            // Wind
            // 
            this.Wind.BackColor = System.Drawing.Color.Transparent;
            this.Wind.Image = ((System.Drawing.Image)(resources.GetObject("Wind.Image")));
            this.Wind.Location = new System.Drawing.Point(1076, 404);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(40, 40);
            this.Wind.TabIndex = 16;
            this.Wind.TabStop = false;
            // 
            // AddSunBatary
            // 
            this.AddSunBatary.Enabled = true;
            this.AddSunBatary.Interval = 62000;
            this.AddSunBatary.Tick += new System.EventHandler(this.AddSunBatary_Tick);
            // 
            // DeleteSunBatary
            // 
            this.DeleteSunBatary.Enabled = true;
            this.DeleteSunBatary.Interval = 69000;
            this.DeleteSunBatary.Tick += new System.EventHandler(this.DeleteSunBatary_Tick);
            // 
            // AddWind
            // 
            this.AddWind.Enabled = true;
            this.AddWind.Interval = 80000;
            this.AddWind.Tick += new System.EventHandler(this.AddWind_Tick);
            // 
            // DeleteWind
            // 
            this.DeleteWind.Interval = 87000;
            this.DeleteWind.Tick += new System.EventHandler(this.DeleteWind_Tick);
            // 
            // Score_time
            // 
            this.Score_time.Enabled = true;
            this.Score_time.Interval = 700;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(458, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Сожалею, Вы проиграли!";
            this.label5.Visible = false;
            // 
            // Taimer
            // 
            this.Taimer.AutoSize = true;
            this.Taimer.BackColor = System.Drawing.Color.Transparent;
            this.Taimer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Taimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Taimer.Location = new System.Drawing.Point(12, 5);
            this.Taimer.Name = "Taimer";
            this.Taimer.Size = new System.Drawing.Size(249, 35);
            this.Taimer.TabIndex = 19;
            this.Taimer.Text = "Оставшееся время: ";
            // 
            // LED
            // 
            this.LED.BackColor = System.Drawing.Color.Transparent;
            this.LED.Image = ((System.Drawing.Image)(resources.GetObject("LED.Image")));
            this.LED.Location = new System.Drawing.Point(1014, 515);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(40, 40);
            this.LED.TabIndex = 20;
            this.LED.TabStop = false;
            // 
            // AddLED
            // 
            this.AddLED.Enabled = true;
            this.AddLED.Interval = 10000;
            this.AddLED.Tick += new System.EventHandler(this.AddLED_Tick);
            // 
            // Rezalt
            // 
            this.Rezalt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rezalt.AutoSize = true;
            this.Rezalt.BackColor = System.Drawing.Color.Transparent;
            this.Rezalt.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rezalt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rezalt.Location = new System.Drawing.Point(332, 272);
            this.Rezalt.Name = "Rezalt";
            this.Rezalt.Size = new System.Drawing.Size(333, 38);
            this.Rezalt.TabIndex = 21;
            this.Rezalt.Text = "Вы смогли сохранить: ";
            this.Rezalt.Visible = false;
            // 
            // DeleteLED
            // 
            this.DeleteLED.Enabled = true;
            this.DeleteLED.Interval = 18000;
            this.DeleteLED.Tick += new System.EventHandler(this.DeleteLED_Tick);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(1050, 3);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(114, 35);
            this.labelScore.TabIndex = 22;
            this.labelScore.Text = "Баллы: ";
            // 
            // speed_score
            // 
            this.speed_score.Enabled = true;
            this.speed_score.Interval = 700;
            this.speed_score.Tick += new System.EventHandler(this.speed_score_Tick);
            // 
            // Toki
            // 
            this.Toki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Toki.BackColor = System.Drawing.Color.Transparent;
            this.Toki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toki.Image = ((System.Drawing.Image)(resources.GetObject("Toki.Image")));
            this.Toki.Location = new System.Drawing.Point(8, 476);
            this.Toki.Name = "Toki";
            this.Toki.Size = new System.Drawing.Size(180, 267);
            this.Toki.TabIndex = 24;
            this.Toki.TabStop = false;
            this.Toki.Visible = false;
            // 
            // labelStop
            // 
            this.labelStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStop.BackColor = System.Drawing.Color.White;
            this.labelStop.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStop.Location = new System.Drawing.Point(392, 247);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(499, 169);
            this.labelStop.TabIndex = 25;
            this.labelStop.Text = "Игра остановлена. Для продолжения нажмите клавишу Space";
            this.labelStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStop.Visible = false;
            // 
            // Snake_text
            // 
            this.Snake_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Snake_text.BackColor = System.Drawing.Color.Transparent;
            this.Snake_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Snake_text.Image = ((System.Drawing.Image)(resources.GetObject("Snake_text.Image")));
            this.Snake_text.Location = new System.Drawing.Point(185, 525);
            this.Snake_text.Name = "Snake_text";
            this.Snake_text.Size = new System.Drawing.Size(460, 159);
            this.Snake_text.TabIndex = 26;
            this.Snake_text.TabStop = false;
            this.Snake_text.Visible = false;
            // 
            // Snake_text2
            // 
            this.Snake_text2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Snake_text2.BackColor = System.Drawing.Color.Transparent;
            this.Snake_text2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Snake_text2.Image = ((System.Drawing.Image)(resources.GetObject("Snake_text2.Image")));
            this.Snake_text2.Location = new System.Drawing.Point(185, 516);
            this.Snake_text2.Name = "Snake_text2";
            this.Snake_text2.Size = new System.Drawing.Size(460, 159);
            this.Snake_text2.TabIndex = 27;
            this.Snake_text2.TabStop = false;
            this.Snake_text2.Visible = false;
            // 
            // Snake_text3
            // 
            this.Snake_text3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Snake_text3.BackColor = System.Drawing.Color.Transparent;
            this.Snake_text3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Snake_text3.Image = ((System.Drawing.Image)(resources.GetObject("Snake_text3.Image")));
            this.Snake_text3.Location = new System.Drawing.Point(185, 517);
            this.Snake_text3.Name = "Snake_text3";
            this.Snake_text3.Size = new System.Drawing.Size(460, 159);
            this.Snake_text3.TabIndex = 28;
            this.Snake_text3.TabStop = false;
            this.Snake_text3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(-5, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2113, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 746);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.Taimer);
            this.Controls.Add(this.Snake_text3);
            this.Controls.Add(this.Snake_text2);
            this.Controls.Add(this.Rezalt);
            this.Controls.Add(this.LED);
            this.Controls.Add(this.Wind);
            this.Controls.Add(this.Sun_batary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.Lumi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yess);
            this.Controls.Add(this.Nacal);
            this.Controls.Add(this.Toki);
            this.Controls.Add(this.Snake_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelStop);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Location = new System.Drawing.Point(110, 110);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Lumi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nacal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun_batary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_text3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Lumi;
        private System.Windows.Forms.PictureBox Nacal;
        private System.Windows.Forms.PictureBox Gas;
        private System.Windows.Forms.Button Yess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Timer AddNacal;
        private System.Windows.Forms.Timer DeleteNacal;
        private System.Windows.Forms.Timer AddGas;
        private System.Windows.Forms.Timer DeleteGas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Sun_batary;
        private System.Windows.Forms.PictureBox Wind;
        private System.Windows.Forms.Timer AddSunBatary;
        private System.Windows.Forms.Timer DeleteSunBatary;
        private System.Windows.Forms.Timer AddWind;
        private System.Windows.Forms.Timer DeleteWind;
        private System.Windows.Forms.Timer Score_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Taimer;
        private System.Windows.Forms.PictureBox LED;
        private System.Windows.Forms.Timer AddLED;
        private System.Windows.Forms.Label Rezalt;
        private System.Windows.Forms.Timer DeleteLED;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer speed_score;
        private System.Windows.Forms.PictureBox Toki;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.PictureBox Snake_text;
        private System.Windows.Forms.PictureBox Snake_text2;
        private System.Windows.Forms.PictureBox Snake_text3;
        private System.Windows.Forms.Label label6;
    }
}

