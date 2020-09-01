using SangonBattle.Shared;
using System;
using System.Linq;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.SurveyResults
{
    class CsvSuggestedProgramConverter : ITypeConverter<BattleProgram>
    {
        private readonly StaticContext _staticContext;

        public CsvSuggestedProgramConverter(StaticContext staticContext)
        {
            _staticContext = staticContext;
        }

        public Type TargetType => typeof(BattleProgram);

        public bool TryConvert(string value, out BattleProgram result)
        {
            result = _staticContext.BattlePrograms.FirstOrDefault(x => x.Name == value);

            if (result == null)
                throw new ApplicationException($"program {value} is not found");

            return true;
        }
    }
}
