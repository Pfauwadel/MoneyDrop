using MoneyDrop.Repository;
using MoneyDrop.test;
using System;
using System.Linq;

namespace MoneyDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new ZooDbContext())
            //{
            //    db.Animals.Add(new Tiger { Name = "Tigger", Age = 6.4, Height = .98, Weight = 201.4 });
            //    db.SaveChanges();

            //    foreach (var tiger in db.Animals.OfType<Tiger>())
            //    {
            //        Console.WriteLine($"{tiger.Name}: {tiger.Age}yo, {tiger.Height}m, {tiger.Weight}kg");
            //    }
            //    Console.ReadKey();
            //}

            using(var db = new MoneyDropDbContext())
            {
                Models.Quizz quizz = new Models.Quizz { Name = "Test new Quizz" };
                //quizz.ListQuestion.Add(new Models.Question { Order = 1, Text = "Question" });
                db.Quizzs.Add(quizz);
                var id = db.SaveChanges();

                foreach(var q in db.Quizzs)
                {
                    Console.WriteLine("Quizz : " + q.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
