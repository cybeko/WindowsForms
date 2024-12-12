using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_tic_tac_toe
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly IModel _model;

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.StartButtonClick += OnStartButtonClick;
        }

        private void OnStartButtonClick(object sender, EventArgs e)
        {
            bool isComputerFirst = ((TicTacToeForm)_view).isComputerFirst.Checked;
            StartGame(isComputerFirst);
        }

        public void StartGame(bool isComputerFirst)
        {
            _model.IsGameStarted = true;
            _model.IsCrossTurn = !isComputerFirst;

            _view.SetMessage(_model.IsCrossTurn ? "Your turn" : "Computer's turn");

            if (isComputerFirst)
            {
                ComputerTurn();
            }
        }

        public void HandleButtonClick(int index)
        {
            if (!_model.IsGameStarted) return;

            _model.GameState[index] = _model.IsCrossTurn ? "X" : "O";
            _view.UpdateButton(index, _model.GameState[index], false, _model.IsCrossTurn ? Color.LightBlue : Color.LightPink);

            if (_model.CheckWin())
            {
                _view.ShowWinner(_model.IsCrossTurn ? "X" : "O");
                return;
            }

            if (_model.CheckTie())
            {
                _view.ShowTie();
                return;
            }

            _model.IsCrossTurn = !_model.IsCrossTurn;
            _view.SetMessage(_model.IsCrossTurn ? "Your turn" : "Computer's turn");

            if (!_model.IsCrossTurn)
            {
                ComputerTurn();
            }
        }

        private void ComputerTurn()
        {
            var random = new Random();
            var cells = _model.GameState.Select((value, index) => new { value, index })
                                                 .Where(x => string.IsNullOrEmpty(x.value))
                                                 .Select(x => x.index)
                                                 .ToList();
            if (cells.Count > 0)
            {
                int chosenIndex = cells[random.Next(cells.Count)];
                _model.GameState[chosenIndex] = "O";
                _view.UpdateButton(chosenIndex, "O", false, Color.LightPink);

                if (_model.CheckWin())
                {
                    _view.ShowWinner("O");
                }
                else if (_model.CheckTie())
                {
                    _view.ShowTie();
                }
                else
                {
                    _model.IsCrossTurn = true;
                    _view.SetMessage("Your turn");
                }
            }
        }

        public void ResetGame()
        {
            _model.GameState = Enumerable.Repeat(string.Empty, 9).ToList();
            _model.IsGameStarted = false;
            _model.IsCrossTurn = true;
            _view.SetMessage("Click 'Start' to begin the game");
        }
    }
}
