using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SangonBattle.Shared;
using SangonBattle.Shared.DTO;

namespace SangonBattle.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        [HttpPost]
        public ActionResult<SurveyResult> Submit(List<Submission> submissions)
        {
            //TODO : loop through submissions and 

            return new SurveyResult();
        }
    }
}
