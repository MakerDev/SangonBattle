using SangonBattle.Data.Bears;
using SangonBattle.Data.Clubs;
using SangonBattle.Data.Programs;
using SangonBattle.Data.Questions;
using SangonBattle.Data.SurveyResults;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TinyCsvParser;

namespace SangonBattle.Data
{
    public class StaticContext
    {
        public List<ISurveyResult> SurveyResults
        {
            get
            {
                return _surveyResults.Values.ToList();
            }
        }
        public List<MbtiResult> MbtiResults { get; private set; } = new List<MbtiResult>();
        public List<Bear> Bears { get; private set; }
        public List<Club> Clubs { get; private set; }
        public List<BattleProgram> BattlePrograms { get; private set; }

        private List<Question> _questions;
        private Dictionary<int, ISurveyResult> _surveyResults = new Dictionary<int, ISurveyResult>();
        private readonly CsvParserOptions _csvParserOptions = new CsvParserOptions(true, ',');

        public StaticContext()
        {
            //TODO : Load questions with json
            _questions = QuestionList.GetQuestionList();

            Bears = LoadBears();
            Clubs = LoadClubs();
            BattlePrograms = LoadPrograms();

            LoadSurveyResults();
        }

        private List<Bear> LoadBears()
        {
            var csvParser = new CsvParser<Bear>(_csvParserOptions, new CsvBearMapping());
            var records = csvParser.ReadFromFile("bears.csv", Encoding.UTF8)
                                .Select(x => x.Result)
                                .ToList();

            return records;
        }

        private List<Club> LoadClubs()
        {
            var csvParser = new CsvParser<Club>(_csvParserOptions, new CsvClubMapping());
            var records = csvParser.ReadFromFile("clubs.csv", Encoding.UTF8)
                                .Select(x => x.Result)
                                .ToList();

            return records;
        }

        private List<BattleProgram> LoadPrograms()
        {
            var csvParser = new CsvParser<BattleProgram>(_csvParserOptions, new CsvProgramMapping());
            var records = csvParser.ReadFromFile("programs.csv", Encoding.UTF8)
                                .Select(x => x.Result)
                                .ToList();

            return records;
        }

        private void LoadSurveyResults()
        {
            var csvParser = new CsvParser<SurveyResult>(_csvParserOptions, new CsvSurveyResultMapping(this));
            var surveyResults = csvParser.ReadFromFile("surveyresults.csv", Encoding.UTF8)
                                .Select(x => x.Result)
                                .ToList();

            foreach (var surveyResult in surveyResults)
            {
                _surveyResults.Add(surveyResult.Id, surveyResult);
            }
        }

        public ISurveyResult GetRandomResult()
        {
            Random random = new Random();

            return _surveyResults[random.Next(0, _surveyResults.Count)];
        }

        public ISurveyResult GetResult(int id)
        {
            if (_surveyResults.ContainsKey(id))
            {
                return _surveyResults[id];
            }

            return null;
        }

        public List<Question> GetQuestions()
        {
            return _questions;
        }
    }
}
