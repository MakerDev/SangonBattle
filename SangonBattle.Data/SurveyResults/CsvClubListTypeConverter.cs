using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.SurveyResults
{
    class CsvClubListTypeConverter : ITypeConverter<List<Club>>
    {
        private readonly StaticContext _context;

        public CsvClubListTypeConverter(StaticContext context)
        {
            _context = context;
        }

        public Type TargetType => typeof(List<Club>);

        public bool TryConvert(string value, out List<Club> result)
        {
            result = new List<Club>();

            List<string> clubCategoryNames = value.Split('/').ToList();

            foreach (var categoryName in clubCategoryNames)
            {
                var club = _context.Clubs.FirstOrDefault(x => x.CategoryName == categoryName);

                if (club != null)
                {
                    result.Add(club);
                }
                else
                {
                    throw new ApplicationException($"Couldn't find this club {categoryName}");
                }
            }

            return true;
        }
    }

}
