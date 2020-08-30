using MediatR;
using SangonBattle.Data;
using SangonBattle.Shared;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SangonBattle.Application.Survey
{
    public class GetQuestions
    {
        public class Query : IRequest<List<Question>>
        {

        }

        public class Hander : IRequestHandler<Query, List<Question>>
        {
            private readonly StaticContext _staticContext;

            public Hander(StaticContext staticContext)
            {
                _staticContext = staticContext;
            }

            public async Task<List<Question>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _staticContext.GetQuestions();
            }
        }
    }
}
