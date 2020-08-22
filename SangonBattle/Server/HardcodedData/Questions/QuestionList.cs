using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SangonBattle.Server.HardcodedData.Questions
{
    public class QuestionList
    {
        public static List<Question> GetQuestionList()
        {
            List<Question> questions = new List<Question>();

            questions.Add(new Question
            {
                Id = 0,
                Category = CategoryType.Active,
                Content = "당신은 활동적입니까?",
            });
            questions.Add(new Question
            {
                Id = 1,
                Category = CategoryType.Active,
                Content = "운동 좋아하세요?",
            }); questions.Add(new Question
            {
                Id = 2,
                Category = CategoryType.Delicate,
                Content = "실뜨기 좋아합니까?",
            }); questions.Add(new Question
            {
                Id = 3,
                Category = CategoryType.Emotional,
                Content = "노래를 듣고 눈물을 흘린적이 있나요?",
            }); questions.Add(new Question
            {
                Id = 4,
                Category = CategoryType.Rational,
                Content = "이과입니까?",
            }); questions.Add(new Question
            {
                Id = 5,
                Category = CategoryType.Rational,
                Content = "Frequency라는 단어를 보면 주파수가 떠오르십니까?",
            });

            return questions;
        }
    }
}
