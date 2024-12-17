using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace hw8
{
    public class Model : IModel
    {
        public List<Question> Questions { get; set; }
        public Dictionary<int, bool> Points { get; set; }

        public int CurrentAmount { get; set; } = 0;
        public int SafeAmount { get; set; } = 0;
        public int CurrentPointId { get; set; } = 0;

        public Model() { 
            Questions = new List<Question>();
            Points = new Dictionary<int, bool>();
        }
        public void LoadQuestionsFromFile(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            List<Question> deserializedQuestions = JsonSerializer.Deserialize<List<Question>>(jsonData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (deserializedQuestions != null)
            {
                Questions = deserializedQuestions;
            }
            else
            {
                MessageBox.Show("No questions in the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadPointsFromFile(string filePath)
        {
            string jsonPoints = File.ReadAllText(filePath);
            var points = JsonSerializer.Deserialize<Dictionary<string, bool>>(jsonPoints);
            Points = points.ToDictionary(x => int.Parse(x.Key), x => x.Value);
        }
        public void UpdateAmount(int questionId)
        {
            if (questionId < 0 || questionId >= Points.Count)
            {
                return;
            }

            CurrentAmount = Points.ElementAt(questionId).Key;

            if (Points[CurrentAmount])
            {
                SafeAmount = CurrentAmount;
            }
        }
        public bool CheckAnswer(Answer answer)
        {
            return answer.IsCorrect;
        }
    }
}

