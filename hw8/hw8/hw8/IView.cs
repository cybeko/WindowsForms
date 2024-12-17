using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public interface IView
    {
        event EventHandler<EventArgs> StartButtonClick;
        event EventHandler<EventArgs> AnswerButtonClick;
        event EventHandler<EventArgs> ExitButtonClick;
        void DisplayQuestion(string questionText);
        void DisplayAnswers(List<string> answers);
        void ShowAnswerResult(bool isCorrect);
        void DisplayPoints(Dictionary<int, bool> points);
        public void UpdateCurrentSum(int currentSum);
        public void UpdateSafeAmount(int safeAmount);
        void ShowWinMessage(int currentAmt);
        void ShowLossMessage(int safeAmt);
        void ResetGameUI();
    }


}
