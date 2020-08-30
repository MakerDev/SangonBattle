using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

namespace SangonBattle.Data.Clubs
{
    public class CsvClubMapping : CsvMapping<Club>
    {
        public CsvClubMapping()
            : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.CategoryName);
            MapProperty(2, x => x.SiteUrl);
        }
    }

}
