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
        }
        [HttpGet("PartId")]
        public ActionResult<ServiceResponse<PartDto>> GetByPartId(int PartId)
        {
            var partDto = new PartDto();
            var resulst = _learnOnlineDb.Parts.FirstOrDefault(x => x.Id == PartId);
            if(resulst != null)
            {
                partDto.Title = resulst.Title;
                partDto.CategoryId = resulst.CategoryId;
                partDto.Record = resulst.Record;
                partDto.SkillId = resulst.SkillId;
                partDto.Description = resulst.Description;
                return Ok(partDto);
            }
            return BadRequest();
        }
        [HttpGet("SkillId")]
        public ActionResult<List<Part>> GetByPartSkillId(int SkillId)
        {
            var part = _learnOnlineDb.Parts.Where(x => x.SkillId == SkillId).ToList();
            return Ok(part);
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
            part.Record = request.Record;
            if (request.Id != 0)
            {
                part.Id = request.Id;
                _learnOnlineDb.Parts.Update(part);
            }
            else
            {
                _learnOnlineDb.Parts.Add(part);
            }
            _learnOnlineDb.SaveChanges();
            return Ok(new ServiceResponse<Part>
            {
                Data = part
            });
        }
        [HttpDelete("{Id}")]
        public ActionResult DeletePart(int Id)
        {
            var part = _learnOnlineDb.Parts.FirstOrDefault(x => x.Id == Id);
            _learnOnlineDb.Parts.Remove(part);
            _learnOnlineDb.SaveChanges();
            return Ok();
        }
    }
}
