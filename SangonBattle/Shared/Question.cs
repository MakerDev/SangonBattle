using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBattle.Shared
{

    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public CategoryType Category { get; set; }
    }
}
