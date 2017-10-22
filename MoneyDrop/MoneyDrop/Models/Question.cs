using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int QuizzId { get; set; }

        public int Order { get; set; }

        public string Text { get; set; }
    }
}
