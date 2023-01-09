using LearnOnline.API.Services.QuestionService;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpGet("{partId}")]
        public ActionResult<ServiceResponse<List<Question>>> GetByPartId(int PartId)
        {
            var resulst = _questionService.GetQuestionByPartId(PartId);
            return Ok(resulst);
        }
    }
}
