using System.Collections.Generic;


/// <summary>
/// M + -> I, - -> E
/// B + ->N, - ->S
/// T + ->F - ->T
/// I + ->P, - ->J
/// </summary>
namespace SangonBattle.Shared
{
    public interface ISurveyResult
    {
        public int Id { get; set; }
        public MbtiResult MbtiResult { get; set; }
        public List<MbtiResult> MbtiPartners { get; set; }

        public Bear SuggestedBear { get; set; }
        public string BearDescription { get; set; }

        public BattleProgram SuggestedProgram { get; set; }

        public List<Club> SuggestedClubs { get; set; }
        public string ClubDesription { get; set; }
    }
}