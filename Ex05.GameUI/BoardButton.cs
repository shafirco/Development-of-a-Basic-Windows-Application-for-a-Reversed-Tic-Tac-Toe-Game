using System.Windows.Forms;
using System.Drawing;

namespace Ex05.GameUI
{
    public class BoardButton : Button
    {
        private readonly int r_Row, r_Col;

        public BoardButton(int i_Row, int i_Col, int i_ButtonSize)
        {
            r_Row = i_Row;
            r_Col = i_Col;
            Size = new Size(i_ButtonSize, i_ButtonSize);
            Location = new Point((i_ButtonSize * r_Col) + 10, (i_ButtonSize * r_Row) + 60);
        }

        public int Row
        {
            get { return r_Row; }
        }

        public int Col
        {
            get { return r_Col; }
        }
    }
}
