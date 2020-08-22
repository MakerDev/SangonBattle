using SangonBattle.Client.Pages;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SangonBattle.Server.HardcodedData.SurveyResults
{
    public class ActiveCar : ISurveyResult
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; } = "정열적인 자동차";
        public string Caption { get; set; } = "당신은 정열적인 자동차임";
        public CategoryType CategoryType { get; set; } = CategoryType.Active;
        public string CategoryCaption { get; set; } = "운동 좋아하세요? 제발 그랬으면 좋겠다";
        public CharacterType CharacterType { get; set; } = CharacterType.Car;
        public string CharacterCaption { get; set; } = "어떤 자동차 좋아하세요? 난 롤스로이스";
        public List<string> ClubSuggestions { get; set; } = new List<string>
        {
            "마술동아리 NTIZ",
            "연세 이글스",
        };

        public List<string> GameSuggestions { get; set; } = new List<string>
        {
            "투포환",
            "레슬링",
        };
    }
}
