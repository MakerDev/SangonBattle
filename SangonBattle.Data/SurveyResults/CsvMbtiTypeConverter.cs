using SangonBattle.Shared;
using System;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.SurveyResults
{
    class CsvMbtiTypeConverter : ITypeConverter<MbtiResult>
    {
        private readonly StaticContext _context;

        public CsvMbtiTypeConverter(StaticContext context)
        {
            _context = context;
        }

        public Type TargetType => typeof(MbtiResult);

        public bool TryConvert(string value, out MbtiResult result)
        {
            result = new MbtiResult(value);

            _context.MbtiResults.Add(result);

            return true;
        }
    }

}
