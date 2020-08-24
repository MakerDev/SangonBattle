using MediatR;
using SangonBattle.Data.HardcodedData;
using SangonBattle.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SangonBattle.Application.Survey
{
    public class GetResult
    {
        public class Query : IRequest<ISurveyResult>
        {
            public int ResultId { get; set; }
        }

        public class Hander : IRequestHandler<Query, ISurveyResult>
        {
            private readonly StaticContext _staticContext;

            public Hander(StaticContext staticContext)
            {
                _staticContext = staticContext;
            }

            public async Task<ISurveyResult> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _staticContext.GetRandomResult();

                return result;
            }
        }
    }
}
