namespace snake
{
    partial class fact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fact));
            this.Back = new System.Windows.Forms.Button();
            this.Zagolovok = new System.Windows.Forms.Label();
            this.Lamp_nacal = new System.Windows.Forms.Button();
            this.LED_lamp = new System.Windows.Forms.Button();
            this.Gas_und_lumi_lamp = new System.Windows.Forms.Button();
            this.Back_fact = new System.Windows.Forms.Button();
            this.Nacal_fact = new System.Windows.Forms.Label();
            this.Gas_lumi_fact = new System.Windows.Forms.Label();
            this.LED_fact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(467, 764);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(348, 45);
            this.Back.TabIndex = 8;
            this.Back.Text = "Вернуться в Главное меню";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Zagolovok
            // 
            this.Zagolovok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Zagolovok.AutoSize = true;
            this.Zagolovok.BackColor = System.Drawing.Color.Transparent;
            this.Zagolovok.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zagolovok.Location = new System.Drawing.Point(87, 70);
            this.Zagolovok.Name = "Zagolovok";
            this.Zagolovok.Size = new System.Drawing.Size(1074, 134);
            this.Zagolovok.TabIndex = 9;
            this.Zagolovok.Text = "Пожалуйста, выберите, о какой лампе Вы\r\nхотите узнать что-то новое";
            this.Zagolovok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lamp_nacal
            // 
            this.Lamp_nacal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lamp_nacal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lamp_nacal.Location = new System.Drawing.Point(442, 251);
            this.Lamp_nacal.Name = "Lamp_nacal";
            this.Lamp_nacal.Size = new System.Drawing.Size(396, 65);
            this.Lamp_nacal.TabIndex = 10;
            this.Lamp_nacal.Text = "Лампа накаливания";
            this.Lamp_nacal.UseVisualStyleBackColor = true;
            this.Lamp_nacal.Click += new System.EventHandler(this.Lamp_nacal_Click);
            // 
            // LED_lamp
            // 
            this.LED_lamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LED_lamp.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LED_lamp.Location = new System.Drawing.Point(442, 351);
            this.LED_lamp.Name = "LED_lamp";
            this.LED_lamp.Size = new System.Drawing.Size(396, 65);
            this.LED_lamp.TabIndex = 11;
            this.LED_lamp.Text = "LED - лампы";
            this.LED_lamp.UseVisualStyleBackColor = true;
            this.LED_lamp.Click += new System.EventHandler(this.LED_lamp_Click);
            // 
            // Gas_und_lumi_lamp
            // 
            this.Gas_und_lumi_lamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gas_und_lumi_lamp.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gas_und_lumi_lamp.Location = new System.Drawing.Point(442, 451);
            this.Gas_und_lumi_lamp.Name = "Gas_und_lumi_lamp";
            this.Gas_und_lumi_lamp.Size = new System.Drawing.Size(396, 103);
            this.Gas_und_lumi_lamp.TabIndex = 12;
            this.Gas_und_lumi_lamp.Text = "Газовые и люминисцентные лампы";
            this.Gas_und_lumi_lamp.UseVisualStyleBackColor = true;
            this.Gas_und_lumi_lamp.Click += new System.EventHandler(this.Gas_und_lumi_lamp_Click);
            // 
            // Back_fact
            // 
            this.Back_fact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_fact.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_fact.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_fact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_fact.Location = new System.Drawing.Point(560, 691);
            this.Back_fact.Name = "Back_fact";
            this.Back_fact.Size = new System.Drawing.Size(159, 58);
            this.Back_fact.TabIndex = 13;
            this.Back_fact.Text = "Назад";
            this.Back_fact.UseVisualStyleBackColor = false;
            this.Back_fact.Visible = false;
            this.Back_fact.Click += new System.EventHandler(this.Back_fact_Click);
            // 
            // Nacal_fact
            // 
            this.Nacal_fact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nacal_fact.BackColor = System.Drawing.Color.Transparent;
            this.Nacal_fact.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nacal_fact.Location = new System.Drawing.Point(55, 179);
            this.Nacal_fact.Name = "Nacal_fact";
            this.Nacal_fact.Size = new System.Drawing.Size(1060, 535);
            this.Nacal_fact.TabIndex = 14;
            this.Nacal_fact.Text = resources.GetString("Nacal_fact.Text");
            this.Nacal_fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nacal_fact.Visible = false;
            // 
            // Gas_lumi_fact
            // 
            this.Gas_lumi_fact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gas_lumi_fact.BackColor = System.Drawing.Color.Transparent;
            this.Gas_lumi_fact.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gas_lumi_fact.Location = new System.Drawing.Point(62, 193);
            this.Gas_lumi_fact.Name = "Gas_lumi_fact";
            this.Gas_lumi_fact.Size = new System.Drawing.Size(1115, 531);
            this.Gas_lumi_fact.TabIndex = 15;
            this.Gas_lumi_fact.Text = resources.GetString("Gas_lumi_fact.Text");
            this.Gas_lumi_fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gas_lumi_fact.Visible = false;
            // 
            // LED_fact
            // 
            this.LED_fact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_fact.BackColor = System.Drawing.Color.Transparent;
            this.LED_fact.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LED_fact.Location = new System.Drawing.Point(62, 154);
            this.LED_fact.Name = "LED_fact";
            this.LED_fact.Size = new System.Drawing.Size(1108, 560);
            this.LED_fact.TabIndex = 16;
            this.LED_fact.Text = resources.GetString("LED_fact.Text");
            this.LED_fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LED_fact.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(417, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 67);
            this.label1.TabIndex = 17;
            this.label1.Text = "А Вы знали, что:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // fact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 834);
            this.Controls.Add(this.Back_fact);
            this.Controls.Add(this.Gas_und_lumi_lamp);
            this.Controls.Add(this.LED_lamp);
            this.Controls.Add(this.Lamp_nacal);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zagolovok);
            this.Controls.Add(this.Gas_lumi_fact);
            this.Controls.Add(this.Nacal_fact);
            this.Controls.Add(this.LED_fact);
            this.DoubleBuffered = true;
            this.Name = "fact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интересные факты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Zagolovok;
        private System.Windows.Forms.Button Lamp_nacal;
        private System.Windows.Forms.Button LED_lamp;
        private System.Windows.Forms.Button Gas_und_lumi_lamp;
        private System.Windows.Forms.Button Back_fact;
        private System.Windows.Forms.Label Nacal_fact;
        private System.Windows.Forms.Label Gas_lumi_fact;
        private System.Windows.Forms.Label LED_fact;
        private System.Windows.Forms.Label label1;
    }
}