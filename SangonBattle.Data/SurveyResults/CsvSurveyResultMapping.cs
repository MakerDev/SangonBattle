using SangonBattle.Shared;
using System.Text;
using TinyCsvParser.Mapping;

namespace SangonBattle.Data.SurveyResults
{
    public class CsvSurveyResultMapping : CsvMapping<SurveyResult>
    {
        public CsvSurveyResultMapping(StaticContext staticContext)
            : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.MbtiResult, new CsvMbtiTypeConverter(staticContext));
            MapProperty(2, x => x.SuggestedClubs, new CsvClubListTypeConverter(staticContext));
            MapProperty(3, x => x.MbtiPartners, new CsvMbtiPartnersTypeConverter(staticContext));
            MapProperty(4, x => x.SuggestedBear, new CsvBearTypeConverter(staticContext));
            MapProperty(5, x => x.BearDescription);
            MapProperty(6, x => x.ClubDesription);
            MapProperty(7, x => x.SuggestedProgram, new CsvSuggestedProgramConverter(staticContext));
            MapProperty(8, x => x.ProgramDescription);            
        }
    }
}
