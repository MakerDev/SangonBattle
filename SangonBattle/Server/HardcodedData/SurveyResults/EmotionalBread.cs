using SangonBattle.Client.Pages;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SangonBattle.Server.HardcodedData.SurveyResults
{
    public class EmotionalBread : ISurveyResult
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = "감성적인 식빵";
        public string Caption { get; set; } = "당신은 감성적인 식빵입니다. ㅋㅋ";
        public CategoryType CategoryType { get; set; } = CategoryType.Emotional;
        public string CategoryCaption { get; set; } = "당신은 감성적이니까 미술을 전공하세요";
        public CharacterType CharacterType { get; set; } = CharacterType.Bread;
        public string CharacterCaption { get; set; } = "저는 식빵보다는 소보루가 좋습니다.";
        public List<string> ClubSuggestions { get; set; } = new List<string>
        {
            "마술동아리 NTIZ",
            "뮤지컬 동아리 로뎀스",
        };

        public List<string> GameSuggestions { get; set; } = new List<string>
        {
            "공던지기",
            "피구",
        };
    }
}
