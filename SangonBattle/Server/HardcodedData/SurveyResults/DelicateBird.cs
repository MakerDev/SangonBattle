using SangonBattle.Client.Pages;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SangonBattle.Server.HardcodedData.SurveyResults
{
    public class DelicateBird : ISurveyResult
    {
        public int Id { get; set; } = 2;
        public string Title { get; set; } = "섬세한 비둘기";
        public string Caption { get; set; } = "당신은 섬세한 비둘기입니다.";
        public CategoryType CategoryType { get; set; } = CategoryType.Delicate;
        public string CategoryCaption { get; set; } = "섬세한 당신은 손을 다치지 않고 납땜을 할 수 있을 것입니다.";
        public CharacterType CharacterType { get; set; } = CharacterType.Bird;
        public string CharacterCaption { get; set; } = "비둘기야 먹자";
        public List<string> ClubSuggestions { get; set; } = new List<string>
        {
            "섬세한 NTIZ",
            "보드게임 동아리",
        };

        public List<string> GameSuggestions { get; set; } = new List<string>
        {
            "설탕뽑기 모양 만들기",
            "실뜨기",
            "젓가락으로 완두콩 집기",
        };
    }
}
