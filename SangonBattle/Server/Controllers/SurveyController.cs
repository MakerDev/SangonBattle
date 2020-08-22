using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SangonBattle.Server.HardcodedData;
using SangonBattle.Shared;
using SangonBattle.Shared.DTO;

namespace SangonBattle.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly StaticContext _staticContext;

        public SurveyController(StaticContext staticContext)
        {
            _staticContext = staticContext;
        }

        [HttpGet]
        public ActionResult<List<Question>> GetQuestions()
        {
            return Ok(_staticContext.Questions);
        }

        [HttpGet("results/{id}")] 
        public ActionResult<ISurveyResult> GetResult(int id)
        {
            return Ok(_staticContext.SurveyResults[id]);

        }

        [HttpPost("submit")]
        public ActionResult<int> Submit(List<Submission> submissions)
        {
            //TODO : loop through submissions and 
            //ResultId
            return Ok(1);
        }
    }
}
