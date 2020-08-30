using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace SangonBattle.Data.Programs
{
    public class CsvProgramMapping : CsvMapping<BattleProgram>
    {
        public CsvProgramMapping()
            : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.Name);
            MapProperty(2, x => x.Description);
        }
    }
}
