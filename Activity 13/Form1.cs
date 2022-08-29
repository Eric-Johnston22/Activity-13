using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] game = new int[3, 3];

        // Generate 2D array and populate gameboard
        public void CreateGame()
        {
            Random rand = new Random();

            // Nested loop required to generate 2D array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Generate random number between 0 and 1
                    int randomInt = rand.Next(2);
                    game[i, j] = randomInt;
                }
            }

            tbx_1.Text = game[0, 0].ToString();
            tbx_2.Text = game[0, 1].ToString();
            tbx_3.Text = game[0, 2].ToString();
            tbx_4.Text = game[1, 0].ToString();
            tbx_5.Text = game[1, 1].ToString();
            tbx_6.Text = game[1, 2].ToString();
            tbx_7.Text = game[2, 0].ToString();
            tbx_8.Text = game[2, 1].ToString();
            tbx_9.Text = game[2, 2].ToString();
        }

        // Change gameboard from numbers to X's and O's
        public void ChangeDisplay()
        {

            if (tbx_1.Text == "0")
            {
                tbx_1.Text = "O";
            }
            else
            {
                tbx_1.Text = "X";
            }

            if (tbx_2.Text == "0")
            {
                tbx_2.Text = "O";
            }
            else
            {
                tbx_2.Text = "X";
            }

            if (tbx_3.Text == "0")
            {
                tbx_3.Text = "O";
            }
            else
            {
                tbx_3.Text = "X";
            }

            if (tbx_4.Text == "0")
            {
                tbx_4.Text = "O";
            }
            else
            {
                tbx_4.Text = "X";
            }

            if (tbx_5.Text == "0")
            {
                tbx_5.Text = "O";
            }
            else
            {
                tbx_5.Text = "X";
            }

            if (tbx_6.Text == "0")
            {
                tbx_6.Text = "O";
            }
            else
            {
                tbx_6.Text = "X";
            }

            if (tbx_7.Text == "0")
            {
                tbx_7.Text = "O";
            }
            else
            {
                tbx_7.Text = "X";
            }

            if (tbx_8.Text == "0")
            {
                tbx_8.Text = "O";
            }
            else
            {
                tbx_8.Text = "X";
            }

            if (tbx_9.Text == "0")
            {
                tbx_9.Text = "O";
            }
            else
            {
                tbx_9.Text = "X";
            }
        }

        public string CheckForWinner()
        {
            string winner = "";
            // Check for player 0 wins
            // Check horizontal wins
            if (game[0,0] == 0 && game[0,1] == 0 && game[0,2] == 0)
            {
                winner = "Player O wins!";
            }
            else if (game[1,0] == 0 && game[1,1] == 0 && game[1,2] == 0)
            {
                winner = "Player O wins!";
            }
            else if (game[2, 0] == 0 && game[2,1] == 0 && game[2,2] == 0)
            {
                winner = "Player O wins!";
            }

            // Check vertical wins
            else if (game[0,0] == 0 && game[1,0] == 0 && game[2,0] == 0)
            {
                winner = "Player O wins!";
            }
            else if (game[0,1] == 0 && game[1,1] == 0 && game[2,1] == 0)
            {
                winner = "Player O wins!";
            }
            else if (game[0,2] == 0 && game[1,2] == 0 && game[2,2] == 0)
            {
                winner = "Player O wins!";
            }

            // Check diagonal wins
            else if (game[0,0] == 0 && game[1,1] == 0 && game[2,2] == 0)
            {
                winner = "Player O wins!";
            }
            else if (game[0,2] == 0 && game[1,1] == 0 && game[2,0] == 0)
            {
                winner = "Player O wins!";
            }

            // Check for player X wins
            // Check horizontal wins
            else if (game[0, 0] == 1 && game[0, 1] == 1 && game[0, 2] == 1)
            {
                winner = "Player X wins!";
            }
            else if (game[1, 0] == 1 && game[1, 1] == 1 && game[1, 2] == 1)
            {
                winner = "Player X wins!";
            }
            else if (game[2, 0] == 1 && game[2, 1] == 1 && game[2, 2] == 1)
            {
                winner = "Player X wins!";
            }

            // Check vertical wins
            else if (game[0, 0] == 1 && game[1, 0] == 1 && game[2, 0] == 1)
            {
                winner = "Player X wins!";
            }
            else if (game[0, 1] == 1 && game[1, 1] == 1 && game[2, 1] == 1)
            {
                winner = "Player X wins!";
            }
            else if (game[0, 2] == 1 && game[1, 2] == 1 && game[2, 2] == 1)
            {
                winner = "Player X wins!";
            }

            // Check diagonal wins
            else if (game[0, 0] == 1 && game[1, 1] == 1 && game[2, 2] == 1)
            {
                winner = "Player X wins!";
            }
            else if (game[0, 2] == 1 && game[1, 1] == 1 && game[2, 0] == 1)
            {
                winner = "Player X wins!";
            }
            
            else
            {
                winner = "Draw!";
            }

            return winner;
        }

        public void btn_newGame_Click(object sender, EventArgs e)
        {
            // Call CreateGame() method
            CreateGame();
            // Call ChangeDisplay() method
            ChangeDisplay();
            // Call CheckForWinner() method
            lbl_winner.Text = CheckForWinner();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
