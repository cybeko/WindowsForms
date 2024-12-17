using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string questionText, List<Answer> answers)
        {
            QuestionText = questionText;
            Answers = answers;
        }
    }
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
