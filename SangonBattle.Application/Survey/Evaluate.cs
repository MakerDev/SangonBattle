using MediatR;
using SangonBattle.Data;
using SangonBattle.Shared;
using SangonBattle.Shared.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SangonBattle.Application.Survey
{
    public class Evaluate
    {
        public class Command : IRequest<int>
        {
            public List<Submission> Submissions { get; set; }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly StaticContext _staticContext;

            public Handler(StaticContext staticContext)
            {
                _staticContext = staticContext;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                int m = 0;
                int b = 0;
                int t = 0;
                int i = 0;

                foreach (var submission in request.Submissions)
                {
                    switch (submission.Category)
                    {
                        case CategoryType.TypeM:
                            m += submission.Point;
                            break;
                        case CategoryType.TypeB:
                            b += submission.Point;
                            break;
                        case CategoryType.TypeT:
                            t += submission.Point;
                            break;
                        case CategoryType.TypeI:
                            i += submission.Point;
                            break;
                        default:
                            break;
                    }
                }

                var mbtiResult = new MbtiResult(m, b, t, i);
                var surveyResult = _staticContext.SurveyResults
                    .Where(x => x.MbtiResult == mbtiResult).FirstOrDefault();

                //HACK : delete this
                if (surveyResult == null)
                {
                    return 1;
                }

                return surveyResult.Id;
            }
        }
    }


}
