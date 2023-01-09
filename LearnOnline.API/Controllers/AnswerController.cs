using LearnOnline.API.Services.AnswerService;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : Controller
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        [HttpGet("{partId}")]
        public ActionResult<ServiceResponse<List<Answer>>> GetByPartId(int PartId)
        {
            var resulst = _answerService.GetAnswerById(PartId);
            return Ok(resulst);
        }
    }
}
