using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBattle.Shared
{
    public class Bear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Pictures { get; set; } = new List<string>();
    }
}
