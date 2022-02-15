using System.Collections.Generic;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class Question
    {
        public int Index{ get; set; }
        public int ID { set; get; }
        public string QuestionText { set; get; }
        public List<Answer> Answers { set; get; }
        public string SelectedAnswer { set; get; }
        public string CorrectAnswer { set; get; }
        public string ImageAnswer { set; get; }
        public Question()
        {
            Answers = new List<Answer>();
        }
    }
    public class Answer
    {
        public string ID { set; get; }
        public string AnswerText { set; get; }
    }
    public class Evaluation
    {
        public List<Question> Questions { set; get; }
        public int Id_Sub { set; get; }
        public int Id_Type { set; get; }
        public Evaluation()
        {
            Questions = new List<Question>();
        }
    }
}
