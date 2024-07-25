using System;
using System.Drawing;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.GameUI
{
    public partial class GameForm : Form
    {
        private const int k_ButtonSize = 50;
        private readonly Color k_Player1Color = Color.PeachPuff;
        private readonly Color k_Player2Color = Color.LightSeaGreen;
        private readonly bool r_Player2IsHuman;
        private readonly int r_BoardSize;
        private readonly string r_Player1Name, r_Player2Name;
        private BoardButton[,] m_ButtonsBoard = null;
        private TicTacToe m_TicTacToe = null;

        public GameForm(int i_BoardSize, string i_player1Name, string i_player2Name)
        {
            r_BoardSize = i_BoardSize;
            r_Player1Name = i_player1Name;
            r_Player2Name = i_player2Name;
            r_Player2IsHuman = i_player2Name == "Computer" ? false : true;
            InitializeComponent();
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            initGameBoard();
            m_TicTacToe = new TicTacToe(r_BoardSize, r_Player2IsHuman, r_Player1Name, r_Player2Name);
            m_TicTacToe.InvalidPlay += ticTacToeGame_InvalidPlay;
            m_TicTacToe.GameOver += ticTacToeGame_GameOver;
        }

        private void ticTacToeGame_GameOver()
        {
            string roundWinner = getRoundWinnerAndUpdateScore();

            if (endOfRoundMessageBox(roundWinner))
            {
                clearGameBoard();
            }
            else
            {
                string finalWinner = getFinalWinnerName();
                MessageBox.Show(string.Format("{0}", finalWinner != string.Empty ? string.Format("The winner is {0}!", finalWinner) : "Tie!"));
                Close();
            }
        }

        private string getRoundWinnerAndUpdateScore()
        {
            string winnerName = string.Empty;

            if (m_TicTacToe.CheckForVictory())
            {
                winnerName = m_TicTacToe.CurrentPlayer == eCurrentPlayer.First ? m_TicTacToe.Player2.Name : m_TicTacToe.Player1.Name;
                if (m_TicTacToe.CurrentPlayer == eCurrentPlayer.First)
                {
                    player2Score.Text = m_TicTacToe.Player2.Score.ToString();
                }
                else
                {
                    player1Score.Text = m_TicTacToe.Player1.Score.ToString();
                }
            }

            return winnerName;
        }

        private string getFinalWinnerName()
        {
            string winnerName = string.Empty;
            if (m_TicTacToe.CheckForVictory())
            {
                if (m_TicTacToe.Player1.Score > m_TicTacToe.Player2.Score)
                {
                    winnerName = m_TicTacToe.Player1.Name;
                }
                else
                {
                    winnerName = m_TicTacToe.Player2.Name;
                }
            }

            return winnerName;
        }

        private void ticTacToeGame_InvalidPlay()
        {
            MessageBox.Show("Invalid move", "Error");
        }

        private void initGameBoard()
        {
            m_ButtonsBoard = new BoardButton[r_BoardSize, r_BoardSize];
            BoardButton button;

            for (int i = 0; i < r_BoardSize; ++i)
            {
                for (int j = 0; j < r_BoardSize; ++j)
                {
                    button = new BoardButton(i, j, k_ButtonSize);
                    button.BackColor = Color.LightBlue;
                    button.Text = string.Empty;
                    button.Click += new EventHandler(ticTacToeButton_OnClick);
                    Controls.Add(button);
                    m_ButtonsBoard[i, j] = button;
                }
            }
        }

        private void updateGameBoard(int i_Row, int i_Col, eXorO i_XorO)
        {
            BoardButton buttonToUpdate = m_ButtonsBoard[i_Row, i_Col];
            
            if (buttonToUpdate.Text == string.Empty)
            {
                buttonToUpdate.Text = i_XorO.ToString();
                buttonToUpdate.BackColor = i_XorO == eXorO.X ? k_Player1Color : k_Player2Color;
            }
        }

        private void clearGameBoard()
        {
            for (int i = 0; i < r_BoardSize; ++i)
            {
                for (int j = 0; j < r_BoardSize; j++)
                {
                    m_ButtonsBoard[i, j].BackColor = Color.Aqua;
                    m_ButtonsBoard[i, j].Text = string.Empty;
                }
            }

            m_TicTacToe.CurrentPlayer = eCurrentPlayer.First;
        }

        private void ticTacToeButton_OnClick(object sender, EventArgs e)
        {
            BoardButton button = sender as BoardButton;
            bool gameOver = false, isVictory;

            if (button != null)
            {
                bool validMove = m_TicTacToe.MakeAMove(button.Row, button.Col);

                if (!validMove)
                {
                    return;
                }

                eXorO sign = m_TicTacToe.CurrentPlayer == eCurrentPlayer.First ? eXorO.X : eXorO.O;
                updateGameBoard(button.Row, button.Col, sign);
                isVictory = m_TicTacToe.CheckForVictory();
                if (isVictory || m_TicTacToe.CheckForTie())
                {
                    m_TicTacToe.HandleGameOver(isVictory);
                    gameOver = true;
                }
                else if (!r_Player2IsHuman)
                {
                    int row = -1, col = -1;
                    m_TicTacToe.CurrentPlayer = m_TicTacToe.CurrentPlayer == eCurrentPlayer.First ? eCurrentPlayer.Second : eCurrentPlayer.First;
                    AI.MakeNextMove(m_TicTacToe.Board, ref row, ref col);
                    m_TicTacToe.MakeAMove(row, col);
                    sign = m_TicTacToe.CurrentPlayer == eCurrentPlayer.First ? eXorO.X : eXorO.O;
                    updateGameBoard(row, col, sign);
                    isVictory = m_TicTacToe.CheckForVictory();
                    if (isVictory || m_TicTacToe.CheckForTie())
                    {
                        m_TicTacToe.HandleGameOver(isVictory);
                        gameOver = true;
                    }
                }

                if (!gameOver)
                {
                    m_TicTacToe.CurrentPlayer = m_TicTacToe.CurrentPlayer == eCurrentPlayer.First ? eCurrentPlayer.Second : eCurrentPlayer.First;
                }
            }
        }

        private bool endOfRoundMessageBox(string i_WinnerName)
        {
            string tieOrWin = i_WinnerName == string.Empty ? "Tie!" : string.Format("The winner is {0}!", i_WinnerName);
            string message = string.Format("{0}{1}Would you like to play another round?", tieOrWin, Environment.NewLine);
            string title = i_WinnerName == string.Empty ? "A tie!" : "A win!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            return result == DialogResult.Yes;
        }
    }
}
