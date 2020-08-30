using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.Bears
{
    public class CsvBearMapping: CsvMapping<Bear>
    {
        public CsvBearMapping()
            : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.Name);
            MapProperty(2, x => x.Pictures, new BearPicturesTypeConverter());
        }
    }

    class BearPicturesTypeConverter : ITypeConverter<List<string>>
    {
        public Type TargetType => typeof(List<string>);

        public bool TryConvert(string value, out List<string> result)
        {
            result = value.Split('/').ToList();

            return true;
        }
    }
}
