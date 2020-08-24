using MediatR;
using Microsoft.AspNetCore.Mvc;
using SangonBattle.Application.Survey;
using SangonBattle.Shared;
using SangonBattle.Shared.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SangonBattle.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SurveyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetQuestions()
        {
            return Ok(await _mediator.Send(new GetQuestions.Query()));
        }

        [HttpGet("results/{id}")]
        public async Task<ActionResult<ISurveyResult>> GetResult(int id)
        {
            var result = await _mediator.Send(new GetResult.Query { ResultId = id });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("submit")]
        public async Task<ActionResult<int>> Submit(List<Submission> submissions)
        {
            var resultId = await _mediator.Send(new Evaluate.Command { Submissions = submissions });

            return Ok(resultId);
        }
    }
}
