using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        int intXWins, intOWins, intTies;
        string strWhoseTurnItIs;

        private void ChangeTurn()
        {
            if (strWhoseTurnItIs == "X")
            {
                strWhoseTurnItIs = "O";
                Turn1_lbl.Text = "O";
            }
            else
            {
                strWhoseTurnItIs = "X";
                Turn1_lbl.Text = "X";
            }
        }

        private void CheckForWinner()
        {
            if ((A1_bttn.Text == "X" && A2_bttn.Text == "X" && A3_bttn.Text == "X") ||
                (B1_bttn.Text == "X" && B2_bttn.Text == "X" && B3_bttn.Text == "X") ||
                (C1_bttn.Text == "X" && C2_bttn.Text == "X" && C3_bttn.Text == "X") ||
                (A1_bttn.Text == "X" && B1_bttn.Text == "X" && C1_bttn.Text == "X") ||
                (A2_bttn.Text == "X" && B2_bttn.Text == "X" && C2_bttn.Text == "X") ||
                (A3_bttn.Text == "X" && B3_bttn.Text == "X" && C3_bttn.Text == "X") ||
                (A1_bttn.Text == "X" && B2_bttn.Text == "X" && C3_bttn.Text == "X") ||
                (A3_bttn.Text == "X" && B2_bttn.Text == "X" && C1_bttn.Text == "X"))

                {
                MessageBox.Show("X Wins!");
                intXWins++;
                XScore_lbl.Text = intXWins.ToString();
                }

            else if ((A1_bttn.Text == "O" && A2_bttn.Text == "O" && A3_bttn.Text == "O") ||
                (B1_bttn.Text == "O" && B2_bttn.Text == "O" && B3_bttn.Text == "O") ||
                (C1_bttn.Text == "O" && C2_bttn.Text == "O" && C3_bttn.Text == "O") ||
                (A1_bttn.Text == "O" && B1_bttn.Text == "O" && C1_bttn.Text == "O") ||
                (A2_bttn.Text == "O" && B2_bttn.Text == "O" && C2_bttn.Text == "O") ||
                (A3_bttn.Text == "O" && B3_bttn.Text == "O" && C3_bttn.Text == "O") ||
                (A1_bttn.Text == "O" && B2_bttn.Text == "O" && C3_bttn.Text == "O") ||
                (A3_bttn.Text == "O" && B2_bttn.Text == "O" && C1_bttn.Text == "O"))

            {
                MessageBox.Show("O Wins!");
                intOWins++;
                OScore_lbl.Text = intOWins.ToString();
            }

            else if (A1_bttn.Text !="" && A2_bttn.Text != "" && A3_bttn.Text != "" &&
                B1_bttn.Text != "" && B2_bttn.Text != "" && B3_bttn.Text != "" &&
                C1_bttn.Text != "" && C2_bttn.Text != "" && C3_bttn.Text != "")
            {
                MessageBox.Show("It's a tie!");
                intTies++;
                TieScore_lbl.Text = intTies.ToString();
            }
        }

        private void resetGame()
        {
            A1_bttn.Enabled = true;
            A1_bttn.Text = "";
            A2_bttn.Enabled = true;
            A2_bttn.Text = "";
            A3_bttn.Enabled = true;
            A3_bttn.Text = "";
            B1_bttn.Enabled = true;
            B1_bttn.Text = "";
            B2_bttn.Enabled = true;
            B2_bttn.Text = "";
            B3_bttn.Enabled = true;
            B3_bttn.Text = "";
            C1_bttn.Enabled = true;
            C1_bttn.Text = "";
            C2_bttn.Enabled = true;
            C2_bttn.Text = "";
            C3_bttn.Enabled = true;
            C3_bttn.Text = "";
        }

        private void A1_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                A1_bttn.Text = "X";
            }
            else
            {
                A1_bttn.Text = "O";
            }
            A1_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void A2_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                A2_bttn.Text = "X";
            }
            else
            {
                A2_bttn.Text = "O";
            }
            A2_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void A3_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                A3_bttn.Text = "X";
            }
            else
            {
                A3_bttn.Text = "O";
            }
            A3_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void B1_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                B1_bttn.Text = "X";
            }
            else
            {
                B1_bttn.Text = "O";
            }
            B1_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void B2_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                B2_bttn.Text = "X";
            }
            else
            {
                B2_bttn.Text = "O";
            }
            B2_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void B3_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                B3_bttn.Text = "X";
            }
            else
            {
                B3_bttn.Text = "O";
            }
            B3_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void C1_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                C1_bttn.Text = "X";
            }
            else
            {
                C1_bttn.Text = "O";
            }
            C1_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void C2_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                C2_bttn.Text = "X";
            }
            else
            {
                C2_bttn.Text = "O";
            }
            C2_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void C3_bttn_Click(object sender, EventArgs e)
        {
            if (strWhoseTurnItIs == "X")
            {
                C3_bttn.Text = "X";
            }
            else
            {
                C3_bttn.Text = "O";
            }
            C3_bttn.Enabled = false;
            CheckForWinner();
            ChangeTurn();
        }

        private void NewGame_bttn_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intXWins = 0;
            intOWins = 0;
            intTies = 0;
            strWhoseTurnItIs = "X";
        }

    }
}