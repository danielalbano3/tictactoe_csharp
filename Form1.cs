using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new String[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            } 
            else
            {
                return "X";
            }
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break; 
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break; 
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }

                if (combination.Equals("OOO")){
                    MessageBox.Show("O has won!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show("X has won!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[0];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button1.Text = gb;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[1];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button2.Text = gb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[2];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button3.Text = gb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[3];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button4.Text = gb;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[4];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button5.Text = gb;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[5];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button6.Text = gb;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[6];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button7.Text = gb;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[7];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button8.Text = gb;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String gb = gameBoard[8];
            currentTurn++;
            gb = returnSymbol(currentTurn);
            button9.Text = gb;
        }
    }
}
