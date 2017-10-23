//using MoneyDrop.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MoneyDrop.Repository
//{
//    public class QuizzRepository : IQuizzRepository
//    {
//        private static List<Quizz> listQuizz = new List<Quizz>()
//        {
//            new Quizz(){Id = 1, Name = "Quizz1"}
//        };

//        public List<Quizz> GetAll()
//        {
//            return listQuizz;
//        }

//        public Quizz Get(int id)
//        {
//            return listQuizz.Find(x => x.Id == id);
//        }
//    }

//    public interface IQuizzRepository
//    {
//        List<Quizz> GetAll();

//        Quizz Get(int id);
//    }
//}
