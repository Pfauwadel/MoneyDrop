using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public int Order { get; set; }

        public string Value { get; set; }

        public bool IsValid { get; set; }
    }
}
