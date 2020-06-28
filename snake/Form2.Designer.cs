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
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Control;
            this.Start.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(196, 120);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(235, 60);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.SystemColors.Control;
            this.Rules.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.Location = new System.Drawing.Point(196, 253);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(235, 59);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Instruction
            // 
            this.Instruction.BackColor = System.Drawing.SystemColors.Control;
            this.Instruction.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instruction.Location = new System.Drawing.Point(196, 387);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(235, 60);
            this.Instruction.TabIndex = 2;
            this.Instruction.Text = "Instruction";
            this.Instruction.UseVisualStyleBackColor = false;
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 621);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Start);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Button Instruction;
    }
}