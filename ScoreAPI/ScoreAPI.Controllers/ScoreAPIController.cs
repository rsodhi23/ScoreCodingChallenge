using Microsoft.AspNetCore.Mvc;
using ScoreAPI.BusinessLayer;
using ScoreAPI.Models;

namespace ScoreAPI.Controllers
{
    [ApiController]
    [Route("/scoreAPI")]
    public class ScoreAPIController : ControllerBase
    {
        private readonly IScoreHandler _scoreHandler;
        public ScoreAPIController(IScoreHandler scoreHandler)
        {
            _scoreHandler = scoreHandler;
        }

        [HttpPost("calculateScore")]
        [Produces("application/json")]
        public IActionResult CalculateScore([FromBody]User user)
        {
            try
            { 
                var score = _scoreHandler.CalculateScore(user);
                return Ok(score);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error occured {ex.Message}");
            }
        }
    }
}
