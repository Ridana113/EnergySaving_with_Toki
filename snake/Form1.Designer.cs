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
            this.bird = new System.Windows.Forms.PictureBox();
            this.bird_2 = new System.Windows.Forms.PictureBox();
            this.AddBird_2 = new System.Windows.Forms.Timer(this.components);
            this.bird_3 = new System.Windows.Forms.PictureBox();
            this.skull = new System.Windows.Forms.PictureBox();
            this.Yess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.DeleteBird_2 = new System.Windows.Forms.Timer(this.components);
            this.AddBird_3 = new System.Windows.Forms.Timer(this.components);
            this.DeleteBird_3 = new System.Windows.Forms.Timer(this.components);
            this.AddSkull = new System.Windows.Forms.Timer(this.components);
            this.DeleteSkull = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skull)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(643, 398);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(30, 30);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // bird_2
            // 
            this.bird_2.BackColor = System.Drawing.Color.Transparent;
            this.bird_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird_2.BackgroundImage")));
            this.bird_2.Location = new System.Drawing.Point(633, 335);
            this.bird_2.Name = "bird_2";
            this.bird_2.Size = new System.Drawing.Size(30, 30);
            this.bird_2.TabIndex = 3;
            this.bird_2.TabStop = false;
            // 
            // AddBird_2
            // 
            this.AddBird_2.Interval = 20000;
            this.AddBird_2.Tick += new System.EventHandler(this.AddBird_2_Tick);
            // 
            // bird_3
            // 
            this.bird_3.BackColor = System.Drawing.Color.Transparent;
            this.bird_3.Image = ((System.Drawing.Image)(resources.GetObject("bird_3.Image")));
            this.bird_3.Location = new System.Drawing.Point(643, 536);
            this.bird_3.Name = "bird_3";
            this.bird_3.Size = new System.Drawing.Size(30, 30);
            this.bird_3.TabIndex = 5;
            this.bird_3.TabStop = false;
            // 
            // skull
            // 
            this.skull.BackColor = System.Drawing.Color.Transparent;
            this.skull.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skull.BackgroundImage")));
            this.skull.Location = new System.Drawing.Point(643, 471);
            this.skull.Name = "skull";
            this.skull.Size = new System.Drawing.Size(20, 26);
            this.skull.TabIndex = 6;
            this.skull.TabStop = false;
            // 
            // Yess
            // 
            this.Yess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yess.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Yess.Location = new System.Drawing.Point(216, 146);
            this.Yess.Name = "Yess";
            this.Yess.Size = new System.Drawing.Size(66, 36);
            this.Yess.TabIndex = 7;
            this.Yess.Text = "Yess";
            this.Yess.UseVisualStyleBackColor = false;
            this.Yess.Visible = false;
            this.Yess.Click += new System.EventHandler(this.Yess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(206, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "GAME OVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.SystemColors.ControlLight;
            this.No.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.No.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No.Location = new System.Drawing.Point(332, 146);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(63, 36);
            this.No.TabIndex = 9;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // DeleteBird_2
            // 
            this.DeleteBird_2.Interval = 26000;
            this.DeleteBird_2.Tick += new System.EventHandler(this.DeleteBird_2_Tick);
            // 
            // AddBird_3
            // 
            this.AddBird_3.Interval = 40000;
            this.AddBird_3.Tick += new System.EventHandler(this.AddBird_3_Tick);
            // 
            // DeleteBird_3
            // 
            this.DeleteBird_3.Interval = 50000;
            this.DeleteBird_3.Tick += new System.EventHandler(this.DeleteBird_3_Tick);
            // 
            // AddSkull
            // 
            this.AddSkull.Interval = 60000;
            this.AddSkull.Tick += new System.EventHandler(this.AddSkull_Tick);
            // 
            // DeleteSkull
            // 
            this.DeleteSkull.Interval = 67000;
            this.DeleteSkull.Tick += new System.EventHandler(this.DeleteSkull_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(186, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = " Начать игру заново?";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(221, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 58);
            this.label3.TabIndex = 12;
            this.label3.Text = "VICTORY ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(153, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Поздравляю! Вы победили!";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skull);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.bird_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yess);
            this.Controls.Add(this.bird_3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Location = new System.Drawing.Point(110, 110);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox bird_2;
        private System.Windows.Forms.Timer AddBird_2;
        private System.Windows.Forms.PictureBox bird_3;
        private System.Windows.Forms.PictureBox skull;
        private System.Windows.Forms.Button Yess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Timer DeleteBird_2;
        private System.Windows.Forms.Timer AddBird_3;
        private System.Windows.Forms.Timer DeleteBird_3;
        private System.Windows.Forms.Timer AddSkull;
        private System.Windows.Forms.Timer DeleteSkull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

