using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBattle.Shared.DTO
{
    public class Submission
    {
        public int QuestionId { get; set; }
        public CategoryType Category { get; set; }
        public int Point { get; set; }
    }
}
