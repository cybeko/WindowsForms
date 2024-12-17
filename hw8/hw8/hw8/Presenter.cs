using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;
        private int _currentQuestionId;
        private Question _currentQuestion;
        private bool _isAnswering;
        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

            _view.StartButtonClick += OnStartButton;
            _view.AnswerButtonClick += OnAnswerButton;
            _view.ExitButtonClick += OnExitButton;

            _isAnswering = false;
        }
        private void OnExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnStartButton(object sender, EventArgs e)
        {
            string questionsPath = "questions.json";
            string pointsPath = "points.json";

            ResetGame();
            _model.LoadQuestionsFromFile(questionsPath);
            _model.LoadPointsFromFile(pointsPath);

            _view.DisplayPoints(_model.Points);
            _view.UpdateCurrentSum(_model.CurrentAmount);
            _view.UpdateSafeAmount(_model.SafeAmount);

            _currentQuestionId = 0;
            LoadNextQuestion();
        }
        private void LoadNextQuestion()
        {
            if (_currentQuestionId < _model.Questions.Count)
            {
                _currentQuestion = _model.Questions[_currentQuestionId];
                _view.DisplayQuestion(_currentQuestion.QuestionText);
                _view.DisplayAnswers(_currentQuestion.Answers.Select(a => a.Text).ToList());
                _isAnswering = true;
            }
        }
        private void OnAnswerButton(object sender, EventArgs e)
        {
            if (!_isAnswering)
                return;

            Button clickedButton = (Button)sender;
            string selectedAnswerText = clickedButton.Text;

            Answer answer = _currentQuestion.Answers.FirstOrDefault(a => a.Text == selectedAnswerText);
            if (answer != null)
            {
                bool isCorrect = _model.CheckAnswer(answer);
                _view.ShowAnswerResult(isCorrect);
                if (isCorrect)
                {
                    _model.UpdateAmount(_currentQuestionId);
                    _view.UpdateCurrentSum(_model.CurrentAmount);
                    _view.UpdateSafeAmount(_model.SafeAmount);

                    if (_currentQuestionId >= _model.Questions.Count - 1)
                    {
                        _view.ShowWinMessage(_model.CurrentAmount);
                        ResetGame();
                    }
                    else
                    {
                        _isAnswering = false;
                        var timer = new System.Windows.Forms.Timer
                        {
                            Interval = 100
                        };
                        timer.Tick += (s, args) =>
                        {
                            timer.Stop();
                            _currentQuestionId++;
                            LoadNextQuestion();
                        };
                        timer.Start();
                    }
                }
                else
                {
                    _view.ShowLossMessage(_model.SafeAmount);
                    ResetGame();
                }
            }
        }
        private void ResetGame()
        {
            _model.CurrentAmount = 0;
            _model.SafeAmount = 0;
            _model.CurrentPointId = 0;
            _currentQuestionId = 0;

            _view.ResetGameUI();
        }
    }
}
