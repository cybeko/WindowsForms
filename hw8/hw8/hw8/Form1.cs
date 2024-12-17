using hw8;

namespace MillionaireGame
{
    public partial class FormGame : Form, IView
    {
        public event EventHandler<EventArgs> StartButtonClick;
        public event EventHandler<EventArgs> AnswerButtonClick;
        public event EventHandler<EventArgs> ExitButtonClick;
        public FormGame()
        {
            InitializeComponent();
            ResetGameUI();

            buttonAnswerA.Click += buttonAnswer_Click;
            buttonAnswerB.Click += buttonAnswer_Click;
            buttonAnswerC.Click += buttonAnswer_Click;
            buttonAnswerD.Click += buttonAnswer_Click;

            listBoxPoints.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxPoints.DrawItem += listBoxPoints_DrawItem;
        }
        private void listBoxPoints_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                var listItem = listBoxPoints.Items[e.Index] as Item;

                if (listItem != null)
                {
                    e.DrawBackground();
                    using (Brush brush = new SolidBrush(listItem.ForeColor))
                    {
                        e.Graphics.DrawString(listItem.Text, e.Font, brush, e.Bounds);
                    }
                }
            }
        }
        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartButtonClick?.Invoke(this, EventArgs.Empty);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButtonClick?.Invoke(this, EventArgs.Empty);
        }
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            AnswerButtonClick?.Invoke(sender, e);
        }
        public void DisplayQuestion(string questionText)
        {
            textBoxQuestion.Text = questionText;
        }
        public void DisplayAnswers(List<string> answers)
        {
            buttonAnswerA.Text = answers[0];
            buttonAnswerB.Text = answers[1];
            buttonAnswerC.Text = answers[2];
            buttonAnswerD.Text = answers[3];
        }
        public void ShowAnswerResult(bool isCorrect)
        {
            string message = isCorrect ? "Correct" : "Wrong";
            MessageBox.Show(message, "Answer", MessageBoxButtons.OK);
        }
        public void DisplayPoints(Dictionary<int, bool> points)
        {
            listBoxPoints.Items.Clear();
            var sortedPoints = points.OrderByDescending(x => x.Key).ToList();
            foreach (var point in sortedPoints)
            {
                string text = $"${point.Key}";

                var item = new Item
                {
                    Text = text,
                    ForeColor = point.Value ? Color.Orange : Color.Yellow
                };

                listBoxPoints.Items.Add(item);
            }
        }
        public void UpdateCurrentSum(int currentSum)
        {
            textBoxCurrentSum.Text = $"${currentSum}";
        }

        public void UpdateSafeAmount(int safeAmount)
        {
            textBoxSafeAmount.Text = $"${safeAmount}";
        }

        public void ShowWinMessage(int currentSum)
        {
            MessageBox.Show($"Congratulations! You won ${currentSum}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowLossMessage(int safeAmount)
        {
            MessageBox.Show($"Game over! You walk away with ${safeAmount}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ResetGameUI()
        {
            textBoxCurrentSum.Clear();
            textBoxSafeAmount.Clear();

            buttonAnswerA.Text = "";
            buttonAnswerB.Text = "";
            buttonAnswerC.Text = "";
            buttonAnswerD.Text = "";

            textBoxQuestion.Text = "Press 'Start Game'";
            listBoxPoints.Items.Clear();
        }
    }
    public class Item
    {
        public string Text { get; set; }
        public Color ForeColor { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
