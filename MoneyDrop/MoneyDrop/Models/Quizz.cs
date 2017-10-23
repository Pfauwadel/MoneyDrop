using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Models
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    public class Quizz
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        //public List<Question> ListQuestion { get; set; }

        public Quizz()
        {
            //this.ListQuestion = new List<Question>();
        }
    }
}
