using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Windows_Game
{
        public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKNOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class plays the RPS Game
    /// Author: Shan
    /// Started: 12/03/2019
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public static int ComputerScore { get; set; }

        public static int PlayerScore { get; set; }

        public static int choice;
        public static string PlayerName { get; set; }
        public static string WinnerName { get; set; }

        public static RPS_Choices ComputerChoice { get; set; }
        public static RPS_Choices PlayerChoice { get; set; }

        public static Random randomGenerator = new Random(123);

        public static void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";

            PlayerScore = 0;
            ComputerScore = 0;

        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            Random r = new Random();
            choice = r.Next(3) + 1;
        }

           
        /// <summary>
        /// *******************************************************
        /// This method will determine whether the computer has
        /// won, or the player has won, or it is a draw.
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                WinnerName = "You have Drawn!!!";
                ComputerScore = ComputerScore + 1;
                PlayerScore = PlayerScore + 1;
            }
            if (PlayerChoice == RPS_Choices.ROCK & ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = "You WIN!!";
                PlayerScore = PlayerScore + 2;
            }
            if (PlayerChoice == RPS_Choices.PAPER & ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = "You WIN!!";
                PlayerScore = PlayerScore + 2;
            }
            if (PlayerChoice == RPS_Choices.SCISSORS & ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = "You WIN!!";
                PlayerScore = PlayerScore + 2;
            }
            if (PlayerChoice == RPS_Choices.ROCK & ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = "Computer WINS!!";
                ComputerScore = ComputerScore + 2;
            }
            if (PlayerChoice == RPS_Choices.PAPER & ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = "Computer WINS!!";
                ComputerScore = ComputerScore + 2;
            }
            if (PlayerChoice == RPS_Choices.SCISSORS & ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = "Computer WINS!!";
                ComputerScore = ComputerScore + 2;

            }

        }
    }
}
