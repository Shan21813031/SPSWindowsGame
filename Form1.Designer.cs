namespace SPS_Windows_Game
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.User = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Play = new System.Windows.Forms.Button();
            this.Computer = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.UserScore = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.ComputerScoreValue = new System.Windows.Forms.Label();
            this.UserScoreValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.User);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(49, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Choice";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 250);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Stone";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(22, 29);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(147, 166);
            this.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 225);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paper";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 201);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Scissors";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Play);
            this.groupBox2.Controls.Add(this.Computer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(302, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Choice";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(58, 220);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(82, 38);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Computer
            // 
            this.Computer.Location = new System.Drawing.Point(24, 29);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(147, 166);
            this.Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Computer.TabIndex = 1;
            this.Computer.TabStop = false;
            this.Computer.Click += new System.EventHandler(this.Computer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UserScoreValue);
            this.groupBox3.Controls.Add(this.ComputerScoreValue);
            this.groupBox3.Controls.Add(this.ComputerScore);
            this.groupBox3.Controls.Add(this.UserScore);
            this.groupBox3.Controls.Add(this.Result);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(532, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ComputerScore
            // 
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.Location = new System.Drawing.Point(6, 170);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(155, 25);
            this.ComputerScore.TabIndex = 2;
            this.ComputerScore.Text = "Computer Score";
            // 
            // UserScore
            // 
            this.UserScore.AutoSize = true;
            this.UserScore.Location = new System.Drawing.Point(6, 103);
            this.UserScore.Name = "UserScore";
            this.UserScore.Size = new System.Drawing.Size(110, 25);
            this.UserScore.TabIndex = 1;
            this.UserScore.Text = "User Score";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(6, 29);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(194, 63);
            this.Result.TabIndex = 0;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quit.Location = new System.Drawing.Point(593, 288);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(82, 38);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ComputerScoreValue
            // 
            this.ComputerScoreValue.AutoSize = true;
            this.ComputerScoreValue.Location = new System.Drawing.Point(52, 205);
            this.ComputerScoreValue.Name = "ComputerScoreValue";
            this.ComputerScoreValue.Size = new System.Drawing.Size(0, 25);
            this.ComputerScoreValue.TabIndex = 3;
            // 
            // UserScoreValue
            // 
            this.UserScoreValue.AutoSize = true;
            this.UserScoreValue.Location = new System.Drawing.Point(56, 137);
            this.UserScoreValue.Name = "UserScoreValue";
            this.UserScoreValue.Size = new System.Drawing.Size(0, 25);
            this.UserScoreValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scissors Paper Stone Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox Computer;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label ComputerScore;
        private System.Windows.Forms.Label UserScore;
        private System.Windows.Forms.Label UserScoreValue;
        private System.Windows.Forms.Label ComputerScoreValue;
    }
}

