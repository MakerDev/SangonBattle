using MediatR;
using SangonBattle.Data.HardcodedData;
using SangonBattle.Shared.DTO;
using System.Collections.Generic;
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


                return 1;
            }
        }
    }


}
