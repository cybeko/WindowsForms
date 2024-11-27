namespace winform1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            int min = 1;
            int max = 2000;
            int countAttempts = 0;

            while (true)
            {
                int guess = (min + max) / 2;
                countAttempts++;

                DialogResult result = MessageBox.Show(
                    $"Is your number {guess}?",
                    "Guessing number",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Number was guessed in {countAttempts} attempts", "Result", MessageBoxButtons.OK);

                    DialogResult playAgain = MessageBox.Show(
                        "Play again?",
                        "Start new game",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (playAgain == DialogResult.Yes)
                        StartGame();
                    else
                        this.Close();
                    break;
                }
                else if (result == DialogResult.No)
                {
                    DialogResult bigger = MessageBox.Show(
                        "Is your number bigger?",
                        "Guess",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (bigger == DialogResult.Yes)
                    {
                        min = guess + 1;
                    }
                    else
                        max = guess - 1;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();

        }
    }
}
