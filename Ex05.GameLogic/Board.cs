namespace Ex05.GameLogic
{
    public class Board
    {
        private int m_Size, m_NumOfSignsInBoard;
        private eXorO?[,] m_Mat = null;
        private int[] m_NumOfXInRows = null;
        private int[] m_NumOfOInRows = null;
        private int[] m_NumOfXInCols = null;
        private int[] m_NumOfOInCols = null;

        private void initiateBoard()
        {
            m_Mat = new eXorO?[m_Size, m_Size];
            m_NumOfXInRows = new int[m_Size];
            m_NumOfOInRows = new int[m_Size];
            m_NumOfXInCols = new int[m_Size];
            m_NumOfOInCols = new int[m_Size];
            m_NumOfSignsInBoard = 0;
        }

        public int Size
        {
            get { return m_Size; }
            set
            {
                m_Size = value;
                initiateBoard();
            }
        }

        public int NumOfSignsInBoard
        {
            get
            {
                return m_NumOfSignsInBoard;
            }
        }

        public void CleanBoard()
        {
            initiateBoard();
        }

        public void MakeMove(eCurrentPlayer i_CurrentPlayer, int i_Row, int i_Col)
        {
            this[i_Row, i_Col] = (i_CurrentPlayer == eCurrentPlayer.First ? eXorO.X : eXorO.O);
        }

        public eXorO? this[int i_Row, int i_Col]
        {
            get
            {
                return m_Mat[i_Row, i_Col];
            }
            set
            {
                m_Mat[i_Row, i_Col] = value;
                increaseMatCounter(value, i_Row, i_Col);
            }
        }

        private bool IsIndexOutOfRange(int i_Row, int i_Col)
        {
            return i_Row < 0 || i_Col < 0 || i_Row >= m_Size || i_Col >= m_Size;
        }


        private void increaseMatCounter(eXorO? i_Value, int i_Row, int i_Col)
        {
            if (i_Value == eXorO.X)
            {
                m_NumOfXInRows[i_Row]++;
                m_NumOfXInCols[i_Col]++;
            }
            else if (i_Value == eXorO.O)
            {
                m_NumOfOInRows[i_Row]++;
                m_NumOfOInCols[i_Col]++;
            }

            if (i_Value != null)
            {
                m_NumOfSignsInBoard++;
            }
        }

        public bool IsThereATie()
        {
            return m_NumOfSignsInBoard == m_Size * m_Size;
        }

        public bool IsThereAStreak(eCurrentPlayer i_currentPlayer)
        {
            eXorO signLookingFor = (i_currentPlayer == eCurrentPlayer.First ? eXorO.X : eXorO.O);
            bool streak = false;

            if (signLookingFor == eXorO.X)
            {
                streak = checksForStreak(m_NumOfXInRows) || checksForStreak(m_NumOfXInCols) ||
                checksForMainDiagonalStreak(signLookingFor) || checksForSecondaryDiagonalStreak(signLookingFor);
            }
            else if (signLookingFor == eXorO.O)
            {
                streak = checksForStreak(m_NumOfOInRows) || checksForStreak(m_NumOfOInCols) ||
                checksForMainDiagonalStreak(signLookingFor) || checksForSecondaryDiagonalStreak(signLookingFor);
            }

            return streak;
        }

        private bool checksForStreak(int[] i_CountArr)
        {
            bool isStreak = false;

            for(int i = 0; i < m_Size && !isStreak; ++i)
            {
                if (i_CountArr[i] == m_Size)
                {
                    isStreak = true;
                }
            }

            return isStreak;
        }

        private bool checksForMainDiagonalStreak(eXorO i_SighLookingFor)
        {
            bool diagonalStreak = true;
            
            for (int i = 0; i < m_Size && diagonalStreak; i++)
            {
                if (m_Mat[i, i] != i_SighLookingFor)
                {
                    diagonalStreak = false;
                }
            }

            return diagonalStreak;
        }

        private bool checksForSecondaryDiagonalStreak(eXorO i_SighLookingFor)
        {
            bool secondaryDiagonalStreak = true;

            for (int i = 0; i < m_Size && secondaryDiagonalStreak; i++)
            {
                if (m_Mat[i, m_Size - i - 1] != i_SighLookingFor)
                {
                    secondaryDiagonalStreak = false;
                }
            }

            return secondaryDiagonalStreak;
        }
    }
}
