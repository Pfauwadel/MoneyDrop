using MoneyDrop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private static List<Answer> listAnswer = new List<Answer>()
        {
            new Answer(){Id=1, IsValid=true, Order=1, QuestionId=1, Value="blanc"},
            new Answer(){Id=2, IsValid=false, Order=2, QuestionId=1, Value="rouge"},
            new Answer(){Id=3, IsValid=false, Order=3, QuestionId=1, Value="jaune"},
            new Answer(){Id=4, IsValid=false, Order=4, QuestionId=1, Value="noir"},
            new Answer(){Id=5, IsValid=true, Order=1, QuestionId=2, Value="blanc"},
            new Answer(){Id=6, IsValid=false, Order=2, QuestionId=2, Value="rouge"},
            new Answer(){Id=7, IsValid=false, Order=3, QuestionId=2, Value="jaune"},
            new Answer(){Id=8, IsValid=false, Order=4, QuestionId=2, Value="noir"},
            new Answer(){Id=9, IsValid=true, Order=1, QuestionId=3, Value="blanc"},
            new Answer(){Id=10, IsValid=false, Order=2, QuestionId=3, Value="rouge"},
            new Answer(){Id=11, IsValid=false, Order=3, QuestionId=3, Value="jaune"},
            new Answer(){Id=12, IsValid=false, Order=4, QuestionId=3, Value="noir"}
        };

        public List<Answer> GetAll(int questionId)
        {
            return listAnswer.FindAll(x => x.QuestionId == questionId);
        }

        public Answer Get(int answerId)
        {
            return listAnswer.Find(x => x.Id == answerId);
        }

        public int Insert(Answer answer)
        {
            listAnswer.Add(answer);
            return answer.Id;
        }

        public void Update(Answer answer)
        {
            
        }

        public void Delete(int answerId)
        { }
    }

    public interface IAnswerRepository
    {
        List<Answer> GetAll(int questionId);

        Answer Get(int answerId);

        int Insert(Answer answer);

        void Update(Answer answer);

        void Delete(int answerId);

    }
}
