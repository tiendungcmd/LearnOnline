using LearnOnline.API.Services.PartService;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : Controller
    {
        private readonly IPartService _partService;

        public PartController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        public ActionResult<ServiceResponse<List<Part>>> GetParts()
        {
            var resulst = _partService.GetParts();
            return Ok(resulst);
        }
        [HttpGet("PartId")]
        public ActionResult<ServiceResponse<List<Part>>> GetByPartId(int PartId)
        {
            var resulst = _partService.GetPartById(PartId);
            return Ok(resulst);
        }

        //[HttpGet("check")]
        //public ActionResult<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto)
        //{
        //    var response = _answerService.CheckResult(answerDto);
        //    return Ok(response);
        //}
    }
}
