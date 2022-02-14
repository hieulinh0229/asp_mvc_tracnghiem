using System.Collections.Generic;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class Question
    {
        public int ID { set; get; }
        public string QuestionText { set; get; }
        public List<Answer> Answers { set; get; }
        public int SelectedAnswer { set; get; }
        public Question()
        {
            Answers = new List<Answer>();
        }
    }
    public class Answer
    {
        public int ID { set; get; }
        public string AnswerText { set; get; }
    }
    public class Evaluation
    {
        public List<Question> Questions { set; get; }
        public Evaluation()
        {
            Questions = new List<Question>();
        }
    }
}
