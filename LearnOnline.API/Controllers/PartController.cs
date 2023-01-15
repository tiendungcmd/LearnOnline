using LearnOnline.API.Data;
using LearnOnline.API.Services.PartService;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : Controller
    {
        private readonly IPartService _partService;
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public PartController(IPartService partService, LearnOnlineDbContext learnOnlineDb)
        {
            _partService = partService;
            _learnOnlineDb = learnOnlineDb;
        }

        [HttpGet]
        public ActionResult<ServiceResponse<List<Part>>> GetParts()
        {
            var resulst = _partService.GetParts();
            return resulst;
            //var result = _learnOnlineDb.Parts.ToList();
            //return Ok(new ServiceResponse<List<Part>>
            //{
            //    Data = result
            //}); 
        }
        [HttpGet("PartId")]
        public ActionResult<ServiceResponse<List<Part>>> GetByPartId(int PartId)
        {
            var resulst = _partService.GetPartById(PartId);
            return Ok(resulst);
        }
        [HttpPost]
        public ActionResult<ServiceResponse<Part>> CreatePart(PartDto request)
        {
            var part = new Part();
            part.CategoryId = request.CategoryId;
            part.Title = request.Title;
            part.Description = request.Description;
            part.SkillId = request.SkillId;
            part.LevelId = 1;
            _learnOnlineDb.Parts.Add(part);
            _learnOnlineDb.SaveChanges();
            return Ok(new ServiceResponse<Part>
            {
                Data = part
            });
        }
        //[HttpGet("check")]
        //public ActionResult<ServiceResponse<AnswerDto>> CheckResult(AnswerDto answerDto)
        //{
        //    var response = _answerService.CheckResult(answerDto);
        //    return Ok(response);
        //}
    }
}
