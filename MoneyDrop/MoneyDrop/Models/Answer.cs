using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Models
{
    [BsonDiscriminator(Required =true)]
    public class Answer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public int QuestionId { get; set; }

        public int Order { get; set; }

        public string Value { get; set; }

        public bool IsValid { get; set; }
    }
}
