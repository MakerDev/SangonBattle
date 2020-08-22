using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBattle.Shared
{
    public class SurveyResult : ISurveyResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public CharacterType CharacterType { get; set; }
        public string CharacterCaption { get; set; }
        public CategoryType CategoryType { get; set; }
        public string CategoryCaption { get; set; }
        public List<string> GameSuggestions { get; set; }
        public List<string> ClubSuggestions { get; set; }
    }
}
