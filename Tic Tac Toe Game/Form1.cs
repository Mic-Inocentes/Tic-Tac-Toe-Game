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