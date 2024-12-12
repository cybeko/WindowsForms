namespace winforms_tic_tac_toe
{
    public partial class TicTacToeForm : Form, IView
    {
        private readonly Presenter _presenter;
        private List<Button> _gameButtons;

        public event EventHandler<EventArgs> StartButtonClick;

        public TicTacToeForm()
        {
            InitializeComponent();
            _presenter = new Presenter(this, new Model());
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _gameButtons = Enumerable.Range(1, 9).Select(i => (Button)Controls["button" + i]).ToList();

            foreach (var button in _gameButtons)
            {
                button.Click += (s, _) => _presenter.HandleButtonClick(_gameButtons.IndexOf((Button)s));
            }

            Controls["buttonStart"].Click += (s, _) =>
            {
                StartButtonClick?.Invoke(this, EventArgs.Empty);
            };
        }

        public void SetMessage(string message)
        {
            Text = message;
        }

        public void UpdateButton(int index, string text, bool isEnabled, Color backgroundColor)
        {
            var button = _gameButtons[index];
            button.Text = text;
            button.Enabled = isEnabled;
            button.BackColor = backgroundColor;
        }

        public void ShowWinner(string winner)
        {
            MessageBox.Show($"{winner} wins!", "Game Over");
            ResetGame();
        }

        public void ShowTie()
        {
            MessageBox.Show("It's a tie!", "Game Over");
            ResetGame();
        }

        public void ResetGame()
        {
            foreach (var button in _gameButtons)
            {
                button.Text = string.Empty;
                button.Enabled = true;
                button.BackColor = Color.White;
            }
            _presenter.ResetGame();
        }
    }
}
