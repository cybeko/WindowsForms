namespace winforms_tic_tac_toe
{
    public partial class Form1 : Form
    {
        private List<Button> gameButtons = new List<Button>();
        private bool isCrossTurn = true;
        private bool isGameStarted = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameButtons.Clear();

            for (int i = 1; i <= 9; i++)
            {
                Button button = (Button)this.Controls["button" + i];
                button.Text = string.Empty;
                button.Enabled = true;
                button.BackColor = Color.White;
                button.BackgroundImage = null;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                gameButtons.Add(button);
                button.Click += GameButton_Click;
            }

            isCrossTurn = true;
            isGameStarted = false;
            isComputerFirst.Checked = false;
            SetMessage("Click 'Start' to begin the game");
        }
        private void GameButton_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                SetMessage("Click 'Start' to begin the game");
                return;
            }

            Button clickedButton = (Button)sender;

            if (clickedButton.Enabled)
            {
                clickedButton.Text = isCrossTurn ? "X" : "O";
                clickedButton.Enabled = false;
                clickedButton.BackColor = isCrossTurn ? Color.LightBlue : Color.LightPink;

                if (CheckWin())
                {
                    MessageBox.Show(isCrossTurn ? "X wins!" : "O wins!", "Game Over");
                    InitializeGame();
                    return;
                }

                if (CheckTie())
                {
                    MessageBox.Show("It's a tie!", "Game Over");
                    InitializeGame();
                    return;
                }

                isCrossTurn = !isCrossTurn;
                SetMessage(isCrossTurn ? "X's turn" : "O's turn");

                if (!isCrossTurn)
                {
                    ComputerTurn();
                }
            }
        }

        private void ComputerTurn()
        {
            var availableButtons = new List<Button>();

            foreach (var button in gameButtons)
            {
                if (button.Enabled)
                {
                    availableButtons.Add(button);
                }
            }

            if (availableButtons.Count > 0)
            {
                var random = new Random();
                int index = random.Next(availableButtons.Count);
                Button selectedButton = availableButtons[index];

                selectedButton.Text = "O";
                selectedButton.Enabled = false;
                selectedButton.BackColor = Color.LightPink;

                if (CheckWin())
                {
                    MessageBox.Show("O wins!", "Game Over");
                    InitializeGame();
                    return;
                }

                if (CheckTie())
                {
                    MessageBox.Show("It's a tie!", "Game Over");
                    InitializeGame();
                    return;
                }

                isCrossTurn = true;
                SetMessage("Your turn");
            }
        }

        private bool CheckWin()
        {
            int[,] winCombinations = new int[,]
            {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };

            for (int i = 0; i < winCombinations.GetLength(0); i++)
            {
                int a = winCombinations[i, 0];
                int b = winCombinations[i, 1];
                int c = winCombinations[i, 2];

                if (!string.IsNullOrEmpty(gameButtons[a].Text) &&
                    gameButtons[a].Text == gameButtons[b].Text &&
                    gameButtons[a].Text == gameButtons[c].Text)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckTie()
        {
            foreach (var button in gameButtons)
            {
                if (button.Enabled)
                {
                    return false;
                }
            }

            return true;
        }
        private void SetMessage(string message)
        {
            this.Text = message;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isComputerFirst.Checked)
            {
                isCrossTurn = false;
                ComputerTurn();
            }
            else
            {
                isCrossTurn = true;
                SetMessage("Your turn");
            }
            isGameStarted = true;
        }
    }
}