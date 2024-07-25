using System;
using System.Windows.Forms;

namespace Ex05.GameUI
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1player2.Enabled = !textBox1player2.Enabled;
            textBox1player2.Text = textBox1player2.Enabled ? string.Empty : "Computer";
        }

        private void numericUpDown1Rows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2Cols.Value = numericUpDown1Rows.Value;
        }

        private void numericUpDown2Cols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1Rows.Value = numericUpDown2Cols.Value;
        }

        public string NamePlayer1
        {
            get { return textBox2Player1.Text; }
        }

        public string NamePlayer2
        {
            get { return textBox1player2.Text; }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (NamePlayer1 == string.Empty || ((checkBox1.Checked) && (NamePlayer2 == string.Empty)))
            {
                MessageBox.Show("The name field is empty, please fill it in", "Error");
            }
            else 
            {
                GameForm gameForm = new GameForm((int)numericUpDown2Cols.Value, NamePlayer1, NamePlayer2);
                Dispose();
                gameForm.ShowDialog();
            }
        }
    }
}
