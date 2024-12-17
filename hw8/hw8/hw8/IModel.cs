using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public interface IModel
    {
        public List<Question> Questions { get; set; }
        Dictionary<int, bool> Points { get; set; }
        int CurrentAmount { get; set; }
        int SafeAmount { get; set; }
        int CurrentPointId { get; set; }
        public void LoadPointsFromFile(string filePath);
        public void LoadQuestionsFromFile(string path);
        public void UpdateAmount(int questionId);
        public bool CheckAnswer(Answer answer);


    }
}
