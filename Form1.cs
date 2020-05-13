using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Windows_Game
{
    /// <summary>
    /// Task 2.1 - IS 2.7
    /// This is a program game which competes against the Computer at Rock
    /// Paper and Scissors, also displaying a score. 
    /// Author: Shan Ahmed
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            User.Image = Image.FromFile("scissors.jpg");
            RPS_Game.PlayerChoice = RPS_Choices.SCISSORS;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            User.Image = Image.FromFile("paper.jpg");
            RPS_Game.PlayerChoice = RPS_Choices.PAPER;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            User.Image = Image.FromFile("stone.jpg");
            RPS_Game.PlayerChoice = RPS_Choices.ROCK;

        }

        private void Play_Click(object sender, EventArgs e)
        {
            RPS_Game.GetComputerChoice();

            if (RPS_Game.choice == 0)
            {
                Computer.Image = Image.FromFile("stone.jpg");
                RPS_Game.ComputerChoice = RPS_Choices.ROCK;
            }
            else if (RPS_Game.choice == 1)
            {
                Computer.Image = Image.FromFile("paper.jpg");
                RPS_Game.ComputerChoice = RPS_Choices.PAPER;

            }
            else
            {
                Computer.Image = Image.FromFile("scissors.jpg");
                RPS_Game.ComputerChoice = RPS_Choices.SCISSORS; ;
            }
            RPS_Game.WorkoutWinner();
            Result.Text = RPS_Game.WinnerName;
            UserScoreValue.Text = Convert.ToString(RPS_Game.PlayerScore);
            ComputerScoreValue.Text = Convert.ToString(RPS_Game.ComputerScore);

            if (Result.Text == "You WIN!!") 
            {
                Result.BackColor = Color.Orange;
                Result.ForeColor = Color.Black;
            }
            else
            {
                Result.BackColor = default;
                Result.ForeColor = default;
            }


        }

        private void Computer_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreen SScreen = new SplashScreen();
            SScreen.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}
