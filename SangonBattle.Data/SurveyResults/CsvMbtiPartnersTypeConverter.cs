using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.SurveyResults
{
    class CsvMbtiPartnersTypeConverter : ITypeConverter<List<MbtiResult>>
    {
        private readonly StaticContext _staticContext;

        public CsvMbtiPartnersTypeConverter(StaticContext staticContext)
        {
            _staticContext = staticContext;
        }

        public Type TargetType => typeof(List<MbtiResult>);

        public bool TryConvert(string value, out List<MbtiResult> result)
        {
            result = new List<MbtiResult>();

            var partnerList = value.Split('/').ToList();

            foreach (var partner in partnerList)
            {
                //var mbtiResult = _staticContext.MbtiResults.FirstOrDefault(x => x != null && x.Mbti == partner) ?? new MbtiResult(partner);
                //HACK : Because of Parallism issue!
                var mbtiResult = new MbtiResult(partner);

                result.Add(mbtiResult);
            }

            return true;
        }
    }

}
