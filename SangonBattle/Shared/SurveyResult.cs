using System.Collections.Generic;

namespace SangonBattle.Shared
{
    public class SurveyResult : ISurveyResult
    {
        public int Id { get; set; }
        public MbtiResult MbtiResult { get; set; }
        public List<MbtiResult> MbtiPartners { get; set; } = new List<MbtiResult>();
        public Bear SuggestedBear { get; set; }
        public string BearDescription { get; set; }
        public BattleProgram SuggestedProgram { get; set; }
        public string ProgramDescription { get; set; }
        public List<Club> SuggestedClubs { get; set; } = new List<Club>();
        public string ClubDesription { get; set; }
    }
}
