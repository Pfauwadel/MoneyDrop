using MoneyDrop.test;
using System;
using System.Linq;

namespace MoneyDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ZooDbContext())
            {
                db.Animals.Add(new Tiger { Name = "Tigger", Age = 6.4, Height = .98, Weight = 201.4 });
                db.SaveChanges();

                foreach (var tiger in db.Animals.OfType<Tiger>())
                {
                    Console.WriteLine($"{tiger.Name}: {tiger.Age}yo, {tiger.Height}m, {tiger.Weight}kg");
                }
                Console.ReadKey();
            }
        }
    }
}
