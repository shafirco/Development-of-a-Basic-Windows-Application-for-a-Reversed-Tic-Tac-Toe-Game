using System;

namespace Ex05.GameLogic
{
    public class TicTacToe
    {
        private static Board s_Board = new Board();
        private static Player s_Player1 = new Player(), s_Player2 = new Player();
        private static eCurrentPlayer s_CurrentPlayer;
        public event Action InvalidPlay;
        public event Action GameOver;

        public eCurrentPlayer CurrentPlayer { get { return s_CurrentPlayer; } set { s_CurrentPlayer = value; } }

        public bool Player2IsHuman { get; }

        public Player Player1 { get { return s_Player1; } }

        public Player Player2 { get { return s_Player2; } }

        public Board Board { get { return s_Board; } }

        public TicTacToe(int i_BoardSize, bool i_Player2IsHuman, string i_Player1Name, string i_Player2Name)
        {
            s_Board.Size = i_BoardSize;
            Player2IsHuman = i_Player2IsHuman;
            s_Player1.Name = i_Player1Name;
            s_Player2.Name = i_Player2Name;
        }

        private void onInvalidPlay()
        {
            InvalidPlay?.Invoke();
        }

        private void onGameOver()
        {
            GameOver?.Invoke();
        }

        public void HandleGameOver(bool i_isVictory)
        {
            if (i_isVictory)
            {
                if (s_CurrentPlayer == eCurrentPlayer.First)
                {
                    s_Player2.Score++;
                }
                else
                {
                    s_Player1.Score++;
                }
            }

            onGameOver();
            s_Board.CleanBoard();
        }

        public bool MakeAMove(int i_Row, int i_Col)
        {
            bool validMove = true;

            if (s_Board[i_Row, i_Col] != null)
            {
                onInvalidPlay();
                validMove = false;
            }
            else
            {
                s_Board.MakeMove(s_CurrentPlayer, i_Row, i_Col);
            }
            
            return validMove;
        }

        public bool CheckForTie()
        {
            return s_Board.IsThereATie();
        }

        public bool CheckForVictory()
        {
            return s_Board.IsThereAStreak(s_CurrentPlayer);
        }
    }
}
