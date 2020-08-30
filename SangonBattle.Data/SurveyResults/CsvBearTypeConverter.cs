using SangonBattle.Shared;
using System;
using System.Linq;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.SurveyResults
{
    class CsvBearTypeConverter : ITypeConverter<Bear>
    {
        private readonly StaticContext _staticContext;

        public CsvBearTypeConverter(StaticContext staticContext)
        {
            _staticContext = staticContext;
        }

        public Type TargetType => typeof(Bear);

        public bool TryConvert(string value, out Bear result)
        {
            result = _staticContext.Bears.FirstOrDefault(x => x.Name == value);

            if (result == null)
                throw new ApplicationException($"Bear {value} is not found");

            return true;
        }
    }
}
