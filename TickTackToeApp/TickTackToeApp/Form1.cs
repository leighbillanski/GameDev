using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool turn = true; // true = X; false = O;
        int count = 0;


        private void gbxPlayer1_Enter(object sender, EventArgs e)
        {

        }       

        private void lblPlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;

            checkForWinner();
            count++;
        }

        private void checkForWinner()
        {
            bool winner = false;

            if((btnUL.Text == btnUM.Text)&&(btnUM.Text == btnUR.Text)&&(!btnUL.Enabled)){
                winner = true;
            }

            if ((btnUL.Text == btnML.Text) && (btnML.Text == btnLL.Text) && (!btnUL.Enabled))
            {
                winner = true;
            }

            if ((btnUL.Text == btnMM.Text) && (btnMM.Text == btnLR.Text) && (!btnUL.Enabled))
            {
                winner = true;
            }

            if ((btnML.Text == btnMM.Text) && (btnMM.Text == btnMR.Text) && (!btnMR.Enabled))
            {
                winner = true;
            }

            if ((btnLL.Text == btnLM.Text) && (btnLM.Text == btnLR.Text) && (!btnLR.Enabled))
            {
                winner = true;
            }

            if ((btnUM.Text == btnMM.Text) && (btnMM.Text == btnLM.Text) && (!btnLM.Enabled))
            {
                winner = true;
            }

            if ((btnUR.Text == btnMR.Text) && (btnMR.Text == btnLR.Text) && (!btnLR.Enabled))
            {
                winner = true;
            }

            if (winner)
            {
                disableButtons();

                string theWinner = "";
                if (turn)
                {
                    theWinner = "Player 2";
                    btnLL.Visible = false;
                    btnLM.Visible = false;
                    btnLR.Visible = false;
                    btnUL.Visible = false;
                    btnMR.Visible = false;
                    btnUR.Visible = false;
                    btnUM.Visible = false;
                    btnML.Visible = false;
                    btnMM.Visible = false;
                    btnNewGame.Visible = true;
                    btnNewGame.Enabled = true;
                    btnExit.Visible = true;
                    btnExit.Enabled = true;
                }
                else
                {
                    theWinner = "Player 1";
                    btnLL.Visible = false;
                    btnLM.Visible = false;
                    btnLR.Visible = false;
                    btnUL.Visible = false;
                    btnMR.Visible = false;
                    btnUR.Visible = false;
                    btnUM.Visible = false;
                    btnML.Visible = false;
                    btnMM.Visible = false;
                    btnNewGame.Visible = true;
                    btnNewGame.Enabled = true;
                    btnExit.Visible = true;
                    btnExit.Enabled = true;
                }

                MessageBox.Show(theWinner + " wins", "You win!");
                
            }
            else if (count == 8)
            {
                MessageBox.Show("Draw", "Too Bad");
                btnLL.Visible = false;
                btnLM.Visible = false;
                btnLR.Visible = false;
                btnUL.Visible = false;
                btnMR.Visible = false;
                btnUR.Visible = false;
                btnUM.Visible = false;
                btnML.Visible = false;
                btnMM.Visible = false;
                btnNewGame.Visible = true;
                btnNewGame.Enabled = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void clearButtons()
        {
            try
            {
                count = 0;
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Text = "";
                    b.Enabled = true;
                    turn = true;
                }
            }
            catch { }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnNewGame.Text = "New Game";
            btnExit.Text = "Exit";
            btnLL.Visible = true;
            btnLM.Visible = true;
            btnLR.Visible = true;
            btnUL.Visible = true;
            btnMR.Visible = true;
            btnUR.Visible = true;
            btnUM.Visible = true;
            btnML.Visible = true;
            btnMM.Visible = true;
            btnNewGame.Visible = false;
            btnExit.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaylynn Johnson 216194806", "Developer Name");
        }
    }
}
