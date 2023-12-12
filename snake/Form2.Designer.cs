namespace snake
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Start = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fact = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Toki = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.PictureBox();
            this.intro2 = new System.Windows.Forms.PictureBox();
            this.Yess = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.Next_story = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Start.BackColor = System.Drawing.SystemColors.Control;
            this.Start.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(569, 231);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(312, 60);
            this.Start.TabIndex = 0;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Rules
            // 
            this.Rules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rules.BackColor = System.Drawing.SystemColors.Control;
            this.Rules.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.Location = new System.Drawing.Point(569, 327);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(312, 61);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Правила";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Instruction
            // 
            this.Instruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Instruction.BackColor = System.Drawing.SystemColors.Control;
            this.Instruction.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instruction.Location = new System.Drawing.Point(569, 433);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(312, 61);
            this.Instruction.TabIndex = 2;
            this.Instruction.Text = "Управление";
            this.Instruction.UseVisualStyleBackColor = false;
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(315, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(831, 67);
            this.label2.TabIndex = 3;
            this.label2.Text = "Энергосбережение вместе с Токи";
            // 
            // Fact
            // 
            this.Fact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fact.BackColor = System.Drawing.SystemColors.Control;
            this.Fact.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fact.Location = new System.Drawing.Point(569, 533);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(312, 116);
            this.Fact.TabIndex = 4;
            this.Fact.Text = "Интересные факты";
            this.Fact.UseVisualStyleBackColor = false;
            this.Fact.Click += new System.EventHandler(this.Fact_Click);
            // 
            // History
            // 
            this.History.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.History.BackColor = System.Drawing.SystemColors.Control;
            this.History.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Location = new System.Drawing.Point(569, 684);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(312, 72);
            this.History.TabIndex = 5;
            this.History.Text = "Предыстория";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Toki
            // 
            this.Toki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Toki.BackColor = System.Drawing.Color.Transparent;
            this.Toki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toki.Image = ((System.Drawing.Image)(resources.GetObject("Toki.Image")));
            this.Toki.Location = new System.Drawing.Point(16, 465);
            this.Toki.Name = "Toki";
            this.Toki.Size = new System.Drawing.Size(180, 267);
            this.Toki.TabIndex = 25;
            this.Toki.TabStop = false;
            this.Toki.Click += new System.EventHandler(this.Toki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 119);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(192, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "Есссли хочешь узнать обо мне,\r\nкликни на меня";
            this.label1.Visible = false;
            // 
            // intro
            // 
            this.intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intro.BackColor = System.Drawing.Color.Transparent;
            this.intro.Image = ((System.Drawing.Image)(resources.GetObject("intro.Image")));
            this.intro.Location = new System.Drawing.Point(170, 121);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(1201, 388);
            this.intro.TabIndex = 28;
            this.intro.TabStop = false;
            // 
            // intro2
            // 
            this.intro2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intro2.BackColor = System.Drawing.Color.Transparent;
            this.intro2.Image = ((System.Drawing.Image)(resources.GetObject("intro2.Image")));
            this.intro2.Location = new System.Drawing.Point(180, 23);
            this.intro2.Name = "intro2";
            this.intro2.Size = new System.Drawing.Size(1206, 463);
            this.intro2.TabIndex = 29;
            this.intro2.TabStop = false;
            this.intro2.Visible = false;
            // 
            // Yess
            // 
            this.Yess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Yess.BackColor = System.Drawing.SystemColors.Control;
            this.Yess.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yess.Location = new System.Drawing.Point(308, 524);
            this.Yess.Name = "Yess";
            this.Yess.Size = new System.Drawing.Size(111, 60);
            this.Yess.TabIndex = 30;
            this.Yess.Text = "ДА!";
            this.Yess.UseVisualStyleBackColor = false;
            this.Yess.Visible = false;
            this.Yess.Click += new System.EventHandler(this.Yess_Click);
            // 
            // No
            // 
            this.No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.No.BackColor = System.Drawing.SystemColors.Control;
            this.No.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.No.Location = new System.Drawing.Point(944, 524);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(328, 60);
            this.No.TabIndex = 31;
            this.No.Text = "Не, я все таки ухожу....";
            this.No.UseVisualStyleBackColor = false;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Skip
            // 
            this.Skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Skip.BackColor = System.Drawing.SystemColors.Control;
            this.Skip.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Skip.Location = new System.Drawing.Point(1047, 703);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(373, 31);
            this.Skip.TabIndex = 32;
            this.Skip.Text = "Пропустить вступление и перейти к меню";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Next_story
            // 
            this.Next_story.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Next_story.BackColor = System.Drawing.SystemColors.Control;
            this.Next_story.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next_story.Location = new System.Drawing.Point(1003, 524);
            this.Next_story.Name = "Next_story";
            this.Next_story.Size = new System.Drawing.Size(293, 60);
            this.Next_story.TabIndex = 33;
            this.Next_story.Text = "Я, пожалуй, пойду...";
            this.Next_story.UseVisualStyleBackColor = false;
            this.Next_story.Click += new System.EventHandler(this.Next_story_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 746);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yess);
            this.Controls.Add(this.Next_story);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Fact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.intro2);
            this.Controls.Add(this.Toki);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Toki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Button Instruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Fact;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.PictureBox Toki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox intro;
        private System.Windows.Forms.PictureBox intro2;
        private System.Windows.Forms.Button Yess;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button Next_story;
    }
}