using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Models
{
    [BsonDiscriminator(Required =true)]
    public class Question
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public int QuizzId { get; set; }

        public int Order { get; set; }

        public string Text { get; set; }

        public List<Answer> ListAnswer { get; set; }

        public Question()
        {
            this.ListAnswer = new List<Answer>();
        }
    }
}
