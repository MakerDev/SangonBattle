using SangonBattle.Client.Pages;
using SangonBattle.Server.HardcodedData.Questions;
using SangonBattle.Server.HardcodedData.SurveyResults;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SangonBattle.Server.HardcodedData
{
    public class StaticContext
    {
        public List<Question> Questions { get; set; }
        public Dictionary<int, ISurveyResult> SurveyResults { get; set; } = new Dictionary<int, ISurveyResult>();

        public StaticContext()
        {
            //Load questions with json
            Questions = QuestionList.GetQuestionList();
            //Load all results with reflection
            SurveyResults.Add(0, new EmotionalBread());
            SurveyResults.Add(1, new ActiveCar());
            SurveyResults.Add(2, new DelicateBird());
        }

        public ISurveyResult GetRandomResult()
        {
            Random random = new Random();

            return SurveyResults[random.Next(0, SurveyResults.Count)];
        }

        public ISurveyResult GetResult(int id)
        {
            if (SurveyResults.ContainsKey(id))
            {
                return SurveyResults[id];
            }

            return null;
        }
    }
}
