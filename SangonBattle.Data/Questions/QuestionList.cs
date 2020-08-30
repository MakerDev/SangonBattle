using SangonBattle.Shared;
using System.Collections.Generic;

namespace SangonBattle.Data.Questions
{
    public class QuestionList
    {
        public static List<Question> GetQuestionList()
        {
            List<Question> questions = new List<Question>
            {
                new Question
                {
                    Category = CategoryType.TypeM,
                    Content = "다른 사람들에게 자신을 소개하는 것을 어려워 합니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeM,
                    Content = "보통 대화를 먼저 시작하지 않습니다",
                },
                new Question
                {
                    Category = CategoryType.TypeT,
                    Content = "순전히 호기심 때문에 어떤 행동을 하는 경우가 종종 있습니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeT,
                    Content = "적응을 잘 하는 것이 체계적인 것보다 더 중요합니다",
                },
                new Question
                {
                    Category = CategoryType.TypeT,
                    Content = "논쟁에서 이기는 것보다 상대방을 불쾌하지 않도록 하는 것이 더 중요합니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeI,
                    Content = "집과 업무 환경이 주로 어질러져 있습니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeM,
                    Content = "주목받는 일이 있다면 피하는 편입니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeB,
                    Content = "본인이 현실적이기보다 창의적인 사람이라고 생각합니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeI,
                    Content = "보통 여행 계획은 출발지, 도착지, 숙소만 정하는 편입니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeI,
                    Content = "업무 스타일이 체계적이고 조직적이라기 보다는 그때 그때 몰아서 처리하는 편입니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeM,
                    Content = "재미있는 책이나 비디오 게임이 종종 사교 모임보다 더 낫습니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeB,
                    Content = "상대방이 이메일에 재빨리 회신하지 않을 경우, 본인이 말실수를 했는지 걱정하기 시작합니다",
                },
                new Question
                {
                    Category = CategoryType.TypeI,
                    Content = "주의깊게 미리 계획하기 보다는 즉흥적으로 움직입니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeB,
                    Content = "중요한 결정을 내려야 할 때 일반적으로 논리보다 마음이 이끄는 것이 더 중요합니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeT,
                    Content = "친구가 어떤 일로 슬퍼할 경우, 문제해결방법을 제시하기보다 정신적인 지지를 제공하곤 합니다.",
                },
                new Question
                {
                    Category = CategoryType.TypeB,
                    Content = "책, 예술 또는 영화 등 색다르고 다양한 해석이 가능한 것에 관심이 크지 않습니다.",
                }
            };


            for (int i = 0; i < questions.Count; i++)
            {
                questions[i].Id = i;
            }

            return questions;
        }
    }
}
