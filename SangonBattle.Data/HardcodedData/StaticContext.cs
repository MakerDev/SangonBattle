using SangonBattle.Data.HardcodedData.Questions;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SangonBattle.Data.HardcodedData
{
    public class StaticContext
    {
        private List<Question> _questions { get; set; }
        private Dictionary<int, ISurveyResult> _surveyResults { get; set; } = new Dictionary<int, ISurveyResult>();

        public StaticContext()
        {
            //TODO : Load questions with json
            _questions = QuestionList.GetQuestionList();
            LoadSurveyResults();
        }

        private void LoadSurveyResults()
        {
            var resultTypes = Assembly
                .GetAssembly(typeof(StaticContext))
                .GetTypes()
                .Where(type => type.IsClass && typeof(ISurveyResult).IsAssignableFrom(type))
                .Where(type => type.Name != nameof(SurveyResult))
                .ToList();

            for (int i = 0; i < resultTypes.Count; i++)
            {
                var instance = Activator.CreateInstance(resultTypes[i]) as ISurveyResult;

                _surveyResults.Add(i, instance);
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
