namespace Ex05.GameLogic
{
    public class Player
    {
        private int m_Score;
        public string Name { get; set; }

        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
                m_Score = value;
            }
        }
    }
}
