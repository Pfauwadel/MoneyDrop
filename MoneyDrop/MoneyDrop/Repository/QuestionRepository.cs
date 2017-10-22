using MoneyDrop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private static List<Question> listQuestion = new List<Question>()
        {
            new Question(){Id = 1, QuizzId = 1, Order = 1, Text = "Quelle est la couleur du cheval blanc d'Henry IV?"}
        };

        public List<Question> GetAll(int quizzId)
        {
            return listQuestion.FindAll(x => x.QuizzId == quizzId);
        }

        public Question Get(int questionId)
        {
            return listQuestion.Find(x => x.Id == questionId);
        }

        public int Insert(Question question)
        {
            listQuestion.Add(question);
            return question.Id;
        }

        public void Update(Question question)
        {

        }

        public void Delete(int questionId) { }
    }

    public interface IQuestionRepository
    {
        List<Question> GetAll(int quizzId);

        Question Get(int questionId);

        int Insert(Question question);

        void Update(Question question);

        void Delete(int questionId);
    }
}
