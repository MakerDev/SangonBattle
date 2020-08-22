using System.Collections.Generic;

namespace SangonBattle.Shared
{
    public interface ISurveyResult
    {
        int Id { get; set; }
        string Title { get; set; }
        string Caption { get; set; }
        string CategoryCaption { get; set; }
        CategoryType CategoryType { get; set; }
        string CharacterCaption { get; set; }
        CharacterType CharacterType { get; set; }
        List<string> ClubSuggestions { get; set; }
        List<string> GameSuggestions { get; set; }
    }
}